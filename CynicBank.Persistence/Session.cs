using System;
using Models;
using CynicBank.Persistence.Implementations;
using System.Collections.Generic;
namespace CynicBank.Persistence
{
    public static class Session
    {
        public static User LoggedInUser { get; set; } 

        public static List<Account> GetLoggedInUserAccounts()
        {
            AccountManager accountManager = new AccountManager();

            List<Account> accounts = 
                accountManager
                .RetrieveAccounts()
                .FindAll(x => x.UserId == LoggedInUser.Id);

            return accounts;
        }

        public static string ConnectionString { get; set; }
            = @"Data Source=LAPTOP-0VSJ0RU3;Initial Catalog=CynicDB;Integrated Security=True;Pooling=False";
    }
}
