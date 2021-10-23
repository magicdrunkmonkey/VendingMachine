using System;
using System.Collections.Generic;
using System.Text;
using VendingMachine.Model;

namespace VendingMachine.Products
{
    public class SoftDrinkProducts : Product
    {
        /*
         * Each product type should be its own class.
         * 
         * o These classes should all inherit from the same abstract class, to get the methods
         *   they have in common. This base class is the type the vending machine itself
         *   should look for.
         * 
         * o The common methods should include at least:
         *   ▪ Examine, to show the product’s price and info
         *   ▪ Use, to put the product to use once it has been purchased 
         *     (output a string message how to use the product)
        */

        //Propertys variabler
        string type;
        string beverageContainer;
        string taste;
        public string Type { get { return type; } set { type = value; } }
        public string BeverageContainer { get { return beverageContainer; } set { beverageContainer = value; } }
        public string Taste { get { return taste; } set { taste = value; } }

        //Constructor
        public SoftDrinkProducts(string name, int price, string type, string beverageContainer, string taste) : base(name, price)
        {            
            Type = type;
            BeverageContainer = beverageContainer;
            Taste = taste;
        }

        //Metod (member) (Funktion)
        public new string Examine()
        {
            return base.Examine() + $"One {Name} softdrink costs {Price}kr.\n" +
                                    $"    Tastes like {Taste}";
        }

        public new string Use()
        {
            return base.Use() + $"Drinking the {Name} it tastes like {Taste}.";
        }

        /* Attempt1 wrong solution
        public string[] Softdrinks()
        {
            // Create a list of products.
            List<string> softdrink = new List<string>();

            // Adding elements to List
            softdrink.Add("Snickers");
            softdrink.Add("Cloetta kex");
            softdrink.Add("Bounty");

            //Convert list to array (assignment requirement)            
            string[] arrayProducts = softdrink.ToArray();

            return arrayProducts;
        }*/
    }
}
