using SharpPcap;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PacketAnalyzer
{
    public class PacketControl : IPacketcs
    {
        ICaptureDevice _device = new DeviceSelection().deviceSelection();

        public delegate void PacketArrivalEventHandler(object sender, PacketCapture e);
        public event PacketArrivalEventHandler packetArrival;
        public void capturePacket()
        {
            try
            {
                if (_device != null)
                {
                    _device.OnPacketArrival += new SharpPcap.PacketArrivalEventHandler(packetArrival);
                    int timeout = 1000;
                    _device.Open(DeviceModes.Promiscuous, timeout);
                    _device.Filter = "tcp";
                    _device.StartCapture();
                }
                else
                {
                    throw new Exception("Unable to find device");
                }
            }
            catch
            {

            }
        }

        public void stopCapture()
        {
            try
            {
                _device.StopCapture();
            }
            catch 
            {
            
            }
        }
    }
}
