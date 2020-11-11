using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FactoryMethodDesignPattern.Product;

namespace FactoryMethodDesignPattern.Factory
{
    public class TitaniumFactory : CreditCardFactory
    {
        public override ICreditCard MakeProduct()
        {
            ICreditCard product = new Titanium();

            return product;
        }
    }
}
