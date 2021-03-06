using System;
using System.Collections.Generic;
using System.Text;
using VendingMachine.Model;

namespace VendingMachine.Products
{
    public class ToyProducts : Product 
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
        string color;
        string batteryNeed;
        public string Type { get { return type; } set{ type = value; } }
        public string Color { get { return color; } set { color = value; } }
        public string BatteryNeed { get { return batteryNeed; } set { batteryNeed = value; } }

        //Constructor
        public ToyProducts(string name, int price, string type, string color, string batteryNeed) : base(name, price)
        {            
            Type = type;
            Color = color;
            BatteryNeed = batteryNeed;
        }

        //Metod (member) (Funktion)
        public new string Examine()
        {
            //return base.Info() + $"One toy{Name} costs {Price}kr.";
            return base.Examine() + $"One {Color} toy{Name} costs {Price}kr.\n" +
                                    $"    Needs batter: {BatteryNeed}";
        }

        public new string Use()
        {
            return base.Use() + $"Playing with the {Color} toy{Name}.";
        }

        /* Attempt1 wrong solution
        public string[] Toys()
        {
            // Create a list of products.
            List<string> toy = new List<string>();

            // Adding elements to List
            toy.Add("Toy car");
            toy.Add("Toy boat");
            toy.Add("Toy plane");

            //Convert list to array (assignment requirement)            
            string[] arrayProducts = toy.ToArray();

            return arrayProducts;
        }*/
    }
}
