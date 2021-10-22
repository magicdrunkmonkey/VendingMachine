using System;
using System.Collections.Generic;
using System.Text;
using VendingMachine.Model;

namespace VendingMachine.Interface
{
    public interface IVending    
    {
        //Must have for assignment
        Product Purchase(int i);      //to buy a product.
        void ShowAll();       //show all products with price.        
        int InsertMoney(int i);      //add money to the pool.        
        Dictionary<int, int> EndTransaction();   //returns money left in appropriate amount of change.

       
    }
}
