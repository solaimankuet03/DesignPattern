using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MediatorDesignPattern
{
    public abstract class User
    {
        protected IFacebookGroupMediator Mediator;
        protected string Name;

        public User(IFacebookGroupMediator Mediator, string name)
        {
            this.Mediator = Mediator;this.Name = name;
        }

        public abstract void Send(string message);
        public abstract void Receive(string message);
    }
}
