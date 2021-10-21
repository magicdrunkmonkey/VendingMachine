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
        private List<Product> listOfProducts = new List<Product>();
        public int moneyPool;
        public int index;

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

        public void addMoney(int i)         //Do not understand why it have to be this way to work?
        {                                   //How to test this?
            index = i;
            moneyPool=InsertMoney();
        }

        //Constructor
        public VendingMachine()             //Does not seem to be needed?
        {
            //moneyPool = InsertMoney();
        }

        //Metod (member) (Funktion)
        public int EndTransaction()                  //Assignment requirement
        {
            int returningMoney = moneyPool;
            moneyPool = 0;
            return returningMoney;
            //throw new NotImplementedException();
        }

        public int InsertMoney()                    //Assignment requirement
        {
            return moneyPool += moneyValue[index];
            //throw new NotImplementedException();
        }

        public string Purchase()                    //Assignment requirement
        {
            throw new NotImplementedException();
        }

        public string ShowAll()                     //Assignment requirement
        {
            throw new NotImplementedException();
        }            

        public int MoneyPool()                      //Added for later
        {
            //return base.MoneyPool() ;
            throw new NotImplementedException();
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
