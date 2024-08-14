using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;

namespace SerialTerminal
{
    public class TCPRead
    {
        private Socket _sender;
        public TCPRead(Socket _sender) 
        {
            this._sender = _sender;
        }

        public void readMessage()
        {
            try
            {
                byte[] response;
                while (true)
                {
                    try
                    {
                        response = new byte[1024];
                        _sender.Receive(response);
                        string readData = Encoding.UTF8.GetString(response);
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