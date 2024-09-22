using System;
using Xilium.CefGlue;

namespace Alacrity {

    public class CEF {

        public class InitCefResult {
            public OffscreenCEFClient.OffscreenCEFApp app;
            public CefMainArgs args;
        }

        public static InitCefResult InitCef() {
            var cefMainArgs = new CefMainArgs(new string[] { });
            var cefApp = new OffscreenCEFClient.OffscreenCEFApp();

            // This is where the code path diverges for child processes.
            if (CefRuntime.ExecuteProcess(cefMainArgs, cefApp, IntPtr.Zero) != -1)
                throw new Exception("Failed to fork subprocesses");

            return new InitCefResult {
                app = cefApp,
                args = cefMainArgs,
            };
        }

        public static OffscreenCEFClient StartCef(
            string url,
            int width,
            int height,
            int framerate,
            int remoteDebuggingPort,
            string cacheDirectory
        ) {
            var initResult = InitCef();

            var cefSettings = new CefSettings {
                MultiThreadedMessageLoop = true,
                LogSeverity = CefLogSeverity.Disable,
                WindowlessRenderingEnabled = true,
                RemoteDebuggingPort = remoteDebuggingPort,
                CachePath = cacheDirectory,
            };

            CefRuntime.Initialize(initResult.args, cefSettings, initResult.app, IntPtr.Zero);

            CefWindowInfo cefWindowInfo = CefWindowInfo.Create();
            cefWindowInfo.SetAsWindowless(IntPtr.Zero, true);
            cefWindowInfo.SharedTextureEnabled = true;

            CefBrowserSettings cefBrowserSettings = new CefBrowserSettings() {
                JavaScript = CefState.Enabled,
                JavaScriptCloseWindows = CefState.Disabled,
                WindowlessFrameRate = framerate,
            };

            var cefClient = new OffscreenCEFClient(width, height);

            // Start up the browser instance.
            CefBrowserHost.CreateBrowser(
                cefWindowInfo,
                cefClient,
                cefBrowserSettings,
                url);

            return cefClient;
        }
    }
}