using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryPattern
{
    public class CreditCardFactory
    {
        public static ICreditCard GetCreditCard(string CardType)
        {
            ICreditCard CreditCard = null;

            if (CardType == "MoneyBack")
                CreditCard = new MoneyBack();

            else if (CardType == "Platinum")
                CreditCard = new Platinum();

            else if (CardType == "Titanium")
                CreditCard = new Titanium();

            return CreditCard;
        }
    }
}
