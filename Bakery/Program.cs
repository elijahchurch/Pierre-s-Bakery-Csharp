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
            Console.WriteLine("If you are ready to make an order, enter any key.");
            Console.ReadLine();
            Console.WriteLine("Great!");

        }
    }
}