//using BuilderDesignPatternRealExp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuilderDesignPatternRealExp
{
    class Program
    {
        static void Main(string[] args)
        {
            //Beverage beverage = null;
            //BeverageBuilder beverageBuilder = new TeaBuilder();
            //BeverageDirector beverageDirector = new BeverageDirector();

            //beverage = beverageDirector.CreateBeverage(beverageBuilder);
            //beverage.ShowBeverage();

            //Console.ReadLine();

            Beverage beverage;
            BeverageDirector beverageDirector = new BeverageDirector();

            TeaBuilder tea = new TeaBuilder();
            beverage = beverageDirector.MakeBeverage(tea);
            Console.WriteLine(beverage.ShowBeverage());
            CoffeeBuilder coffee = new CoffeeBuilder();
            beverage = beverageDirector.MakeBeverage(coffee);
            Console.WriteLine(beverage.ShowBeverage());
            Console.ReadKey();
        }
    }
}
