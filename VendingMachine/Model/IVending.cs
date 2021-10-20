using System;
using System.Collections.Generic;
using System.Text;

namespace VendingMachine.Interface
{
    public interface IVending    
    {
        string Purchase();      //to buy a product.
        string ShowAll();       //show all products.        
        int InsertMoney();      //add money to the pool.        
        void EndTransaction();  //returns money left in appropriate amount of change.        
    }
}
