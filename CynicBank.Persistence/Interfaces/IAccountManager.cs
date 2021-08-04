using System;
using System.Collections.Generic;
using System.Text;
using Models;
namespace CynicBank.Persistence.Interfaces
{
    public interface IAccountManager
    {
        bool AddAccount(Account model);
        bool AccountExist(Account model);
        List<Account> RetrieveAccounts();
        Account RetrieveAccount(User model, AccountType accountType);
        bool UpdateAccount(Account model);
    }
}
