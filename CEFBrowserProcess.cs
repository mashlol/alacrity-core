using System;
using System.IO;
using Xilium.CefGlue;
using System.Threading.Tasks;
using System.Text;
using Alacrity.Common;
using System.Threading;

namespace Alacrity {

    public class CEFBrowserProcess {

        private static readonly ManualResetEvent _quitEvent = new(false);

        public static int Main(string[] args) {
            var cefRuntimePath = File.ReadAllText("cefpath");

            CefRuntime.Load(cefRuntimePath);

            // Not the main process, just a subprocess created by CEF. For these, just invoke CEF as expected.
            if (args[0].StartsWith("--")) {
                CEF.InitCef();
                return 0;
            }

            // Main process, start up CEF for the first time
            var url = args[0];
            var width = int.Parse(args[1]);
            var height = int.Parse(args[2]);
            var framerate = int.Parse(args[3]);
            var bufferSize = int.Parse(args[4]);
            var securityString = args[5];
            var remotePort = int.Parse(args[6]);
            var ipcPort = int.Parse(args[7]);
            var websocketPort = int.Parse(args[8]);
            var cacheDirectory = args.Length >= 10 ? args[9] : null;

            // File IPC, we write a file for the websocket port. We could use the regular CEF IPC methods, but we'd
            // get a weird control flow when initializing a new render process, where the port is used.
            FileIPC.WriteWSInfo(websocketPort, securityString);

            try {
                var cefClient = CEF.StartCef(url, width, height, framerate, remotePort, cacheDirectory);

                var ipcPipe = new IPCPipe(false, bufferSize);
                ipcPipe.Connect(ipcPort, TaskScheduler.Default);

                cefClient.OnAcceleratedPaint((handle, type) => {
                    var evtName = type == CefPaintElementType.View ? "_internal_ntex:" : "_internal_ptex:";
                    var data = Encoding.ASCII.GetBytes(evtName + handle);
                    ipcPipe.Write(data, data.Length);
                });

                cefClient.OnPopupShow((isShown) => {
                    var evtName = isShown ? "_internal_spop" : "_internal_hpop";
                    var data = Encoding.ASCII.GetBytes(evtName);
                    ipcPipe.Write(data, data.Length);
                });

                cefClient.OnPopupSize((x, y, w, h) => {
                    var data = Encoding.ASCII.GetBytes("_internal_prec:" + x + "," + y + "," + w + "," + h);
                    ipcPipe.Write(data, data.Length);
                });

                var eventHandler = new UnityIPCEventHandler(cefClient);
                ipcPipe.OnData(eventHandler.HandleEvent);

            } catch (Exception e) {
                Console.WriteLine(e.Message + "\n" + e.StackTrace);
            }

            Console.CancelKeyPress += (sender, eArgs) => {
                _quitEvent.Set();
                eArgs.Cancel = true;
            };
            _quitEvent.WaitOne();

            return 0;
        }

    }
}