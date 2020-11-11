using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecoratorDesignPatternRealTimeExample
{
    class Program
    {
        static void Main(string[] args)
        {
            IPizza pizza = new PlainPizza();
            string plainpizza = pizza.MakePizza();
            Console.WriteLine("Plain Pizza: " + plainpizza);

            ChickenPizzaDecorator chickenPizzaDecorator = new ChickenPizzaDecorator(pizza);
            Console.WriteLine("Chicken Pizza: " + chickenPizzaDecorator.MakePizza());

            VegetablePizzaDecorator vegetablePizzaDecorator = new VegetablePizzaDecorator(pizza);
            Console.WriteLine("Vegetable Pizza: " + vegetablePizzaDecorator.MakePizza());

            Console.ReadLine();
        }
    }
}
