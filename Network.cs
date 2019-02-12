using System;
using System.Net;
using System.Net.NetworkInformation;
using System.Net.Sockets;

namespace dwm_net_statusbar
{
    public static class Network
    {
        public static string Status() {
            string localIP;
            using (Socket socket = new Socket(AddressFamily.InterNetwork, SocketType.Dgram, 0))
            {
                socket.Connect("8.8.8.8", 65530);
                IPEndPoint endPoint = socket.LocalEndPoint as IPEndPoint;
                localIP = endPoint.Address.ToString();
            }
            return localIP;
        }

        public static string InterfaceStatus() {
            var nics = NetworkInterface.GetAllNetworkInterfaces();
            if (nics == null || nics.Length == 0) {
                return "no network";
            }
            var retval = string.Empty;
            foreach(var nic in nics) {
                if (nic.NetworkInterfaceType == NetworkInterfaceType.Loopback)
                    continue;
                if (nic.OperationalStatus == OperationalStatus.Up) {
                    foreach (UnicastIPAddressInformation ip in nic.GetIPProperties().UnicastAddresses)
                    {
                        if (ip.Address.AddressFamily == System.Net.Sockets.AddressFamily.InterNetwork)
                            retval += ip.Address.ToString();
                    }
                } else {
                    retval += $"{nic.Name} is {nic.OperationalStatus.ToString()}";
                }
            }
            return retval;
        }
    }
}