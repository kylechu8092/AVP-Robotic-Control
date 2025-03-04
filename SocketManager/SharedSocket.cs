﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net.Sockets;
using System.Net;

namespace SocketManager
{
    public class SharedSocket
    {
        Socket socket;
        public SharedSocket() 
        { 
            beginConnection();
        }

        public void beginConnection()
        {
            try
            {
                if (socket != null && socket.Connected)
                {
                    return;
                }
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
