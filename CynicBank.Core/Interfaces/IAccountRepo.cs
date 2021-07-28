using System;
using System.Collections.Generic;
using System.Text;
using CynicBank.Core.Models;

namespace CynicBank.Core.Interfaces
{
    public interface IAccountRepo
    {
        string CreateSavingsAccount(Account accountModel, User userModel);
        string CreateCurrentAccount(Account accountModel, User userModel);
    }
}
