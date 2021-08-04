using System;
using System.Collections.Generic;
using System.Text;
using System.IO;
using CynicBank.Core.Interfaces;
using System.Globalization;
using CsvHelper;
using CsvHelper.Configuration;
using System.Linq;
using Models;
using CynicBank.Persistence.Implementations;
using CynicBank.Persistence.Interfaces;

namespace CynicBank.Core.Implementations
{
    public class UserRepo : IUserRepo
    {
        private readonly IUserManager _UserManager;

        public UserRepo(IUserManager userManager)
        {
            _UserManager = userManager;
        }

        public bool AddNewUser(User userModel)
        {
           
            if(_UserManager.UserExists(userModel) == true)
            {
                return false;
            }
            else
            {
                var status = _UserManager.AddUser(userModel);
                return status;
            }
        }
    }
}
