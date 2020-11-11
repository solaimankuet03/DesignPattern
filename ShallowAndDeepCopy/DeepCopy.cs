using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShallowAndDeepCopy
{
    public class DeepCopy
    {
        public string Name { get; set; }
        public string Department { get; set; }
        public DeepAddress EmpAddress { get; set; }

        public DeepCopy GetClone()
        {
            DeepCopy deepcopy = this.MemberwiseClone() as DeepCopy;
            deepcopy.EmpAddress = EmpAddress.GetClone();
            return deepcopy;
        }
    }

    public class DeepAddress
    {
        public string address { get; set; }

        public DeepAddress GetClone()
        {
            return this.MemberwiseClone() as DeepAddress;
        }
    }
}
