using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeDesignPattern
{
    public interface ILEDTv
    {
        void SwitchOn();
        void SwitchOff();
        void SetChannel(int ChannelNumber);
    }
}
