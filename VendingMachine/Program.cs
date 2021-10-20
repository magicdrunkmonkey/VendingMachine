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
            CandyProducts candy0 = new CandyProducts();

            vendingMachine.listOfProducts.Add(candy0);





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
                            Console.WriteLine("1");
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
