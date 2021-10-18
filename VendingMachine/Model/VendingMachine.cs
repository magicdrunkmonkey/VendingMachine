using System;
using System.Collections.Generic;
using System.Text;
using VendingMachine.Data;
using VendingMachine.Interface;
using VendingMachine.Model;
using VendingMachine.Products;

namespace VendingMachine.Model
{
    public class VendingMachine : IVending
    {
        //Fields, declare, initialize
        private readonly int[] moneyValue = { 1, 5, 10, 20, 50, 100, 1000 };    //Currency values

    }
}
