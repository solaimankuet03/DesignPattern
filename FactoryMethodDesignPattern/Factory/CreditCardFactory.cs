using FactoryMethodDesignPattern.Product;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethodDesignPattern.Factory
{
    public abstract class CreditCardFactory
    {
        public abstract ICreditCard MakeProduct();

        //public ICreditCard CreateProduct()
        //{
        //    return this.MakeProduct();
        //}
    }
}
