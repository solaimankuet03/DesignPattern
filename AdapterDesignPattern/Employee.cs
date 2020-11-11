using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdapterDesignPattern
{
    public class Employee
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public string Designation { get; set; }
        public decimal Salary { get; set; }

        public Employee(int _ID, string _Name, string _Designation, decimal _Salary)
        {
            ID = _ID;
            Name = _Name;
            Designation = _Designation;
            Salary = _Salary;
        }
    }
}
