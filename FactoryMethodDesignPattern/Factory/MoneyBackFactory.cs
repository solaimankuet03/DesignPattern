using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FactoryMethodDesignPattern.Product;

namespace FactoryMethodDesignPattern.Factory
{
    public class MoneyBackFactory : CreditCardFactory
    {
        public override ICreditCard MakeProduct()
        {
            ICreditCard product = new MoneyBack();

            return product;
        }
    }
}
