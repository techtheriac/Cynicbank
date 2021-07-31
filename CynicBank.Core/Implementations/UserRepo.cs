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

namespace CynicBank.Core.Implementations
{
    public class UserRepo : IUserRepo
    {
        private readonly DbHandler<User> _dbHandler;
        private static string UserPath = @"C:\Users\hp\source\repos\CynicBank\db\users.csv";

        public UserRepo(DbHandler<User> dbHandler)
        {
            _dbHandler = new DbHandler<User>();
        }

        public bool AddNewUser(User userModel)
        {
            _dbHandler.WriteToFile(userModel, UserPath);

            return true;
        }

        public bool CheckIfExits(string email)
        {
            var userList = ReadFile(UserPath);
            var doesExist = false;

            foreach (var item in userList)
            {
                doesExist = item.Email == email;
            }

            return doesExist;
        }

        public List<User> ReadFile(string filePath)
        {
            return _dbHandler.ReadFile(filePath);
        }

    }
}
