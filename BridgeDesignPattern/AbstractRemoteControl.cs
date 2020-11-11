using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeDesignPattern
{
    public abstract class AbstractRemoteControl
    {
        protected ILEDTv LEDTv;

        protected AbstractRemoteControl(ILEDTv LEDTv)
        {
            this.LEDTv = LEDTv;
        }

        public abstract void SwitchOn();
        public abstract void SwitchOff();
        public abstract void SetChannel(int channelNumber);
    }
}
