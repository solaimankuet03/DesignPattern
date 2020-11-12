using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TemplateMethodDesignPatternRealTimeExample
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Nescafe Coffee Preparation\n");
            CoffeeTemplate coffee = new NescafeCoffee();
            coffee.PrepareCoffee();
            Console.WriteLine();

            Console.WriteLine("Bru coffee preparation\n");
            coffee = new BruCoffee();
            coffee.PrepareCoffee();
            Console.Read();
        }
    }
}
