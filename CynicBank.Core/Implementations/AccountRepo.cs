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
                AccountType = AccountType.Current,
                AccountName = $"{userModel.FirstName} {userModel.LastName}",
                AccountNumber = Helpers.GenerateAccountNumber(),
                AccountBalance = (decimal)initialBalance,
                UserId = userModel.Id
            };

            if(_AccountManager.AccountExist(newAccount) == true)
            {
                return false;
            }
            else
            {
                var status = _AccountManager.AddAccount(newAccount);
                return status;
            }
        }

        public bool CreateSavingsAccount(int initialBalance, User userModel)
        {
            var newAccount = new Account
            {
                AccountType = AccountType.Savings,
                AccountName = $"{userModel.FirstName} {userModel.LastName}",
                AccountNumber = Helpers.GenerateAccountNumber(),
                AccountBalance = (decimal)initialBalance,
                UserId = userModel.Id
            };

            if(_AccountManager.AccountExist(newAccount) == true)
            {
                return false;
            }
            else
            {
                var status = _AccountManager.AddAccount(newAccount);
                return status;
            }
        }
    }
}
