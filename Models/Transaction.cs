using System;
using System.Collections.Generic;
using System.Text;

namespace Models
{
    public class Transaction
    {
        public DateTimeOffset Date { get; private set; } = DateTimeOffset.Now;

        public readonly string Description;

        public readonly int Amount;

        public readonly TransactionType TypeOfTransaction;

        public Transaction (
            int amount,
            string description,
            TransactionType typeOfTransaction
            )
        {
            Amount = amount;
            Description = description;
            TypeOfTransaction = typeOfTransaction;
        }

    }
}
