using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProxyDesignPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            SharedFolderProxy proxy = new SharedFolderProxy(new Employee("solaiman", "123456", "CEO"));
            proxy.PerformRWOperations();
            Console.ReadLine();
        }
    }
}
