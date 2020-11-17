using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommandDesignPatternRealTimeExample
{
    public class LightOffCommand : ICommand
    {
        private Light _light;

        public LightOffCommand(Light _light)
        {
            this._light = _light;
        }

        public void Execute()
        {
            _light.LightOff();
        }
    }
}
