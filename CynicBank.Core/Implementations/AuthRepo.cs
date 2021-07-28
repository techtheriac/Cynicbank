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
    /// <summary>
    /// Handles User Authentication
    /// </summary>
    public class AuthRepo : IAuthRepo, IFileReader<User>
    {
        private string userPath { get; set; }
            = @"C:\Users\hp\source\repos\CynicBank\db\users.csv";

        public bool Login(string email, string password)
        {

            var userList = ReadFile(userPath);

            var matchedUser = userList.FirstOrDefault(a => a.Password == password && a.Email == email);

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
            if(Commons.Session.LoggedInUser != null)
            {
                Commons.Session.LoggedInUser = null;
            }

            return true;
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
