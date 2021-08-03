using System;
using System.Collections.Generic;
using System.Text;
using CynicBank.Persistence.Interfaces;
using CynicBank.Persistence.Implementations;
using Models;

namespace CynicBank.Persistence.Implementations
{
    public class TransactionManager : ITransactionManager
    {
        public bool AddTransaction(Transaction model)
        {
            throw new NotImplementedException();
        }

        public List<Transaction> ReadTransactions()
        {
            throw new NotImplementedException();
        }
    }
}
