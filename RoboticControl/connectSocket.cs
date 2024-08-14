using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;

namespace RoboticControl
{
    public class connectSocket
    {
        Socket socket;
        public connectSocket() 
        {
            SocketConnection();
        }

        public void SocketConnection()
        {
            try
            {
                IPAddress ip = IPAddress.Parse("209.36.30.70");
                IPEndPoint localendPt = new IPEndPoint(ip, 4003);
                socket = new Socket(ip.AddressFamily, SocketType.Stream, ProtocolType.Tcp);
                socket.Connect(localendPt);
                socket.ReceiveTimeout = 5000;
                socket.SendTimeout = 5000;
            }
            catch (Exception e)
            {
                throw e;
            }
        }

        public Socket getSocket()
        {
            return socket;
        }
    }
}
