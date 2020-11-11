using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeDesignPatternRealTimeExample
{
    public class LongMessage : AbstractMessage
    {
        public LongMessage(IMessageSender MessageSender) : base(MessageSender)
        {
        }

        public override void SendMessage(string Message)
        {
            
                MessageSender.SendMessage(Message);
            
        }
    }
}
