using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeDesignPatternRealTimeExample
{
    public class ShortMessage : AbstractMessage
    {
        public ShortMessage(IMessageSender MessageSender) : base(MessageSender)
        {
        }

        public override void SendMessage(string Message)
        {
            if (Message.Length <= 10)
            {
                MessageSender.SendMessage(Message);
            }
            else
            {
                Console.WriteLine("Unable to send the message as length > 10 characters");
            }
        }
    }
}
