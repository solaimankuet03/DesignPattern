using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChainOfResponsibilityRealTimeDesignPattern
{
    public class HR : Employee
    {

        private int MAX_LEAVES_CAN_APPROVE = 30;
        public override void ApplyLeave(string employeeName, int numberofDaysLeave)
        {
            if (numberofDaysLeave <= MAX_LEAVES_CAN_APPROVE)
            {
                ApproveLeave(employeeName, numberofDaysLeave);
            }
            else
            {
                Console.WriteLine("Leave application suspended, Please contact HR");
            }
        }
        private void ApproveLeave(string employeeName, int numberofDaysLeave)
        {
            Console.WriteLine("HR approved " + numberofDaysLeave + " days " + "Leave for the employee : "
                            + employeeName);
        }


    }
}
