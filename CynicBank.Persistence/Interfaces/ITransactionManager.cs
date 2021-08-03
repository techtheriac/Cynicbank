using System;
using System.Collections.Generic;
using System.Text;
using Models;

namespace CynicBank.Persistence.Interfaces
{
    public interface ITransactionManager
    {
        bool AddTransaction(Transaction model);
        List<Transaction> ReadTransactions();
    }
}
