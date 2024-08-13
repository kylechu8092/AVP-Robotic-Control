using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;
using ThreadManagement;

namespace SerialTerminal
{
    public class StartServer
    {
        TcpListener listener;
        TcpClient TcpClient = new TcpClient();

        public StartServer() { }

        public void startServer()
        {
            try
            {
                //change IP and ports
                IPAddress address = IPAddress.Parse("127.0.0.1");
                IPEndPoint endPoint = new IPEndPoint(address, 9999);
                listener = new TcpListener(endPoint);
                listener.Start();
                TcpClient = listener.AcceptTcpClient();
                ThreadManager
            }
            catch { }
        }
    }
}
