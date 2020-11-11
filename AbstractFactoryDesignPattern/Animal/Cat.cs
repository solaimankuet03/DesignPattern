using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactoryDesignPattern.Animal
{
    public class Cat : IAnimal
    {
        public string speak()
        {
            return "Meow";
        }
    }
}
