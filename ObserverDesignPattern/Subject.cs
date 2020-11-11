using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObserverDesignPattern
{
    public class Subject : ISubject
    {
        private List<IObserver> observers = new List<IObserver>();
        private string ProductName { get; set; }
        private int ProductPrice { get; set; }
        private string ProductAvailability { get; set; }

        public Subject(string ProductName, int ProductPrice, string ProductAvailability)
        {
            this.ProductName = ProductName;
            this.ProductPrice = ProductPrice;
            this.ProductAvailability = ProductAvailability;
        }

        public string GetAvailability()
        {
            return ProductAvailability;
        }

        public void SetAvailability(string Availability)
        {
            this.ProductAvailability = Availability;
            Console.WriteLine("Availability changed from Out of Stock to Available.");
            NotifyObservers();
        }

        public void NotifyObservers()
        {
            Console.WriteLine("Product Name :"
                            + ProductName + ", product Price : "
                            + ProductPrice + " is Now available. So notifying all Registered users ");
            Console.WriteLine();

            foreach (IObserver observer in observers)
            {
                observer.update(ProductAvailability);
            }
        }

        public void RegisterObserver(IObserver observer)
        {
            observers.Add(observer);
        }

        public void RemoveObserver(IObserver observer)
        {
            observers.Remove(observer);
        }
    }
}
