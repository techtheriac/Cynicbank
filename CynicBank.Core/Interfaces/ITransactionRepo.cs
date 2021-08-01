using System;
using System.Collections.Generic;
using System.Text;
using Models;

namespace CynicBank.Core.Interfaces
{
    public interface ITransactionRepo
    {
        // Logged in User is referenced for these operations
        bool MakeDeposit(int amount, AccountType to);
        bool SendMoney(int amount, string to);
        bool SendBetweenAccounts(AccountType from, AccountType to);
        bool WithdrawMoney(int amount, AccountType from);
    }
}
