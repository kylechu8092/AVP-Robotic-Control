using SerialTerminal;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Sockets;
using System.Net;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using ThreadManagement;

namespace TCPTerminal
{
    internal class TCPStart
    {
        public Socket _sender;
        public TCPRead reader;
        public TCPSend sender;

        public TCPStart()
        {

        }

        public void startServer()
        {
            try
            {
                //change IP and ports !!!!
                IPAddress address = IPAddress.Parse("67.207.113.134");
                IPEndPoint endPoint = new IPEndPoint(address, 4001);
                _sender = new Socket(address.AddressFamily, SocketType.Stream, ProtocolType.Tcp);
                _sender.Connect(endPoint);
                _sender.ReceiveTimeout = 6000;
                _sender.SendTimeout = 6000;
                ThreadList.readThread = new Thread(reader.readMessage);
                ThreadList.readThread.Start();
                initializeOperation();
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

        public void SendMsg(string msg)
        {
            sender.serialSend(msg);
        }

    }
}

