using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryPattern
{
    public class Platinum : ICreditCard
    {
        public int GetAnnualCharge()
        {
            return 3000;
        }

        public string GetCardType()
        {
            return "Platinum";
        }

        public int GetCreditLimit()
        {
            return 200000;
        }
    }
}
