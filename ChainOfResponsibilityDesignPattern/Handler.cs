using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChainOfResponsibilityDesignPattern
{
    public abstract class Handler
    {
        public Handler rsHandler;

        public void NextHandler(Handler rsHandler)
        {
            this.rsHandler = rsHandler;
        }

        public abstract void DispatchTaka(long requestedAmount);
    }
}
