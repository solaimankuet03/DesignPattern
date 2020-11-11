using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeDesignPatternRealTimeExample
{
    public abstract class AbstractMessage
    {
        protected IMessageSender MessageSender;

        public AbstractMessage(IMessageSender MessageSender)
        {
            this.MessageSender = MessageSender;
        }

        public abstract void SendMessage(string Message);
    }
}
