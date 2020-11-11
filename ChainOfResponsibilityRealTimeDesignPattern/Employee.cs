using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChainOfResponsibilityRealTimeDesignPattern
{
    public abstract class Employee
    {
        protected Employee Supervisor;

        public void SetNextSupervison(Employee Supervisor)
        {
            this.Supervisor = Supervisor;
        }

        public abstract void ApplyLeave(string employeeName, int numberofDaysLeave);
    }
}
