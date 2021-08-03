using System;
using System.Collections.Generic;
using System.Text;
using Models;
namespace CynicBank.Persistence.Interfaces
{
    public interface IUserManager
    {
        bool AddUser(User model);
        bool UserExists(User model);
        List<User> RetrieveUsers();
    }
}
