using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Sockets;
using System.Net.WebSockets;
using System.Text;
using System.Threading.Tasks;

namespace SerialTerminal
{
    public class TCPSend
    {
        private Socket _sender;
        public TCPSend(Socket sender) 
        {
            _sender = sender;
        }

        public void serialSend(string userInput)
        {
            try
            {
                byte[] send = Encoding.UTF8.GetBytes(userInput);
                _sender.Send(send);
            }
            catch { }
        }
    }
}