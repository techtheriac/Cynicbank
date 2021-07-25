using System;
using System.Collections.Generic;
using System.Text;

namespace Models
{
    public class Current : IAccount
    {
        public string AccountNumber { get; private set; }

        private int AccountBalance;

        public string AccountName;

        public Current(string accountName, string accountNumber, int initialBalance)
        {
            AccountName = accountName;
            AccountNumber = accountNumber;
            AccountBalance = initialBalance;
        }

        public string Debit(int amount)
        {
            if (NotAllowableAmount(amount) == true)
            {
                return "Insufficient funds";
            }
            else
            {
                AccountBalance -= amount;
                return "Transaction Completed Successfully";
            }
        }

        public string Credit(int amount)
        {
            AccountBalance += amount;
            return "Transaction Completed Successfully";
        }

        private bool NotAllowableAmount(int amount) =>
            AccountBalance < amount;
    }
}
