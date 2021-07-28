using System;
using System.Collections.Generic;
using System.Text;
using Commons;

namespace CynicBank.Core.Models
{
    public class Account
    {
        public string Id { get; set; }

        public string CustomerId { get; set; }

        public AccountType AccountType { get; set; }

        public string AccountNumber { get; set; }

        public string AccountName { get; set; }

        public int AccountBalance { get; set; }

        public List<Transaction> TransactionLog { get; set; }


        public Account()
        {
            AccountNumber = Helpers.GenerateAccountNumber();
            TransactionLog = new List<Transaction>();
        }
    }
}
