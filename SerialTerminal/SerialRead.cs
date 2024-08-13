using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;

namespace SerialTerminal
{
    public class SerialRead
    {
        TcpClient tcpClient = new TcpClient();
        NetworkStream serverStream = default(NetworkStream);
        //change IP and Port    
        string IP = "2.101.234";
        int port = 4001;

        public SerialRead() { } 

        public void readMessage()
        {
            try
            {
                tcpClient.Connect(IP, port);
                serverStream = tcpClient.GetStream();
                byte[] instream;
                var buffSize = 0;
                while(true)
                {
                    try
                    {
                        if (tcpClient.Connected)
                        {
                            serverStream.ReadTimeout = 2000;
                            instream = new byte[buffSize];
                            buffSize = tcpClient.ReceiveBufferSize;
                            int bytesRead = serverStream.Read(instream, 0, buffSize);
                            if (bytesRead > 0)
                            {
                                string readData = Encoding.UTF8.GetString(instream, 0, buffSize);
                            }

                        }
                    }
                    catch 
                    {
                    }
                }
            }
            catch 
            {
            }
        }
    }
}
