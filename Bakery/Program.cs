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
            Console.WriteLine("Great! Let's get started.");
            CalculateInitialOrder();
            DisplayOrder();
            Console.WriteLine("Thank you for ordering from Pierre's Bakery!");
            Console.WriteLine("Have a good day!!!");
        }

        static void DisplayCosts()
        {
            Console.WriteLine("");
            Console.WriteLine("Here are our prices:");
            Console.WriteLine("");
            Console.WriteLine("------------------------------------------------");
            Console.WriteLine($"A loaf of bread costs: ${Bread.BreadCost}.");
            Console.WriteLine($"A single pastry costs: ${Pastry.PastryCost}.");
            Console.WriteLine(" ");
            Console.WriteLine("DAILY DEAL: Buy 2 loaves of bread get 1 free!");
            Console.WriteLine("DAILY DEAL: Buy 3 pastries get 1 free!");
            Console.WriteLine("------------------------------------------------");
            Console.WriteLine("");
        }

        static void CalculateInitialOrder()
        {
            Console.WriteLine("How many loaves of bread do you want to order?");
            string breadStringAmount = Console.ReadLine();
            Console.WriteLine("How many pastries do you want to order?");
            string pastryStringAmount = Console.ReadLine();
            try 
            {
                int breadAmount = int.Parse(breadStringAmount);
                int pastryAmount = int.Parse(pastryStringAmount);
                if (breadAmount > 0 && pastryAmount > 0)
                {
                    Bread.CalculateBreadOrder(breadAmount);
                    Pastry.CalculatePastryOrder(pastryAmount);
                    Console.WriteLine("");
                    Console.WriteLine("Here is your current order:");
                    DisplayOrder();
                    CheckIfOrderIsComplete();
                }
                else
                {
                    NegativeNumberError();
                    CalculateInitialOrder();
                }
            }
            catch
            {
                ErrorMessage();
                CalculateInitialOrder();
            }
        }

        static void DisplayOrder()
        {
            Console.WriteLine("");
            Console.WriteLine("------------------------------------------------");
            Console.WriteLine($"Number of loaves of bread ordered: {Bread.AmountOfLoaves}.");
            Console.WriteLine($"Number of pastries ordered: {Pastry.AmountOfPastries}.");
            int totalCost = Bread.TotalBreadCost + Pastry.TotalPastryCost;
            Console.WriteLine($"The cost of your order: ${totalCost}.");
            Console.WriteLine("------------------------------------------------");
            Console.WriteLine("");
        }

        static void ErrorMessage()
        {
            Console.WriteLine("");
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("ERROR: Please only enter in numbers!");
            Console.WriteLine("Special symbols and alphabetic characters will not be accepted.");
            Console.ResetColor();
            Console.WriteLine("Enter any key to try again.");
            Console.ReadLine();
        }

        static void NegativeNumberError()
        {
            Console.WriteLine("");
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("ERROR: You inputed a negative number!");
            Console.WriteLine("Please only enter postive integers.");
            Console.ResetColor();
            Console.WriteLine("Enter any key to try again.");
            Console.ReadLine();
        }

        static void CheckIfOrderIsComplete()
        {
            Console.WriteLine("Would you like to add more to your order?");
            Console.WriteLine("Enter 'yes' if you would like to add more loaves or pastries.");
            Console.WriteLine("Otherwise enter 'no' to continue to checkout.");
            string userResponse = Console.ReadLine().ToLower();
            if (userResponse == "yes" || userResponse == "y")
                {
                    CalculateExtraOrder();
                }
            else if ( userResponse == "no" || userResponse == "n")
                {
                    Console.WriteLine("");
                    Console.WriteLine("Here is your final order:");
                }
            else 
                {
                    Console.WriteLine("");
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("ERROR: Please only enter 'yes' or 'no'.");
                    Console.ResetColor();
                    Console.WriteLine("Enter any key to try again.");
                    Console.ReadLine();
                    Console.WriteLine("");
                    CheckIfOrderIsComplete();
                }
        }

        static void CalculateExtraOrder()
        {
            Console.WriteLine("How many more loaves of bread do you want to order?");
            string moreStringBread = Console.ReadLine();
            Console.WriteLine("How many more pastries do you want to order?");
            string moreStringPastries = Console.ReadLine();
            try 
            {
                int moreBread = int.Parse(moreStringBread) + Bread.AmountOfLoaves;
                int morePastries = int.Parse(moreStringPastries) + Pastry.AmountOfPastries;
                if(moreBread > 0 && morePastries > 0)
                {
                    Bread.TotalBreadCost = 0;
                    Pastry.TotalPastryCost = 0;
                    Bread.CalculateBreadOrder(moreBread);
                    Pastry.CalculatePastryOrder(morePastries);
                    Console.WriteLine("");
                    Console.WriteLine("Here is your current order:");
                    DisplayOrder();
                    CheckIfOrderIsComplete();
                }
                else
                {
                    NegativeNumberError();
                    CalculateExtraOrder();
                }
            }
            catch
            {
                ErrorMessage();
                CalculateExtraOrder();
            }
        }
    }
}