using System;
using Xunit;
using VendingMachine.Model;
using VendingMachine.Products;

namespace VendingMachine.Test
{
    public class VendingMachineTest
    {
        [Fact]
        public void InsertMoney_ToMoneypool()
        {
            //Arrange
            VendingMachine.Model.VendingMachine vendingMachine = new Model.VendingMachine();
            //private readonly int[] moneyValue = { 1, 5, 10, 20, 50, 100, 500, 1000 };   //Currency values
            int index20 = 3;                //Point to value 20
            int expectedValue20 = 20;       //Add value 20 to moneyPool=0;
            int index50 = 5;                //Point to value 100 
            int expectedValue120 = 120;     //Add value 100 to moneyPool=20;

            //Verify value is zero
            int actualValue20 = vendingMachine.moneyPool;
            int actualValue120 = vendingMachine.moneyPool;
            Assert.Equal(0, actualValue120);

            //Act 1
            vendingMachine.indexMoney = index20;     //Index moneyValue to 20
            vendingMachine.AddMoney(index20);   //Add moneyvalue to moneyPool
            actualValue20 = vendingMachine.moneyPool;
            //Assert 1
            Assert.Equal(expectedValue20, actualValue20); //Verify moneyPool=20

            //Act 2
            vendingMachine.indexMoney = index50;     //Index moneyValue to 50
            vendingMachine.AddMoney(index50);   //Add moneyvalue to moneyPool
            actualValue120 = vendingMachine.moneyPool;
            //Assert 2
            Assert.Equal(expectedValue120, actualValue120);  //Verify moneyPool=120

            //Cleanup
            vendingMachine.moneyPool = 0;       //Reset moneyPool
        }
        [Fact]
        public void EndTransaction_ReturnRemainingMoneyFromMoneypool()
        {
            //Arrange
            VendingMachine.Model.VendingMachine vendingMachine = new Model.VendingMachine();
            int expectedValue = 132;
            int actualValue = 0;
            vendingMachine.moneyPool = expectedValue;

            //Act
            actualValue = vendingMachine.EndTransaction();

            //Assert
            Assert.Equal(expectedValue, actualValue);

            //Cleanup
            vendingMachine.moneyPool = 0;       //Reset moneyPool
        }

        [Fact]
        public void Purchase_BuyAProduct()
        {
            //Arrange
            VendingMachine.Model.VendingMachine vendingMachine = new Model.VendingMachine();
            vendingMachine.moneyPool = 100;
            int indexProductList = 3;               
            string expectedValue = "Bounty";
            string actualValue = null;

            //Act
            vendingMachine.MakeAPurchase(indexProductList);   //Set index for the product purchase "Bounty"
            Product bought = vendingMachine.Purchase();
            actualValue = bought.Name;

            //Assert
            Assert.Equal(expectedValue, actualValue);
        }
    }
}
