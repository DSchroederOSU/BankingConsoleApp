using System;
using System.Collections.Generic;

namespace ConsoleApp
{ 
    public class User
    {
        public string Username { get; set; }
        public string Password { get; set; }

        public double AccountTotal { get; set; }
        public List<Transaction> Transactions { get; set; }
        public Transaction NewTransaction { get; set; }

        // get user account information and create a new registered user
        public static void RegisterNewUser()
        {
            Console.Clear();
            Console.WriteLine("Register New User Account:");
            Console.WriteLine("Please enter a username:");
            string username = Console.ReadLine();
            Console.WriteLine("Please enter a password:");
            string pass = InputValidation.getPassword();
            createNewUser(username, pass);
            Console.WriteLine("Registration Successful");
        }

        // create a new user object and add it to the list of registered users
        public static void createNewUser(string username, string password)
        {
            User user = new User
            {
                Username = username,
                Password = password,
                AccountTotal = Globals.DEFAULT_BALANCE,
                Transactions = new List<Transaction>(),
                NewTransaction = new Transaction()
            };
            Globals.RegisteredUsers.Add(user);
        }

        // check users credentials and set the currentUser to who was found in list of registered users
        public static bool ValidateUserLogin(string username, string password)
        {
            if (Globals.RegisteredUsers.Count > 0)
            { 

                int index = Globals.RegisteredUsers.FindIndex((User obj) => obj.Username == username && obj.Password == password);
                if (index != -1)
                {
                    Globals.CurrentUser = Globals.RegisteredUsers[index];
                    return true;
                }
            }
            return false;
        }
    }
}