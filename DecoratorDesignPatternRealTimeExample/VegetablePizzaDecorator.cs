using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecoratorDesignPatternRealTimeExample
{
    public class VegetablePizzaDecorator : PizzaDecorator
    {
        public VegetablePizzaDecorator(IPizza Pizza) : base(Pizza)
        {
        }

        public override string MakePizza()
        {
            string plainPizza = Pizza.MakePizza();
            plainPizza = plainPizza + " With " + AddVegetable();
            return plainPizza;
        }

        public string AddVegetable()
        {
            return "Vegetable";
        }
    }
}
