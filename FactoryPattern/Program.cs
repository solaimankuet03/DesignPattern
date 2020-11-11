using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            ICreditCard creditCard = CreditCardFactory.GetCreditCard("Titanium");

            Console.WriteLine(creditCard.GetCardType());
            Console.WriteLine(creditCard.GetCreditLimit());
            Console.WriteLine(creditCard.GetAnnualCharge());
            Console.ReadLine();
        }
    }
}
