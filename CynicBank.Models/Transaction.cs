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
        public DateTime Date { get; private set; } = DateTime.Now;

        public string Description { get; set; }

        public int Amount { get; set; }

        public TransactionType TypeOfTransaction { get; set; }
    }
}
