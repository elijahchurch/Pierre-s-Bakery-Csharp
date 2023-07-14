using Items.Models;
using System;

namespace Bakery
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("*~*~*~*~*~*~*~*~*~*~*~*~*~*~*~*~*~*~*~*~*~*~*~*~");
            Console.WriteLine("Welcome to Pierre's Bakery!");
            DisplayCosts();
            Console.WriteLine("If you are ready to make an order, enter any key.");
            Console.ReadLine();
            Console.WriteLine("Great!");
            CalculateOrder();
        }

        static void DisplayCosts()
        {
            Console.WriteLine("");
            Console.WriteLine("Here are our prices:");
            Console.WriteLine("");
            Console.WriteLine("------------------------------------------------");
            Console.WriteLine($"A loaf of bread costs: ${Bread.BreadCost}");
            Console.WriteLine($"A single pastry costs: ${Pastry.PastryCost}");
            Console.WriteLine(" ");
            Console.WriteLine("DAILY DEAL: Buy 2 loaves of bread get 1 free!");
            Console.WriteLine("DAILY DEAL: Buy 3 pastries get 1 free!");
            Console.WriteLine("------------------------------------------------");
            Console.WriteLine("");
        }

        static void CalculateOrder()
        {
            Console.WriteLine("How many loaves of bread do you want to order?");
            string breadStringAmount = Console.ReadLine();
            Console.WriteLine("How many pastries do you want to order?");
            string pastryStringAmount = Console.ReadLine();
            try 
            {
                int breadAmount = int.Parse(breadStringAmount);
                int pastryAmount = int.Parse(pastryStringAmount);
            }
            catch
            {
                Console.WriteLine("");
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("ERROR: Please only enter in numbers!");
                Console.WriteLine("Special symbols and alphabetic characters will not be accepted.");
                Console.ResetColor();
                Console.WriteLine("Enter any key to try again.");
                Console.ReadLine();
                CalculateOrder();
            }
        }
    }
}