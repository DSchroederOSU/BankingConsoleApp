using System;
namespace ConsoleApp
{
    public class InputValidation
    { 

        public static void GetUserInput(){

        }
        // used to validate user input was a numeric value for deposit and withdraws
        // return is double.NaN (treated as null)
        public static double ValidateNumericInput(string c){
            double value;
            return (double.TryParse(c, out value) == true) ? value : double.NaN;
        }

        // hide key strokes from console window by adding asterisks
        // taken from https://stackoverflow.com/questions/3404421/password-masking-console-application
        public static string getPassword()
        {
            string pass = "";
            ConsoleKeyInfo key;
            do
            {
                key = Console.ReadKey(true);
                // Backspace Should Not Work
                if (key.Key != ConsoleKey.Backspace && key.Key != ConsoleKey.Enter)
                {
                    pass += key.KeyChar;
                    Console.Write("*");
                }
                else
                {
                    if (key.Key == ConsoleKey.Backspace && pass.Length > 0)
                    {
                        pass = pass.Substring(0, (pass.Length - 1));
                        Console.Write("\b \b");
                    }
                }
            }
            // Stops Receving Keys Once Enter is Pressed
            while (key.Key != ConsoleKey.Enter);
            Console.Clear();
            return pass;
        }

        // prompt the user for login and validate user
        // if invalid, return to previous menu
        public static bool PromptLogin()
        {
            Console.Clear();
            Console.WriteLine("Please Login");
            Console.WriteLine();
            Console.WriteLine("Username:");
            string username = Console.ReadLine();
            Console.WriteLine("Password:");
            string pass = InputValidation.getPassword();
            if (!User.ValidateUserLogin(username, pass))
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Login Failed: Invalid Credentials.");
                Console.ResetColor();
                MenuHelper.PrintMainMenu();
                return false;
            }
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Login Successful.");
            Console.ResetColor();
            MenuHelper.PrintLoggedMenu();

            // login was successful enter main app
            return true;
        }
    }
}
