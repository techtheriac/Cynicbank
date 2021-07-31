using System;
using System.Collections.Generic;
using System.Text;
using CynicBank.Core.Interfaces;
using System.IO;
using CsvHelper;
using System.Globalization;
using System.Linq;
using Models;

namespace CynicBank.Core.Implementations
{
    /// <summary>
    /// Handles User Authentication
    /// </summary>
    public class AuthRepo : IAuthRepo
    {

        private string UserPath { get; set; }
            = @"C:\Users\hp\source\repos\CynicBank\db\users.csv";

        private readonly DbHandler<User> _dbHandler;
        public AuthRepo(DbHandler<User> dbHandler)
        {
            _dbHandler = dbHandler;
        }

        public bool Login(string email, string password)
        {

            var userList = ReadFile(UserPath);

            var matchedUser = userList.FirstOrDefault(a => a.Password == password && a.Email == email);

            if(matchedUser != null)
            {
                Session.LoggedInUser = matchedUser;
                Session.UserName = matchedUser.FirstName;
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

        public List<User> ReadFile(string filePath)
        {
            return _dbHandler.ReadFile(filePath);
        }

    }
}
