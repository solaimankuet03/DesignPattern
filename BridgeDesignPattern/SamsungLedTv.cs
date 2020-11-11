using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeDesignPattern
{
    public class SamsungLedTv : ILEDTv
    {
        public void SetChannel(int ChannelNumber)
        {
            Console.WriteLine("Setting channel Number " + ChannelNumber + " on Samsung TV");
        }

        public void SwitchOff()
        {
            Console.WriteLine("Turning OFF : Samsung TV");
        }

        public void SwitchOn()
        {
            Console.WriteLine("Turning ON : Samsung TV");
        }
    }
}
