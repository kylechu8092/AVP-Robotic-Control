using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using ThreadManagement;

namespace SerialTerminal
{
    public class StartServer
    {
        public Socket _sender;
        public TCPRead reader;
        public TCPSend sender;

        public StartServer() 
        {
            startServer();
        }

        public void startServer()
        {
            try
            {
                //change IP and ports !!!!
                IPAddress address = IPAddress.Parse("209.36.30.70");
                IPEndPoint endPoint = new IPEndPoint(address, 4003);
                _sender = new Socket(address.AddressFamily, SocketType.Stream, ProtocolType.Tcp);
                _sender.Connect(endPoint);
                initializeOperation();
                _sender.ReceiveTimeout = 6000;
                _sender.SendTimeout = 6000;
                ThreadList.readThread = new Thread(reader.readMessage);
                ThreadList.readThread.Start();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public void initializeOperation()
        {
            reader = new TCPRead(_sender);
            sender = new TCPSend(_sender);
        }
        
        
        
    }
}