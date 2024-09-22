using System.IO;

namespace Alacrity {

    public class FileIPC {

        private static readonly string WS_PORT_FILE = "wsport.txt";

        public static void WriteWSInfo(int port, string securityKey) {
            File.WriteAllText(WS_PORT_FILE, port + ":" + securityKey);
        }

        public static int GetWSPort() {
            var portTxt = File.ReadAllText(WS_PORT_FILE);
            return int.Parse(portTxt.Split(':')[0]);
        }

        public static string GetWSSecurityKey() {
            var portTxt = File.ReadAllText(WS_PORT_FILE);
            return portTxt.Split(':')[1];
        }

    }

}