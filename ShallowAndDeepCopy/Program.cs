using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShallowAndDeepCopy
{
    class Program
    {
        static void Main(string[] args)
        {
            //shallow copy
            ShallowCopy shallowCopy = new ShallowCopy();
            shallowCopy.Name = "Solaiman";
            shallowCopy.Department = "IT";
            shallowCopy.EmpAddress = new Address() { address = "PBT" };

            ShallowCopy shallowCopy1 = shallowCopy.GetClone();            
            shallowCopy1.EmpAddress.address = "DIN";

            Console.WriteLine("Emplpyee 1: ");
            Console.WriteLine("Name: " + shallowCopy.Name + ", Address: " + shallowCopy.EmpAddress.address + ", Dept: " + shallowCopy.Department);
            Console.WriteLine("Emplpyee 2: ");
            Console.WriteLine("Name: " + shallowCopy1.Name + ", Address: " + shallowCopy1.EmpAddress.address + ", Dept: " + shallowCopy1.Department);
            //Console.Read();

            //Deep copy

            DeepCopy deepCopy = new DeepCopy();
            deepCopy.Name = "Solaiman";
            deepCopy.Department = "IT";
            deepCopy.EmpAddress = new DeepAddress() { address = "PBT" };

            DeepCopy deepCopy1 = deepCopy.GetClone();            
            deepCopy1.EmpAddress.address = "DIN";

            Console.WriteLine("Emplpyee 1: ");
            Console.WriteLine("Name: " + deepCopy.Name + ", Address: " + deepCopy.EmpAddress.address + ", Dept: " + deepCopy.Department);
            Console.WriteLine("Emplpyee 2: ");
            Console.WriteLine("Name: " + deepCopy1.Name + ", Address: " + deepCopy1.EmpAddress.address + ", Dept: " + deepCopy1.Department);
            Console.Read();
        }
    }
}
