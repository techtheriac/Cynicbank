using System;
using System.Collections.Generic;
using System.Text;
using Models;

namespace CynicBank.Core.Interfaces
{
    public interface IAccountRepo
    {
        bool CreateSavingsAccount(int initialBalance, User userModel);
        bool CreateCurrentAccount(int initialBalance, User userModel);
    }
}
