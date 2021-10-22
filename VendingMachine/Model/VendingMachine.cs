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
        private readonly int[] moneyValue = { 1, 5, 10, 20, 50, 100, 500, 1000 };   //Currency values        
        public List<Product> listOfProducts = new List<Product>(); //Need access for purchase in program.cs
        //private Product[] purchaseList;

        public int moneyPool;       //Public for Xunit -> InsertMoney(), EndTransaction()
        public int indexMoney;      //Public for Xunit -> InsertMoney()
        public int indexPurchase;   //Public for Xunit -> Purchase()        
        private string bought;
        


        //Getters & Setters
        public int endTransaction { get; set; }     //Assignment requirement
        public int insertMoney { get; set; }        //Assignment requirement
        public string purchase { get; set; }        //Assignment requirement
        public string showAll { get; set; }         //Assignment requirement
        public List<Product> ListOfProducts { get => listOfProducts; set => listOfProducts = value; }

        //Encapsulasion (security)
        public void addProduct(Product productEncapsuled)
        {
            if (string.IsNullOrEmpty(productEncapsuled.Name))
            {
                throw new ArgumentException("Not a valid name.");
            }            
            ListOfProducts.Add(productEncapsuled);            
        }
        /*
        public void AddMoney(int iM)         //Do not understand why it have to be this way to work?
        {                                   //How to test this? --> External affecting fields changed to public, manipulate fields in Xunit.
            indexMoney = iM;
            moneyPool=InsertMoney();
        }*/
        /*
        public Product[] BridgeToVendingMachine(List<Product> listOfProducts)
        {
            purchaseList = listOfProducts.ToArray();   //Turn collection into one array.
            return purchaseList;
        }*/
        /*
        public void MakeAPurchase(int iP)
        {
            indexPurchase = iP;            
        }*/

        //Constructor
        public VendingMachine()             //Does not seem to be needed?
        {
            //moneyPool = InsertMoney();
        }

        //Metod (member) (Funktion)
        public Dictionary<int,int> EndTransaction()                  //Assignment requirement //Dictionary <int,int> 
        {
            IDictionary<int, int> mValues = new Dictionary<int, int>();                    // moneyValue = { 1, 5, 10, 20, 50, 100, 500, 1000 };
                        
            mValues.Add(1000, 0);
            mValues.Add(500, 0);
            mValues.Add(100, 0);
            mValues.Add(50, 0);
            mValues.Add(20, 0);
            mValues.Add(10, 0);
            mValues.Add(5, 0);
            mValues.Add(1, 0);

            Console.WriteLine($"Returning {moneyPool}kr\n");

            foreach(KeyValuePair<int,int> kvp in mValues)
            {
                //Console.WriteLine($"Returning {1} amount of {0}");
                //Console.WriteLine($"{kvp.Key} kr: " + (moneyPool - moneyPool % kvp.Key) / kvp.Key);

                //Example
                //(moneyPool - moneyPool % 1000) / 1000);   Counting amounts of 1000kr 
                //moneyPool = moneyPool % 1000;
                //(moneyPool - moneyPool % 500) / 500);
                //moneyPool = moneyPool % 500;

                mValues[kvp.Value]= (moneyPool - moneyPool % kvp.Key) / kvp.Key;
                moneyPool = moneyPool % kvp.Key;
            }

            //int returningMoney = moneyPool;             //Dictionary <1, "hur många?">
            //moneyPool = 0;
            return (Dictionary<int, int>)mValues;
            //throw new NotImplementedException();
        }

        public int InsertMoney(int iM)                    //Assignment requirement
        {
            indexMoney = iM;            
            return moneyPool += moneyValue[indexMoney];
            //throw new NotImplementedException();
        }

        public Product Purchase(int iP)                    //Assignment requirement
        {
            Product[] purchaseList = listOfProducts.ToArray();   //Turn collection into one array.
            //indexPurchase = iP;
            //purchaseList = ListOfProducts.ToArray();
            Product bought = purchaseList[iP];                  //Pick out the product to buy.
            return bought; 
            //throw new NotImplementedException();
        }

        public void ShowAll()                     //show all products with price. //Assignment requirement
        {
            int countProducts = 0;
            foreach (Product product in listOfProducts)
            {
                countProducts++;
                Console.Write(countProducts + ") ");
                if(product is ToyProducts)
                {
                    Console.WriteLine((product as ToyProducts).Examine());
                }
                else if(product is CandyProducts)
                {
                    Console.WriteLine((product as CandyProducts).Examine());
                }
                else if (product is SoftDrinkProducts)
                {
                    Console.WriteLine((product as SoftDrinkProducts).Examine());
                }
                else
                {
                    Console.WriteLine("There is no more products");
                }
            }

            //throw new NotImplementedException();
        }

        /* Example help
        Person person0 = new Person("Kalle", "+46123456", "Skövde, bogatan 5");

        Customer customer0 = new Customer("Gustav", "+4613579", "Bogata 10", "Hamngatan10");

        Employee employee0 = new Employee("per sonn",
            "+46123456",
            "Skövde, bogatan 5",
            10000,
            "IT");*/

        //Example
        //List<Person> listOfPersons = new List<Person>() { person0, customer0, employee0, admin0 };

    }
}
