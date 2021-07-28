using System;
using System.Collections.Generic;
using System.Text;
using System.IO;
using CynicBank.Core.Interfaces;
using CynicBank.Core.Models;
using System.Globalization;
using CsvHelper;
using CsvHelper.Configuration;
using System.Linq;

namespace CynicBank.Core.Implementations
{
    public class UserRepo : IUserRepo, IDbHandler<User>
    {
        private static string userPath { get; set; }
            = @"C:\Users\hp\source\repos\CynicBank\db\users.csv";

        public bool AddNewUser(User userModel)
        {
            WriteToFile(userModel, userPath);

            return true;
        }

        public bool CheckIfExits(string email)
        {
            var userList = ReadFile(userPath);
            bool doesExist = false;

            foreach (var item in userList)
            {
                if(item.Email == email)
                {
                    doesExist = true;
                } else
                {
                    doesExist = false;
                }
            }

            return doesExist;
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

        public bool WriteToFile(User model, string filePath)
        {
            var config = new CsvConfiguration(CultureInfo.InvariantCulture)
            {
                // Don't write the header again.
                HasHeaderRecord = false
            };

            using (var stream = File.Open(filePath, FileMode.Append))
            using (var writer = new StreamWriter(stream))
            using (var csv = new CsvWriter(writer, config))
            {
                //csv.WriteHeader<User>();
                csv.NextRecord();
                csv.WriteRecord(model);

                return true;
            }
        }
    }
}
