using System;
using System.Collections.Generic;
using System.Text;

namespace CynicBank.Core.Interfaces
{
    public interface IAuthRepo
    {
        bool Login(string email, string password);
        bool Logout(string email);
    }
}
