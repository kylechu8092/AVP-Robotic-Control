using PacketAnalyzer;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SharpPcap;
using PacketDotNet;

namespace LoginForm.ServiceForms
{
    public partial class PacketUI : UserControl
    {
        PacketControl sniffer = new PacketControl();
        public PacketUI()
        {
            InitializeComponent();
            sniffer.packetArrival += PacketArrivalEventHandler;
            sniffer.capturePacket();
        }
        private void PacketArrivalEventHandler(object sender, PacketCapture e)
        {
            try
            {
                if (InvokeRequired)
                {
                    var rawPacket = e.GetPacket();
                    var packet = PacketDotNet.Packet.ParsePacket(rawPacket.LinkLayerType, rawPacket.Data);
                    Invoke(new Action<Packet>(updateFeed), packet);
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void updateFeed(Packet p)
        {
            try
            {

                string protocol = "";
                string src = "";
                string dest = "";
                string length = "";
                string time = "";
                string info = "";
                var packet = (IPPacket)p.Extract<IPPacket>();
                if (packet != null)
                {
                    protocol = packet.Protocol.ToString();
                    src = packet.SourceAddress.ToString();
                    dest = packet.DestinationAddress.ToString();
                    length = packet.TotalLength.ToString();
                    time = DateTime.Now.ToString();
                    if (packet.PayloadPacket is PacketDotNet.TcpPacket tcppacket)
                    {
                        info = Encoding.UTF8.GetString(tcppacket.PayloadData);
                    }
                }
                dataGridView1.Rows.Insert(0, protocol, src, dest, info, length, time);
            }
            catch
            {

            }
        }



    }
}
