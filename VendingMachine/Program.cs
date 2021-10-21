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

            //List of candy name, price, type
            CandyProducts candy0 = new CandyProducts("Snickers", 10, "Candy");
            CandyProducts candy1 = new CandyProducts("Cloetta", 12, "Candy");
            CandyProducts candy2 = new CandyProducts("Bounty", 9, "Candy");

            //List of softdrinks name, price, type
            SoftDrinkProducts softdrink0 = new SoftDrinkProducts("Pepsi", 8, "Softdrink");
            SoftDrinkProducts softdrink1 = new SoftDrinkProducts("Fanta", 11,"Softdrink");
            SoftDrinkProducts softdrink2 = new SoftDrinkProducts("7up", 13, "Softdrink");

            //List of toys name, price, type
            ToyProducts toy0 = new ToyProducts("plane", 8, "Toy");
            ToyProducts toy1 = new ToyProducts("car", 11, "Toy");
            ToyProducts toy2 = new ToyProducts("boat", 13, "Toy");

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

            vendingMachine.BridgeToVendingMachine(vendingMachine.ListOfProducts);

            bool keepLooping = true;
            while (keepLooping)
            {
                try
                {
                    Console.WriteLine("Vending Machine\n" +
                                      "---------------\n" +
                                      "1) Show all products\n" +
                                      "2) Insert money\n" +
                                      "3) Purches a product\n" +
                                      "4) Return change\n");

                    Console.Write("Enter choice: ");
                    var choice = int.Parse(Console.ReadLine() ?? "");
                    Console.ForegroundColor = ConsoleColor.Green;
                    switch (choice)
                    {
                        case 1:
                            vendingMachine.ShowAll();
                            break;
                        case 2:

                            break;
                        case 3:
                            break;
                        case 4:
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
                    Console.WriteLine("Hit any key to continue!");
                    Console.ReadKey();
                    Console.Clear();
                }
                catch
                {
                    Console.Clear();
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("That is not a valid Choice!");
                    Console.ResetColor();
                }
            }
        }
    }
}
