using System;
using System.Collections.Generic;
using System.Text;
using VendingMachine.Model;

namespace VendingMachine.Products   //Product type
{
    public class CandyProducts : Product
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
        int sugar;
        string size;
        public string Type { get { return type; } set { type = value; } }
        public int Sugar { get { return sugar; } set { sugar = value; } }
        public string Size { get { return size; } set { size = value; } }

        //Constructor
        public CandyProducts(string name, int price, string type, string size, int sugar) : base(name, price)
        {            
            Type = type;
            Size = size;
            Sugar = sugar;
        }        

        //Metod (member) (Funktion)
        public new string Examine()
        {
            return base.Examine() + $"One {Name} candy costs {Price}kr.\n" +
                                    $"             Size: {size}\n" +
                                    $"    Sugar content: {Sugar}";
        }

        public new string Use()
        {
            //if (Type == "Candy") ;
            return base.Use() + $"Eating the {Name}.";
        }

        /* Attempt1 wrong solution
        //List of Candys
        public string[] CandyList()
        {
            // Create a list of products.
            List<string> candy = new List<string>();

            // Adding elements to List
            candy.Add("Coca Cola");
            candy.Add("Zingo");
            candy.Add("7up");

            //Convert list to array (assignment requirement)            
            string[] arrayProducts = candy.ToArray();
            

            return arrayProducts;
        }*/
    }
}
