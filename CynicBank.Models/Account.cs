using System;
using System.Collections.Generic;
using System.Text;

namespace Models
{
    /// <summary>
    /// Models Bank Account Details
    /// </summary>
    public class Account
    {
        
        public string Id { get; set; }

        public AccountType AccountType { get; set; }

        public string AccountNumber { get; set; }

        public string AccountName { get; set; }

        public decimal AccountBalance { get; set; }

        public DateTime CreatedAt { get; set; }

        public DateTime UpdatedAt { get; set; }


        public Account()
        {
            Id = Guid.NewGuid().ToString();
            CreatedAt = DateTime.Now;
            UpdatedAt = DateTime.Now;
        }
    }
}
