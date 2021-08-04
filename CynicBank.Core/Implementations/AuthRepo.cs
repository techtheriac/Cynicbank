using System;
using System.Collections.Generic;
using System.Text;
using CynicBank.Core.Interfaces;
using System.IO;
using CsvHelper;
using System.Globalization;
using System.Linq;
using Models;
using CynicBank.Persistence;
using CynicBank.Persistence.Interfaces;
using CynicBank.Persistence.Implementations;

namespace CynicBank.Core.Implementations
{
    /// <summary>
    /// Handles User Authentication
    /// </summary>
    public class AuthRepo : IAuthRepo
    {
        private readonly IUserManager _UserManager;
       
        public AuthRepo(IUserManager userManager)
        {
            _UserManager = userManager;
        }

        public bool Login(string email, string password)
        {
            var users = _UserManager.RetrieveUsers();

            var matchedUser = users.FirstOrDefault(x => x.Email == email && x.Password == password);

            if(matchedUser != null)
            {
                Session.LoggedInUser = matchedUser;
                return true;
            }
            else
            {
                return false;
            }
        }

        public bool Logout(string email)
        {
            Session.LoggedInUser = null;
            return true;
        }

    }
}
