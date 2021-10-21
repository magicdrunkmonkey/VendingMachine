using System;
using System.Collections.Generic;
using System.Text;
using VendingMachine.Model;

namespace VendingMachine.Interface
{
    public interface IVending    
    {
        //Must have for assignment
        Product Purchase();      //to buy a product.
        string ShowAll();       //show all products with price.        
        int InsertMoney();      //add money to the pool.        
        int EndTransaction();   //returns money left in appropriate amount of change.

        //Adding
        //int MoneyPool();
    }
}
