using System;
using Xunit;
using VendingMachine.Model;
using VendingMachine.Products;
using System.Collections.Generic;

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
            vendingMachine.InsertMoney(index20);   //Add moneyvalue to moneyPool
            actualValue20 = vendingMachine.moneyPool;
            //Assert 1
            Assert.Equal(expectedValue20, actualValue20); //Verify moneyPool=20

            //Act 2
            vendingMachine.indexMoney = index50;     //Index moneyValue to 50
            vendingMachine.InsertMoney(index50);   //Add moneyvalue to moneyPool
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

            //IDictionary<int, int> mValues = new Dictionary<int, int>();
            IDictionary<int, int> expectedValues = new Dictionary<int, int>();
            expectedValues.Add(1000, 1);
            expectedValues.Add(500, 0);
            expectedValues.Add(100, 1);
            expectedValues.Add(50, 0);
            expectedValues.Add(20, 1);
            expectedValues.Add(10, 0);
            expectedValues.Add(5, 1);
            expectedValues.Add(1, 0);

            IDictionary<int, int> actualValues = new Dictionary<int, int>();

            vendingMachine.moneyPool = 1125;

            //Act
            actualValues = vendingMachine.EndTransaction();

            //Assert
            Assert.Equal(expectedValues, actualValues);

            //Cleanup
            vendingMachine.moneyPool = 0;       //Reset moneyPool
        }

        [Fact]
        public void Purchase_BuyAProduct()
        {
            //Arrange
            VendingMachine.Model.VendingMachine vendingMachine = new Model.VendingMachine();
            vendingMachine.moneyPool = 100;
            int indexProductList = 2;               
            string expectedValue = "Bounty";
            string actualValue = null;

            //Populate produktlist
            CandyProducts candy0 = new CandyProducts("Snickers", 10, "Candy", "Small", 3);
            CandyProducts candy1 = new CandyProducts("Cloetta", 12, "Candy", "Medium", 4);
            CandyProducts candy2 = new CandyProducts("Bounty", 9, "Candy", "Big", 8);     
            vendingMachine.addProduct(candy0);          //Index 0
            vendingMachine.addProduct(candy1);          //Index 1
            vendingMachine.addProduct(candy2);          //Index 2

            //vendingMachine.BridgeToVendingMachine(vendingMachine.ListOfProducts); //Create a list of 3 products

            //Act
            //vendingMachine.Purchase(indexProductList);     //Set index for the product purchase at index=2
            Product bought = vendingMachine.Purchase(indexProductList);         //Buy from indexProductList at index=2
            actualValue = bought.Name;

            //Assert
            Assert.Equal(expectedValue, actualValue);

            //Cleanup
            vendingMachine.moneyPool = 0;       //Reset moneyPool
        }

        [Fact]
        public void ExamineTest()
        {
            //Arrange
            VendingMachine.Model.VendingMachine vendingMachine = new Model.VendingMachine();

            //List of candy name, price, type
            CandyProducts candy0 = new CandyProducts("Snickers", 10, "Candy",  "Small", 12);
            CandyProducts candy1 = new CandyProducts("Cloetta", 12, "Candy", "Medium", 6);
            CandyProducts candy2 = new CandyProducts("Bounty", 9, "Candy", "Big", 8);

            //List of softdrinks name, price, type
            SoftDrinkProducts softdrink0 = new SoftDrinkProducts("Pepsi", 8, "Softdrink", "Can", "Sweet");
            SoftDrinkProducts softdrink1 = new SoftDrinkProducts("Fanta", 11, "Softdrink", "Bottle", "Sour");
            SoftDrinkProducts softdrink2 = new SoftDrinkProducts("7up", 13, "Softdrink", "Carton", "Fresh");

            //List of toys name, price, type
            ToyProducts toy0 = new ToyProducts("plane", 8, "Toy", "White", "No");
            ToyProducts toy1 = new ToyProducts("car", 11, "Toy", "Red", "Yes");
            ToyProducts toy2 = new ToyProducts("boat", 13, "Toy","Blue", "No");

            //Listed products
            vendingMachine.addProduct(candy0);
            vendingMachine.addProduct(candy1);
            vendingMachine.addProduct(candy2);
            vendingMachine.addProduct(softdrink0);
            vendingMachine.addProduct(softdrink1);
            vendingMachine.addProduct(softdrink2);
            vendingMachine.addProduct(toy0);
            vendingMachine.addProduct(toy1);
            vendingMachine.addProduct(toy2);            

            //Create a list of 9 products
            //Product[] allListed = vendingMachine.BridgeToVendingMachine(vendingMachine.ListOfProducts);

            //Act
            string actualResult_C0 = candy0.Examine();
            string expecteResult_C0 = "One Snickers candy costs 10kr.\n             Size: Small\n    Sugar content: 12";

            string actualResult_SD2 = softdrink2.Examine();
            string expecteResult_SD2 = "One 7up softdrink costs 13kr.\n    Tastes like Fresh";

            string actualResult_T1 = toy1.Examine();
            string expecteResult_T1 = "One Red toycar costs 11kr.\n    Needs batter: Yes";

            //Assert 
            Assert.Equal(expecteResult_C0, actualResult_C0);
            Assert.Equal(expecteResult_SD2, actualResult_SD2);
            Assert.Equal(expecteResult_T1, actualResult_T1);
        }

        [Fact]
        public void UseTest()
        {
            //Arrange
            VendingMachine.Model.VendingMachine vendingMachine = new Model.VendingMachine();

            //List of candy name, price, type
            CandyProducts candy0 = new CandyProducts("Snickers", 10, "Candy",  "Small", 6);
            CandyProducts candy1 = new CandyProducts("Cloetta", 12, "Candy", "Medium", 15);
            CandyProducts candy2 = new CandyProducts("Bounty", 9, "Candy", "Big", 12);

            //List of softdrinks name, price, type
            SoftDrinkProducts softdrink0 = new SoftDrinkProducts("Pepsi", 8, "Softdrink", "Can", "Sweet");
            SoftDrinkProducts softdrink1 = new SoftDrinkProducts("Fanta", 11, "Softdrink", "Bottle", "Sour");
            SoftDrinkProducts softdrink2 = new SoftDrinkProducts("7up", 13, "Softdrink", "Carton", "Fresh");

            //List of toys name, price, type
            ToyProducts toy0 = new ToyProducts("plane", 8, "Toy", "White", "No");
            ToyProducts toy1 = new ToyProducts("car", 11, "Toy", "Red", "Yes");
            ToyProducts toy2 = new ToyProducts("boat", 13, "Toy", "Blue", "No");

            //Listed products
            vendingMachine.addProduct(candy0);
            vendingMachine.addProduct(candy1);
            vendingMachine.addProduct(candy2);
            vendingMachine.addProduct(softdrink0);
            vendingMachine.addProduct(softdrink1);
            vendingMachine.addProduct(softdrink2);
            vendingMachine.addProduct(toy0);
            vendingMachine.addProduct(toy1);
            vendingMachine.addProduct(toy2);

            //Create a list of 9 products
            //Product[] allListed = vendingMachine.BridgeToVendingMachine(vendingMachine.ListOfProducts);

            //Act
            string actualResult_C2 = candy2.Use();
            string expecteResult_C2 = "Eating the Bounty.";

            string actualResult_SD1 = softdrink1.Use();
            string expecteResult_SD1 = "Drinking the Fanta it tastes like Sour.";

            string actualResult_T0 = toy0.Use();
            string expecteResult_T0 = "Playing with the White toyplane.";

            //Assert 
            Assert.Equal(expecteResult_C2, actualResult_C2);
            Assert.Equal(expecteResult_SD1, actualResult_SD1);
            Assert.Equal(expecteResult_T0, actualResult_T0);

        }
    }
}
