using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Text;
using CynicBank.Core.Interfaces;
using Commons;
using CsvHelper;
using CsvHelper.Configuration;
using Models;
using CynicBank.Persistence.Implementations;
using CynicBank.Persistence.Interfaces;

namespace CynicBank.Core.Implementations
{
    public class AccountRepo : IAccountRepo
    {

        private readonly IAccountManager _AccountManager;
        public AccountRepo(IAccountManager accountManager)
        {
            _AccountManager = accountManager;
        }
        public bool CreateCurrentAccount(int initialBalance, User userModel)
        {
            // Create Account Model
            var newAccount = new Account
            {
                Id = userModel.Email,
                AccountType = AccountType.Current,
                AccountName = userModel.FullName,
                AccountNumber = Helpers.GenerateAccountNumber(),
                AccountBalance = initialBalance,
            };

            // Run query to find if account exists or not
            // If account account already exists return false;
            // Otherwise Add Account MOdel to database;

            return false;
        }

        public bool CreateSavingsAccount(int initialBalance, User userModel)
        {
            var newAccount = new Account
            {
                Id = userModel.Email,
                AccountType = AccountType.Savings,
                AccountName = userModel.FullName,
                AccountNumber = Helpers.GenerateAccountNumber(),
                AccountBalance = initialBalance,
            };

            // Same as above

            return false;
        }
    }
}
