using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommandDesignPatternRealTimeExample
{
    public class Light //receiver
    {
        public void LightOff()
        {
            Console.WriteLine("Light is Off");
        }

        public void LightOn()
        {
            Console.WriteLine("Light is On");
        }
    }
}
