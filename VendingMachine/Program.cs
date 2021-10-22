using System;
using VendingMachine.Model;
using VendingMachine.Products;

namespace VendingMachine
{
    class Program
    {
        static void Main(string[] args)
        {

            VendingMachine.Model.VendingMachine vendingMachine = new VendingMachine.Model.VendingMachine();

            //List of candy name, price, type, sugar
            CandyProducts candy0 = new CandyProducts("Snickers", 10, "Candy", "3g");
            CandyProducts candy1 = new CandyProducts("Cloetta", 12, "Candy", "4g");
            CandyProducts candy2 = new CandyProducts("Bounty", 9, "Candy", "7g");

            //List of softdrinks name, price, type
            SoftDrinkProducts softdrink0 = new SoftDrinkProducts("Pepsi", 8, "Softdrink", "syrup");
            SoftDrinkProducts softdrink1 = new SoftDrinkProducts("Fanta", 11,"Softdrink", "fruity");
            SoftDrinkProducts softdrink2 = new SoftDrinkProducts("7up", 13, "Softdrink", "fresh");

            //List of toys name, price, type
            ToyProducts toy0 = new ToyProducts("plane", 8, "Toy", "blue");
            ToyProducts toy1 = new ToyProducts("car", 11, "Toy", "red");
            ToyProducts toy2 = new ToyProducts("boat", 13, "Toy", "green");

            //Listed products
            vendingMachine.addProduct(candy0);
            vendingMachine.addProduct(candy1);
            vendingMachine.addProduct(candy2);
            vendingMachine.addProduct(softdrink0);
            vendingMachine.addProduct(softdrink1);
            vendingMachine.addProduct(softdrink2);
            vendingMachine.addProduct(toy0);
            vendingMachine.addProduct(toy1);
            vendingMachine.addProduct(toy2);

            //vendingMachine.BridgeToVendingMachine(vendingMachine.ListOfProducts);

            bool keepLooping = true;
            while (keepLooping)
            {
                Console.WriteLine("Vending Machine\n" +
                                  "---------------\n" +
                                  "1) Show all products\n" +
                                  "2) Insert money\n" +
                                  "3) Purches a product\n" +
                                  "4) Return change\n");
                Console.WriteLine("Moneypool: " + vendingMachine.moneyPool);

                Console.Write("Enter choice: ");
                int choice = 0;
                try
                {
                    choice = int.Parse(Console.ReadLine() ?? "");
                    Console.ForegroundColor = ConsoleColor.Green;
                }
                catch
                {
                    Console.Clear();
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("That is not a valid Choice!");
                    Console.ResetColor();
                }
                switch (choice)
                {
                    case 1:
                        Console.Clear();
                        Console.WriteLine("Products & Price\n" +
                                          "-------------------------------");
                        vendingMachine.ShowAll();
                        Console.WriteLine();
                        break;
                    case 2:
                        Console.Clear();
                        Console.WriteLine("Insert Money\n" +
                                          "-------------------------------\n" +
                                          "1) 1kr\n" +
                                          "2) 5kr\n" +
                                          "3) 10kr\n" +
                                          "4) 20kr\n" +
                                          "5) 50kr\n" +
                                          "6) 100kr\n" +
                                          "7) 500kr\n" +
                                          "8) 1000kr\n");
                        Console.WriteLine("Moneypool: " + vendingMachine.moneyPool);
                        Console.Write("Enter choice: ");
                        int moneyChoice = 0;
                        int decision = 0;
                        try
                        {
                            moneyChoice = int.Parse(Console.ReadLine() ?? "");
                        }
                        catch
                        {
                            Console.WriteLine("Not valid number");
                        }

                        if (moneyChoice <= 8 && moneyChoice != 0)
                        {
                            Console.Clear();
                            decision = --moneyChoice;
                            vendingMachine.InsertMoney(decision);
                        }
                        else
                        {
                            Console.Clear();
                            Console.WriteLine("Not a valit option!");
                        }

                        
                        Console.WriteLine();
                        //Console.Clear();
                        break;
                    case 3:
                        Console.Clear();
                        Console.WriteLine("Products & Price\n" +
                                          "-------------------------------");
                        vendingMachine.ShowAll();
                        Console.WriteLine();
                        Console.WriteLine("Moneypool: " + vendingMachine.moneyPool);
                        Console.Write("Choce your option: ");
                        int productChoice=0;
                        int productDecision=0;
                        try
                        {
                            productChoice = int.Parse(Console.ReadLine() ?? "");
                        }
                        catch
                        {
                            Console.WriteLine("Not valid number");
                        }

                        if (productChoice <= 9 && productChoice != 0)
                        {
                            Console.Clear();
                            productDecision = --productChoice;
                            vendingMachine.Purchase(productDecision);      //Set index for the product purchase
                            //Console.WriteLine("Hit any key to continue!");
                            //Console.ReadKey();
                        }
                        else
                        {
                            Console.Clear();
                            Console.WriteLine("Not a valit option!");
                        }

                        //Attempt 3                        
                        Product bought = vendingMachine.Purchase(productDecision);         //Buy from the List at index
                        if (bought is ToyProducts)
                        {
                            Console.WriteLine((bought as ToyProducts).Use());   //Use bought product
                            vendingMachine.moneyPool -= bought.Price;
                        }
                        else if (bought is CandyProducts)
                        {
                            Console.WriteLine((bought as CandyProducts).Use());
                            vendingMachine.moneyPool -= bought.Price;
                        }
                        else if (bought is SoftDrinkProducts)
                        {
                            Console.WriteLine((bought as SoftDrinkProducts).Use());
                            vendingMachine.moneyPool -= bought.Price;
                        }
                        else
                        {
                            Console.WriteLine("There is no more products");
                        }                                           


                        /*//Attempt 2
                        foreach (Product product in listOfProducts)
                        {                            
                            if ((vendingMachine.ListOfProducts.)
                            {
                                Console.WriteLine((product as ToyProducts).Examine());
                            }
                            else if (product is CandyProducts)
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
                        }*/

                        /*//Attempt 1
                        if (vendingMachine. )
                        {
                            Console.WriteLine((product as ToyProducts).Examine());
                        }
                        else if (product is CandyProducts)
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
                        }*/


                        break;
                    case 4:
                        Console.Clear();
                        Console.WriteLine("Returning: " + vendingMachine.EndTransaction());
                        break;
                    case 0:
                        keepLooping = false;
                        break;
                    default:
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("That is not a valid choice!");
                        break;
                }
                
                Console.ResetColor();
                    //Console.WriteLine("Hit any key to continue!");
                    //Console.ReadKey();
                    //Console.Clear();
                               
            }
        }
    }
}
