using System;
using System.Collections.Generic;
using System.Text;
using Models;

namespace CynicBank.Core.Interfaces
{
    public interface IUserRepo
    {
        bool AddNewUser(User userModel);

    }
}
