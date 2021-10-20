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
        public List<Product> listOfProducts = new List<Product>();

        //Getters & Setters
        public int moneyPool { get; set; }          //Added
        public int endTransaction { get; set; }     //Assignment requirement
        public int insertMoney { get; set; }        //Assignment requirement
        public string purchase { get; set; }        //Assignment requirement
        public string showAll { get; set; }         //Assignment requirement


        //Constructor
        public VendingMachine()
        {
            MoneyPool = moneyPool;

        }

        //Metod (member) (Funktion)
        public int EndTransaction()                  //Assignment requirement
        {
            throw new NotImplementedException();
        }

        public int InsertMoney()                    //Assignment requirement
        {
            throw new NotImplementedException();
        }

        public string Purchase()                    //Assignment requirement
        {
            throw new NotImplementedException();
        }

        public string ShowAll()                     //Assignment requirement
        {
            throw new NotImplementedException();
        }            

        public int MoneyPool()                      //Assignment requirement
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
