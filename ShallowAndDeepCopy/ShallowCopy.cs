using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShallowAndDeepCopy
{
    public class ShallowCopy
    {
        public string Name { get; set; }
        public string Department { get; set; }
        public Address EmpAddress { get; set; }

        public ShallowCopy GetClone()
        {
            return this.MemberwiseClone() as ShallowCopy;
        }
    }

    public class Address
    {
        public string address { get; set; }
    }
}
