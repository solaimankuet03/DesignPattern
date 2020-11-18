using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VisitorDesignPattern
{
    public class Doctor : IVisitor
    {
        public string Name { get; set; }

        public Doctor(string name)
        {
            this.Name = name;
        }

        public void Visit(IElement element)
        {
            Kid kid = (Kid)element;

            Console.WriteLine("Doctor: " + this.Name + " did the health checkup of the child: " + kid.KidName);
        }
    }
}
