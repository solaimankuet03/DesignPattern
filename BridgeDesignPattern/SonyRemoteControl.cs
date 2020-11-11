using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeDesignPattern
{
    public class SonyRemoteControl : AbstractRemoteControl
    {
        public SonyRemoteControl(ILEDTv LEDTv) : base(LEDTv)
        {
        }

        public override void SetChannel(int channelNumber)
        {
            LEDTv.SetChannel(channelNumber);
        }

        public override void SwitchOff()
        {
            LEDTv.SwitchOff();
        }

        public override void SwitchOn()
        {
            LEDTv.SwitchOn();
        }
    }
}
