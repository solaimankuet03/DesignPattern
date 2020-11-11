using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactoryDesignPattern.Animal
{
    public class Shark : IAnimal
    {
        public string speak()
        {
            return "Cannot speak";
        }
    }
}
