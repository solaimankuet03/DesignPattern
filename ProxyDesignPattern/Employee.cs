using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProxyDesignPattern
{
    public class Employee
    {
        public string UserName { get; set; }
        public string Password { get; set; }
        public string Role { get; set; }

        public Employee(string UserName, string Password, string Role)
        {
            this.UserName = UserName;
            this.Password = Password;
            this.Role = Role;
        }
    }
}
