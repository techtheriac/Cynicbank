using System;
using System.Collections.Generic;
using System.Text;

namespace Models
{
    public class Transaction
    {
        /// <summary>
        /// Models Bank transaction details
        /// </summary>
        public string Id { get; set; }
        
        public string Description { get; set; }

        public decimal Amount { get; set; }

        public TransactionType TypeOfTransaction { get; set; }

        public DateTime CreatedAt { get; set; }

        public DateTime UpdatedAt { get; set; }

        public Transaction()
        {
            Id = Guid.NewGuid().ToString();
            CreatedAt = DateTime.Now;
            UpdatedAt = DateTime.Now;
        }
    }
}
