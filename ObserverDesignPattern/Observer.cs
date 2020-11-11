using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObserverDesignPattern
{
    public class Observer : IObserver
    {
        public string UserName { get; set; }

        public Observer(string UserName, ISubject Subject)
        {
            this.UserName = UserName;
            Subject.RegisterObserver(this);
        }

        public void update(string ProductAvailability)
        {
            Console.WriteLine("Hello " + UserName + ", Product is now " + ProductAvailability + " on Amazon");
        }
    }
}
