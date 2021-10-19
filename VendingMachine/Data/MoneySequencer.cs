using System;
using System.Collections.Generic;
using System.Text;
using VendingMachine.Interface;

namespace VendingMachine.Data
{
    public class MoneySequencer
    {
        //In PersonSequencer creates a private static int variable called personId.
        private static int moneyPool;

        //Add a static method called nextPersonId that increment and return the next 
        //personId value.
        public static int AddMoney()
        {
            return moneyPool;
        }

        //Add a static method called reset() that sets the variable to 0.
        public static int Reset()
        {
            return moneyPool = 0;
        }
    }
}
