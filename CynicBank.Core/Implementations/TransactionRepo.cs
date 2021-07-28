using System;
using System.Collections.Generic;
using System.Text;
using CynicBank.Core.Interfaces;
using CynicBank.Core.Models;

namespace CynicBank.Core.Implementations
{
    public class TransactionRepo : ITransactionRepo, IDbHandler<Transaction>
    {
        public string GetAccountBalance(string accountId, User model)
        {
            throw new NotImplementedException();
        }

        public string GetAccountDetails(string accountNumber)
        {
            throw new NotImplementedException();
        }

        public string GetAccountStatement(string accountId)
        {
            throw new NotImplementedException();
        }

        public string MakeDeposit(Transaction transactionModel, User model)
        {
            throw new NotImplementedException();
        }

        public bool ReadFile(string filePath)
        {
            throw new NotImplementedException();
        }

        public string SendBetweenAccounts(Transaction transactionModel, User model)
        {
            throw new NotImplementedException();
        }

        public string SendMoney(Transaction transactionModel, User model)
        {
            throw new NotImplementedException();
        }

        public string WithdrawMoney(Transaction transactionModel, User model)
        {
            throw new NotImplementedException();
        }

        public bool WriteToFile(Transaction model, string filePath)
        {
            throw new NotImplementedException();
        }

        List<Transaction> IDbHandler<Transaction>.ReadFile(string filePath)
        {
            throw new NotImplementedException();
        }
    }
}
