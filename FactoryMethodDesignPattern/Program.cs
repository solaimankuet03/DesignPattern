using FactoryMethodDesignPattern.Product;
using FactoryMethodDesignPattern.Factory;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethodDesignPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            ICreditCard Product = new Factory.MoneyBackFactory().MakeProduct();

            Console.WriteLine(Product.GetCardType());
            Console.WriteLine(Product.GetCreditLimit());
            Console.WriteLine(Product.GetAnnualCharge());

            ICreditCard TitaniumProduct = new Factory.TitaniumFactory().MakeProduct();

            Console.WriteLine(TitaniumProduct.GetCardType());
            Console.WriteLine(TitaniumProduct.GetCreditLimit());
            Console.WriteLine(TitaniumProduct.GetAnnualCharge());

            Console.ReadLine();
        }
    }
}
