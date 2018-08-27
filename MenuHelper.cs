using System;
namespace ConsoleApp
{
    public class MenuHelper
    {
        public static void PrintMainMenu()
        {
            Console.WriteLine("Please select from the following menu:");
            Console.WriteLine("[1] Register new account");
            Console.WriteLine("[2] Login");
            Console.WriteLine("[3] Exit");
        }

        public static void PrintLoggedMenu()
        {
            Console.WriteLine("Main Menu:");
            Console.WriteLine("[1] View Account Balance");
            Console.WriteLine("[2] Make a Deposit");
            Console.WriteLine("[3] Make a Withdraw");
            Console.WriteLine("[4] See Transaction History");
            Console.WriteLine("[5] Logout");
        }
    }
}
