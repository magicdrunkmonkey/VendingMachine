using System;
using System.Collections.Generic;
using System.Text;
using Xunit;
using VendingMachine.Model;
using VendingMachine.Products;

namespace VendingMachine.Test
{
    public class SoftDrinksProductsTest
    {
        [Fact]
        public void SoftDrinksProducts_Constructor()
        {
            //Product is a parent-class tested through child-class:
            //  CandyProductTest.cs
            //  SoftDrinkProducts.cs
            //  ToyProducts.cs
            //
            // Child-class is tested through VendingMachine.cs            
        }
    }
}
