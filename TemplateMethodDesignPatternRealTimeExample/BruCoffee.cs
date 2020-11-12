using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TemplateMethodDesignPatternRealTimeExample
{
    public class BruCoffee : CoffeeTemplate
    {
        protected override void AddBoiledWater()
        {
            Console.WriteLine("Water Boiled");
        }

        protected override void AddCoffeePowder()
        {
            Console.WriteLine("Bru Coffee Powder Added");
        }

        protected override void AddMilk()
        {
            Console.WriteLine("Milk Added");
        }

        protected override void AddSugar()
        {
            Console.WriteLine("Sugar Added");
        }
    }
}
