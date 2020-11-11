using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChainOfResponsibilityDesignPattern
{
    public class ATM
    {
        TwoThousandHandler twoThousandHandler = new TwoThousandHandler();
        FiveHundredHandler fiveHundredHandler = new FiveHundredHandler();
        TwoHundredHandler twoHundredHandler = new TwoHundredHandler();
        HundredHandler hundredHandler = new HundredHandler();

        public ATM()
        {
            twoThousandHandler.NextHandler(fiveHundredHandler);
            fiveHundredHandler.NextHandler(twoHundredHandler);
            twoHundredHandler.NextHandler(hundredHandler);
        }

        public void Withdraw(long Amount)
        {
            twoThousandHandler.DispatchTaka(Amount);
        }
    }
}
