using System;
using System.Collections.Generic;
using System.Text;

namespace CynicBank.Core.Models
{
    public class Transaction
    {
        public string Id { get; set; }
        public DateTimeOffset Date { get; private set; } = DateTimeOffset.Now;

        public string Description { get; set; }

        public int Amount { get; set; }

        public TransactionType TypeOfTransaction { get; set; }

        public Transaction(
            string id,
            int amount,
            string description,
            TransactionType typeOfTransaction
            )
        {
            Id = id;
            Amount = amount;
            Description = description;
            TypeOfTransaction = typeOfTransaction;
        }

    }
}
