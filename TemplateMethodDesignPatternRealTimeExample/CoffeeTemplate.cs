using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TemplateMethodDesignPatternRealTimeExample
{
    public abstract class CoffeeTemplate
    {
        public void PrepareCoffee()
        {
            AddBoiledWater();
            AddMilk();
            AddSugar();
            AddCoffeePowder();

            Console.WriteLine(this.GetType().Name + " is Ready");
        }

        protected abstract void AddBoiledWater();
        protected abstract void AddMilk();
        protected abstract void AddSugar();
        protected abstract void AddCoffeePowder();
    }
}
