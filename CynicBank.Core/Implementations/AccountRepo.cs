using System;
using System.Collections.Generic;
using System.Text;
using CynicBank.Core.Models;
using CynicBank.Core.Interfaces;

namespace CynicBank.Core.Implementations
{
    public class AccountRepo : IAccountRepo, IDbHandler<Account>
    {
        private static string AccountsPath { get; set; }
          = @"C:\Users\hp\source\repos\CynicBank\db\account.csv";

        public string CreateCurrentAccount(Account accountModel, User userModel)
        {
            string status = String.Empty;

            return "";
        }

        public string CreateSavingsAccount(Account accountModel, User userModel)
        {
            return "";
        }

        public bool WriteToFile(Account model, string filePath)
        {
            return false;
        }

        public bool ReadFile(string filePath)
        {
            return false;
        }
    }
}
