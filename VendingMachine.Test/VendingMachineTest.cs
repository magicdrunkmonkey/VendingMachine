using System;
using Xunit;
using VendingMachine.Model;
using VendingMachine.Products;

namespace VendingMachine.Test
{
    public class VendingMachineTest
    {
        [Fact]
        public void InsertMoney_ToMoneyPool()
        {
            //Arrange
            VendingMachine.Model.VendingMachine vendingMachine = new Model.VendingMachine();
            //private readonly int[] moneyValue = { 1, 5, 10, 20, 50, 100, 500, 1000 };   //Currency values
            int index = 3;
            int expectedValue = 20;    
            int actualValue = 0;

            //Act
            actualValue = vendingMachine.addMoney(index);

            //Assert

        }
    }
}
