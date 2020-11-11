using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecoratorDesignPatternRealTimeExample
{
    public class ChickenPizzaDecorator : PizzaDecorator
    {
        public ChickenPizzaDecorator(IPizza Pizza) : base(Pizza)
        {
        }

        public override string MakePizza()
        {
            string plainPizza = Pizza.MakePizza();
            plainPizza = plainPizza + " With " + AddChicken();
            return plainPizza;
        }

        public string AddChicken()
        {
            return "Chicken";
        }
    }
}
