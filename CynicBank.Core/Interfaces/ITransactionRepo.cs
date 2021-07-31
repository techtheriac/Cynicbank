using System;
using System.Collections.Generic;
using System.Text;
using Models;

namespace CynicBank.Core.Interfaces
{
    public interface ITransactionRepo
    {
        // Logged in User is referenced for these operations
        string MakeDeposit(Transaction transactionModel, User model);
        string SendMoney(Transaction transactionModel, User model);
        string SendBetweenAccounts(Transaction transactionModel, User model);
        string WithdrawMoney(Transaction transactionModel, User model);
        string GetAccountBalance(string accountId, User model);
        string GetAccountDetails(string accountNumber);
        string GetAccountStatement(string accountId);

    }
}
