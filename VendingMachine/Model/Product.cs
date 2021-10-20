using System;
using System.Collections.Generic;
using System.Text;

namespace VendingMachine.Model
{
    public abstract class Product
    {
        //Propertys variabler
        int price;
        public string Name { get; set; }
        public int Price { get { return price; } set { price = value; } }
        public string Info { get; set; }

        //Constructor
        public Product(string name, int price)
        {
            Name = name;
            Price = price;            
        }

        //Metod (member) (Funktion)
        public string Examine()    //, to show the product’s price and info
        {    
            return Info;
        } 
        public string Use()     //, to put the product to use once it has been purchased(output a string message how to use the product)
        { 
            return null;
        } 
    }
}
