﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrototypeDesignPattern
{
    public class Employee
    {
        public string Name { get; set; }
        public string Department { get; set; }

        public Employee GetClone()
        {
            return this.MemberwiseClone() as Employee;
        }
    }
}
