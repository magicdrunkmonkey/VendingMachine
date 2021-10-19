using System;
using System.Collections.Generic;
using System.Text;

namespace VendingMachine.Products
{
    public interface ISoftDrinkProducts //Product type
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
        }
    }
}
