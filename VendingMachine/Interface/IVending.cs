using System;
using System.Collections.Generic;
using System.Text;

namespace VendingMachine.Interface
{
    public interface IVending    {

        public string Purchase()        //to buy a product.
        {  
            return null;
        }

        public string ShowAll()         //show all products.
        {
            return null;
        }

        public int InsertMoney(int addMoney)     //add money to the pool.
        {
            int tempMoney = 0;
            return tempMoney;
        }

        public void EndTransaction(int returnMoney)    //returns money left in appropriate amount of change.
        {
            Console.WriteLine($"Returning: {returnMoney}");
        }
    }
}
