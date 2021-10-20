using System;
using System.Collections.Generic;
using System.Text;

namespace VendingMachine.Model
{
    public class Product
    {
        //Propertys variabler
        public string Name { get; set; }
        public string Price { get; set; }
        public string Info { get; set; }
        
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
