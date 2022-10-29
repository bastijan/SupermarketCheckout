using System;
using SupermarketCheckout.Logic;

namespace SupermarketCheckout
{
    internal static class Program
    {
        /*
         * Main method
         * Retrieve products from SeedProducts and show menu
         */
        private static void Main()
        {
            bool showMenu = true;
            while (showMenu)
            {
                showMenu = MainMenu();
            }
        }

        /*
         * Main menu
         * Show menu and get user input
         */
        private static bool MainMenu()
        {
            Console.Clear();
            Console.WriteLine("Scan a product:");
            Console.WriteLine("1) Apple");
            Console.WriteLine("2) Banana");
            Console.WriteLine("3) Peach");
            Console.WriteLine("\u001b[32mC) Go to checkout\u001b[0m");
            Console.WriteLine("\u001b[33mX) Break and exit\u001b[0m");
            Console.Write("\r\nSelect an option: ");

            var userInput = Console.ReadLine().ToUpper();


            switch (userInput)
            {
                case "C":
                    ShoppingCart.GetTotal();
                    break;
                case "X":
                    return false;
                default:
                    ShoppingCart.Scan(userInput);
                    break;
            }

            return true;
        }
    }
}
