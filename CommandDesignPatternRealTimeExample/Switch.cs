using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommandDesignPatternRealTimeExample
{
    public class Switch //invoker
    {
        private ICommand onCommand;
        private ICommand offCommand;

        public Switch(ICommand _onCommand, ICommand _offCommand)
        {
            this.onCommand = _onCommand;
            this.offCommand = _offCommand;
        }

        public void SwitchOn()
        {
            onCommand.Execute();
        }

        public void SwitchOff()
        {
            offCommand.Execute();
        }
    }
}
