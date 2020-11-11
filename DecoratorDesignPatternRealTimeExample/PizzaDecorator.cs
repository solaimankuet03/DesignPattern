using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecoratorDesignPatternRealTimeExample
{
    public abstract class PizzaDecorator : IPizza
    {
        public IPizza Pizza;

        public PizzaDecorator(IPizza Pizza)
        {
            this.Pizza = Pizza;
        }

        public virtual string MakePizza()
        {
            return Pizza.MakePizza();
        }
    }
}
