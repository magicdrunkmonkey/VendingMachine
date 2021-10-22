using System;
using System.Collections.Generic;
using System.Text;
using Xunit;
using VendingMachine.Model;
using VendingMachine.Products;

namespace VendingMachine.Test
{
    public class ProductTest
    {
        [Fact]
        public void ProductConstructor()
        {
            //Product is a parent-class tested through child-class:
            //  CandyProductTest.cs
            //  SoftDrinkProducts.cs
            //  ToyProducts.cs

            /* Attempt 1             
            //Arrange
            VendingMachine.Model.VendingMachine vendingMachine = new Model.VendingMachine();
            string name = "Papaya";
            int price = 5;
            
            //Act
            Product product0 = new Product(name, price);

            //Assert
            Assert.Equal(product0.Name, name);
            Assert.Equal(product0.Price, price);   
            */
        }
    }
}
