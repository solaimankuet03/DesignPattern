using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MediatorDesignPattern
{
    public class ConcreteUser : User
    {
        public ConcreteUser(IFacebookGroupMediator Mediator, string name) : base(Mediator, name)
        {
        }

        public override void Receive(string message)
        {
            Console.WriteLine(this.Name + ": Received Message:" + message);
        }

        public override void Send(string message)
        {
            Console.WriteLine(this.Name + ": Sending Message=" + message + "\n");
            Mediator.SendMessage(message, this);
        }
    }
}
