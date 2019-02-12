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
            IP();
            return localIP;
        }

        public static string IP() {
            var networkInterfaces = NetworkInterface.GetAllNetworkInterfaces();
            return null;
        }
    }
}