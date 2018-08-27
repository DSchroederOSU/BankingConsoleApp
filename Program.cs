using System;

namespace ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Globals.InitializeGlobalVariables();
            MenuHelper.PrintMainMenu();
            GetMenuCommand();
        }

        // home menu
        public static void GetMenuCommand()
        {
            string command = Console.ReadLine();
            int value;
            if (int.TryParse(command, out value))
            {
                switch (value)
                {
                    case 1:
                        User.RegisterNewUser();
                        MenuHelper.PrintMainMenu();
                        GetMenuCommand();
                        break;
                    case 2:
                        if (InputValidation.PromptLogin())
                            GetLoggedMenuCommand();
                        else
                            GetMenuCommand();
                        break;
                    case 3:
                        Environment.Exit(-1);
                        break;
                    default:
                        MenuHelper.PrintMainMenu();
                        GetMenuCommand();
                        break;
                }
            }
            else
            {
                MenuHelper.PrintMainMenu();
                GetMenuCommand();
            }

        }

        // the main user menu once logged in
        public static void GetLoggedMenuCommand()
        {
            string command = Console.ReadLine();
            int value;
            if (int.TryParse(command, out value))
            {
                switch (value)
                {
                    case 1:
                        Transaction.PrintAccountBalance();
                        MenuHelper.PrintLoggedMenu();
                        GetLoggedMenuCommand();
                        break;
                    case 2:
                        Console.Clear();
                        Transaction.MakeDeposit();
                        MenuHelper.PrintLoggedMenu();
                        GetLoggedMenuCommand();
                        break;
                    case 3:
                        Console.Clear();
                        Transaction.MakeWithdraw();
                        MenuHelper.PrintLoggedMenu();
                        GetLoggedMenuCommand(); 
                        break;
                    case 4:
                        Console.Clear();
                        Transaction.PrintTransactionHistory();
                        Console.Clear();
                        MenuHelper.PrintLoggedMenu();
                        GetLoggedMenuCommand();
                        break;
                    case 5:
                        Logout();
                        break;
                    default:
                        // default was invalid command
                        Console.Clear();
                        MenuHelper.PrintLoggedMenu();
                        GetLoggedMenuCommand();
                        break;
                }
            }
            else
            {
                Console.Clear();
                MenuHelper.PrintLoggedMenu();
                GetLoggedMenuCommand();
            }

        } 

        // clear out the current user variable
        // send user back to main menu
        private static void Logout(){
            Console.Clear();
            MenuHelper.PrintLoggedMenu();
            Console.WriteLine("Logout? y/n");
            string command = Console.ReadLine();
            if (command == "y"){
                Globals.CurrentUser = new User();
                Console.Clear();
                MenuHelper.PrintMainMenu();
                GetMenuCommand();
            }
            else if(command == "n")
            {
                Console.Clear();
                MenuHelper.PrintLoggedMenu();
                GetLoggedMenuCommand();
            }
            else
            {  
                Logout();
            }

        }
    }
}
