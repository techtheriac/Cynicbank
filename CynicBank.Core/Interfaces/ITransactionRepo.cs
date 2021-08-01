using System;
using System.Collections.Generic;
using System.Text;
using Models;

namespace CynicBank.Core.Interfaces
{
    public interface ITransactionRepo
    {
        // Logged in User is referenced for these operations
        string MakeDeposit(int amount, AccountType to);
        //string SendMoney(int amount, AccountType from, string to);
        string SendBetweenAccounts(AccountType from, AccountType to);
        string WithdrawMoney(int amount, AccountType from);
    }
}
