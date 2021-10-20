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
        public int MoneyPool { get; set; }          //Added
        public int EndTransaction { get; set; }     //Assignment
        public int InsertMoney { get; set; }        //Assignment
        public string Purchase { get; set; }        //Assignment
        public string ShowAll { get; set; }         //Assignment


        //Constructor
        public VendingMachine(int moneyPool, int endTransaction, int insertMoney, string purchase, string showAll)
        {
            MoneyPool = moneyPool;

        }

        //Metod (member) (Funktion)
        public int EndTransaction()
        {
            throw new NotImplementedException();
        }

        public int InsertMoney()
        {
            throw new NotImplementedException();
        }

        public string Purchase()
        {
            throw new NotImplementedException();
        }

        public string ShowAll()
        {
            throw new NotImplementedException();
        }            

        public int MoneyPool()
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
