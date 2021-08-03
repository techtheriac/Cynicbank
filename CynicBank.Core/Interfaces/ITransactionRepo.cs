using System;
using System.Collections.Generic;
using System.Text;
using Models;

namespace CynicBank.Core.Interfaces
{
    public interface ITransactionRepo
    {
        // Logged in User is referenced for these operations
        string MakeDeposit(decimal amount, AccountType to);
        string SendMoney(decimal amount, AccountType from, string to);
        string WithdrawMoney(decimal amount, AccountType from);
    }
}
