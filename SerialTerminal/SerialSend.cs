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
    public class SerialSend
    {
        TcpClient tcpClient = new TcpClient();

        public SerialSend() { }

        public void serialSend(string userInput)
        {
            try
            {
                if (tcpClient.Connected)
                {
                    byte[] send = Encoding.UTF8.GetBytes(userInput);
                    var stream = tcpClient.GetStream();
                    stream.Write(send, 0, send.Length);
                }

            }
            catch { }
        }
    }
}
