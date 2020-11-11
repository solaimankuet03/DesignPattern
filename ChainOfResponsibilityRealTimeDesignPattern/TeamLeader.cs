using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChainOfResponsibilityRealTimeDesignPattern
{
    public class TeamLeader : Employee
    {
        private int MAX_LEAVES_CAN_APPROVE = 10;

        public override void ApplyLeave(string employeeName, int numberofDaysLeave)
        {
            // check if TeamLeader can process this request
            if (numberofDaysLeave <= MAX_LEAVES_CAN_APPROVE)
            {
                ApproveLeave(employeeName, numberofDaysLeave);
            }
            // if TeamLeader can't process the LeaveRequest then pass on to the supervisor(ProjectLeader)
            // so that he can process
            else
            {
                Supervisor.ApplyLeave(employeeName, numberofDaysLeave);
            }
        }

        private void ApproveLeave(string employeeName, int numberofDaysLeave)
        {
            Console.WriteLine("TeamLeader approved " + numberofDaysLeave + " days " + "Leave for the employee : "
                            + employeeName);
        }
    }
}
