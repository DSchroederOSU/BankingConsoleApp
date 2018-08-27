using System;
using System.Collections.Generic;

namespace ConsoleApp
{
    public class Transaction
    {
        public double Amount { get; set; }
        public string Type { get; set; }
        public DateTime timestamp { get; set; }

        // method to make a withdraw transaction
        // Update User object, subtract amount from AcountTotal, add transaction to list
        public static void MakeWithdraw()
        {
            Console.WriteLine("Enter Amount to Withdraw:");
            double WithdrawAmount = InputValidation.ValidateNumericInput(Console.ReadLine());

            if (!double.IsNaN(WithdrawAmount))
            {
                int index = Globals.RegisteredUsers.FindIndex((User obj) => obj.Username == Globals.CurrentUser.Username);
                Globals.RegisteredUsers[index].AccountTotal -= WithdrawAmount;
                Globals.RegisteredUsers[index].Transactions.Add(new Transaction { Amount = WithdrawAmount, Type = "Withdraw", timestamp = DateTime.Now });
                Globals.CurrentUser = Globals.RegisteredUsers[index];
                Console.Clear();
            }
            else
            {
                Console.Clear();
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Please Enter a Numeric Value:");
                Console.ResetColor();
                MakeWithdraw();
            }
        }

        // method to make a deposit transaction
        // Update User object, add amount from AcountTotal, add transaction to list
        public static void MakeDeposit()
        { 
            Console.WriteLine("Enter Amount to Deposit:");
            double DepositAmount = InputValidation.ValidateNumericInput(Console.ReadLine());

            if (!double.IsNaN(DepositAmount))
            {
                int index = Globals.RegisteredUsers.FindIndex((User obj) => obj.Username == Globals.CurrentUser.Username);
                Globals.RegisteredUsers[index].AccountTotal += DepositAmount;
                Globals.RegisteredUsers[index].Transactions.Add(new Transaction { Amount = DepositAmount, Type = "Deposit", timestamp = DateTime.Now });
                Globals.CurrentUser = Globals.RegisteredUsers[index];
                Console.Clear();
            }
            else
            {
                Console.Clear();
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Please Enter a Numeric Value:");
                Console.ResetColor();
                MakeDeposit();
            }
        }

        // Prints the users running total from the Current user object
        public static void PrintAccountBalance()
        {
            Console.Clear();
            Console.WriteLine("Account Balance:");
            string currency = String.Format("{0:C}", Globals.CurrentUser.AccountTotal);
            Console.WriteLine(currency);
            Console.WriteLine();
            Console.WriteLine("Hit Enter to Return");
            Console.ReadLine();
            Console.Clear();
        }

        // Iterate through the current user's Transactions list
        // print a neat record of transactions
        public static void PrintTransactionHistory()
        {
            int stringlength = "Withdraw".Length;

            for (int i = 0; i < Globals.CurrentUser.Transactions.Count; i++)
            {
                string type = Globals.CurrentUser.Transactions[i].Type; 
                string paddedType = type.PadRight(stringlength+1); 
                string currency = String.Format("{0:C}", Globals.CurrentUser.Transactions[i].Amount);
                Console.WriteLine(Globals.CurrentUser.Transactions[i].timestamp + ": " + paddedType + " " + currency);
            }
            Console.WriteLine();
            Console.WriteLine("Hit Enter to Return");
            Console.ReadLine();

        }
    }


}
