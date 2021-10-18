using System;
using System.Collections.Generic;
using System.Text;

namespace VendingMachine.Model
{
    public class MoneyPool
    {
        //Fields, declare, initialize
        private readonly int[] moneyValue = { 1, 5, 10, 20, 50, 100, 1000 };    //Currency values
        private int moneyAmount;

        //Constructor
        public MoneyPool(int moneyAmount)
        {
            this.moneyAmount = moneyAmount;
        }

        //Getters & Setter
        public int AddMoney
        {
            get { return moneyAmount; }
            set { moneyAmount = value; }
        }
    }
}
