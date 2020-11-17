using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommandDesignPatternRealTimeExample
{
    public class LightOnCommand : ICommand
    {
        private Light _light;

        public LightOnCommand(Light _light)
        {
            this._light = _light;
        }

        public void Execute()
        {
            _light.LightOn();
        }
    }
}
