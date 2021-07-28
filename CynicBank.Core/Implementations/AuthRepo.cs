using System;
using System.Collections.Generic;
using System.Text;
using CynicBank.Core.Interfaces;
using CynicBank.Core.Models;
using System.IO;
using CsvHelper;
using System.Globalization;
using System.Linq;
using Commons;

namespace CynicBank.Core.Implementations
{
    public class AuthRepo : IAuthRepo, IFileReader<User>
    {
        private static string userPath { get; set; }
            = @"C:\Users\hp\source\repos\CynicBank\db\users.csv";

        public bool Login(string email, string password)
        {
            bool isLoggedIn = false;

            var userList = ReadFile(userPath);
           

            foreach (var item in userList)
            {
                if(item.Email == email && item.Password == password)
                {
                    Session.LoggedInUser = item;
                    isLoggedIn = true;
                } else
                {
                    isLoggedIn = false;
                }
            }

            return isLoggedIn;
        }

        public bool Logout(string email)
        {
            throw new NotImplementedException();
        }

        public List<User> ReadFile(string filePath)
        {
            using (var streamReader = new StreamReader(filePath))
            {
                using (var csvReader = new CsvReader(streamReader, CultureInfo.InvariantCulture))
                {
                    var records = csvReader.GetRecords<User>().ToList();
                    return records;
                }
            }
        }

        public bool CheckIfExits(string email)
        {
            var userList = ReadFile(userPath);
            bool doesExist = false;

            foreach (var item in userList)
            {
                if (item.Email == email)
                {
                    doesExist = true;
                }
                else
                {
                    doesExist = false;
                }
            }

            return doesExist;
        }

    }
}
