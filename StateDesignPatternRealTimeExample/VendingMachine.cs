using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StateDesignPatternRealTimeExample
{
    public class VendingMachine : IVendingMachineState
    {
        public IVendingMachineState vendingMachineState { get; set; }

        public VendingMachine()
        {
            vendingMachineState = new NoMoneyState();
        }

        public void SelectProductAndInsertMoney(int amount, string productName)
        {
            vendingMachineState.SelectProductAndInsertMoney(amount, productName);

            if(vendingMachineState is NoMoneyState)
            {
                vendingMachineState = new HasMoneyState();

                Console.WriteLine("VendingMachine internal state has been moved to : "
                                + vendingMachineState.GetType().Name);
            }
        }

        public void DispenseProduct()
        {
            vendingMachineState.DispenseProduct();

            if(vendingMachineState is HasMoneyState)
            {
                vendingMachineState = new NoMoneyState();

                Console.WriteLine("VendingMachine internal state has been moved to : "
                                + vendingMachineState.GetType().Name);
            }
        }
    }
}
