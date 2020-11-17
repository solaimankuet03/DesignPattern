using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommandDesignPatternRealTimeExample
{
    class Program
    {
        static void Main(string[] args)
        {
            Light light = new Light();
            ICommand onCommand = new LightOnCommand(light);
            ICommand offCommand = new LightOffCommand(light);

            Switch _switch = new Switch(onCommand, offCommand);
            _switch.SwitchOn();
            _switch.SwitchOff();

            Console.ReadKey();
        }
    }
}
