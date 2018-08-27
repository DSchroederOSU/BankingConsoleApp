using System;
using System.Collections.Generic;

namespace ConsoleApp
{
    public static class Globals
    {
        public static User CurrentUser { get; set; }
        public static List<User> RegisteredUsers { get; set; }
        public static readonly int DEFAULT_BALANCE = 12000;

        public static void InitializeGlobalVariables()
        {
            RegisteredUsers = new List<User>();
            CurrentUser = new User();
        }
    }
}
