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

namespace CynicBank.Core.Implementations
{
    public class AccountRepo : IAccountRepo
    {
        private readonly DbHandler<Account> _dbHandler;
        private static string AccountsPath
          = @"C:\Users\hp\source\repos\CynicBank\db\accounts.csv";

        public AccountRepo(DbHandler<Account> dbHandler)
        {
            _dbHandler = dbHandler;
        }
        public bool CreateCurrentAccount(int initialBalance, User userModel)
        {
            var newAccount = new Account
            {
                Id = userModel.Email,
                AccountType = AccountType.Current,
                AccountName = userModel.FullName,
                AccountNumber = Helpers.GenerateAccountNumber(),
                AccountBalance = initialBalance,
            };

            if (AccountExits(AccountType.Current) == true)
            {
                return false;
            }
            else
            {
                var status = _dbHandler.WriteToFile(newAccount, AccountsPath);

                return status;
            }
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

            if (AccountExits(AccountType.Savings) == true)
            {
                return false;
            }
            else
            {
               var status = _dbHandler.WriteToFile(newAccount, AccountsPath);
               return status;
            }
        }

        public List<Account> ReadFile(string filePath)
        {
            return _dbHandler.ReadFile(filePath);
        }

        private bool AccountExits(AccountType accountType)
        {
            var accountList = ReadFile(AccountsPath);

          //var accountTypeString = accountType.ToString();
            var accountId = Session.LoggedInUser.Email;

            return accountList.Exists(x => x.Id == accountId && x.AccountType == accountType);
        }
    }
}
