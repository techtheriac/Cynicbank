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
            //Run database query to find if user exists

            //Update session object on persistence layer if user exists
            return false;
        }

        public bool Logout(string email)
        {
            //Update session object on persistence layer
            return false;
        }

    }
}
