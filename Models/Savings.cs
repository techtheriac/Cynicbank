using System;
using System.Collections.Generic;
using System.Text;

namespace Models
{
    public class Savings : IAccount
    {
        public string AccountNumber { get; private set; }

        private int AccountBalance;

        public string AccountName;

        public Savings(string accountName, string accountNumber, int initialBalance)
        {
            AccountName = accountName;
            AccountNumber = accountNumber;
            AccountBalance = initialBalance;
        }

        public string Credit(int amount)
        {
            AccountBalance += amount;
            return "Transaction Completed Successfully";
        }

        public string Debit(int amount)
        {
            if (NotAllowableAmount(amount) == true)
            {
                return "Insuficient funds";
            }
            else
            {
                AccountBalance -= amount;
                return "Transaction Completed Successfully";
            }
        }

        private bool NotAllowableAmount(int amount) =>
            AccountBalance <= 1000 && amount >= 1000;

    }
}
