﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StateDesignPattern
{
    //context class
    public class ATMMachine : ATMState
    {
        public ATMState atmMachineState { get; set; }

        public ATMMachine()
        {
            atmMachineState = new DebitCardNotInsertedState();
        }

        public void EjectDebitCard()
        {
            atmMachineState.EjectDebitCard();
            // Debit Card has been ejected so internal state of ATM Machine
            // has been changed to 'DebitCardNotInsertedState'

            if (atmMachineState is DebitCardInsertedState)
            {
                atmMachineState = new DebitCardNotInsertedState();
                Console.WriteLine("ATM Machine internal state has been moved to : "
                                + atmMachineState.GetType().Name);
            }
        }

        public void EnterPIN()
        {
            atmMachineState.EnterPIN();
        }

        public void InsertDebitCard()
        {
            atmMachineState.InsertDebitCard();

            if (atmMachineState is DebitCardNotInsertedState)
            {
                atmMachineState = new DebitCardInsertedState();
                Console.WriteLine("ATM Machine internal state has been moved to : "
                                + atmMachineState.GetType().Name);
            }
        }

        public void WithdrawMoney()
        {
            atmMachineState.WithdrawMoney();
        }
    }
}
