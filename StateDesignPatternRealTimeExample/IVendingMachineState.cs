using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StateDesignPatternRealTimeExample
{
    public interface IVendingMachineState
    {
        void SelectProductAndInsertMoney(int amount, string productName);
        void DispenseProduct();
    }
}
