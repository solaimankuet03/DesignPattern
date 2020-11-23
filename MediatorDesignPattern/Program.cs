using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MediatorDesignPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            IFacebookGroupMediator Mediator = new ConcreteFacebookGroupMediator();
            User user1 = new ConcreteUser(Mediator, "User1");
            User user2 = new ConcreteUser(Mediator, "User2");
            User user3 = new ConcreteUser(Mediator, "User3");
            User user4 = new ConcreteUser(Mediator, "User4");
            User user5 = new ConcreteUser(Mediator, "User5");
            User user6 = new ConcreteUser(Mediator, "User6");

            Mediator.RegisterUser(user1);
            Mediator.RegisterUser(user2);
            Mediator.RegisterUser(user3);
            Mediator.RegisterUser(user4);
            Mediator.RegisterUser(user5);
            Mediator.RegisterUser(user6);

            User Dave = new ConcreteUser(Mediator, "Dave");
            User Rajesh = new ConcreteUser(Mediator, "Rajesh");

            Mediator.RegisterUser(Dave);
            Mediator.RegisterUser(Rajesh);

            Dave.Send("dotnettutorials.net - this website is very good to learn Design Pattern");
            Console.WriteLine();
            Rajesh.Send("What is Design Patterns? Please explain ");
            Console.Read();
        }
    }
}
