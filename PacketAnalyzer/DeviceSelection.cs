using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SharpPcap;
namespace PacketAnalyzer
{
    
    internal class DeviceSelection
    {
        ICaptureDevice _device;

        public ICaptureDevice deviceSelection()
        {
            try
            {
                var devices = CaptureDeviceList.Instance;
                if (devices == null)
                {
                    throw new Exception("No devices found");
                }
                else
                {
                    
                    //This must/ be configured on computer
                    _device = devices[5];
                    return _device;
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
