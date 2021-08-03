using System;
using System.Collections.Generic;
using System.Text;
using CynicBank.Persistence.Interfaces;
using Models;

namespace CynicBank.Persistence.Implementations
{
    public class AccountManager : IAccountManager
    {
        public bool AccountExist(Account model)
        {
            throw new NotImplementedException();
        }

        public bool AddAccount(Account model)
        {
            throw new NotImplementedException();
        }

        public Account RetrieveAccount(User model, AccountType accountType)
        {
            throw new NotImplementedException();
        }

        public List<Account> RetrieveAccounts(User model)
        {
            throw new NotImplementedException();
        }

        public bool UpdateAccount(Account model)
        {
            throw new NotImplementedException();
        }
    }
}
