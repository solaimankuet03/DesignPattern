using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuilderDesignPatternRealExp
{
    public abstract class BeverageBuilder
    {
        public Beverage beverage = null;

        public void CreateBeverage()
        {
            beverage = new Beverage();
        }

        public abstract void SetBeverageType();
        public abstract void SetWater();
        public abstract void SetMilk();
        public abstract void SetSugar();
        public abstract void SetPowderQuantity();

        public Beverage GetBeverage()
        {
            return beverage;
        }
    }
}
