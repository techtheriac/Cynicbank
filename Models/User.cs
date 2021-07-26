using System;
using System.Collections.Generic;
using System.Text;

namespace Models
{
    public class User
    {
       Dictionary<string, IAccount> Accounts = new Dictionary<string, IAccount>();

        public int Id;

        public string Email;

        public string FirstName;

        public string LastName;

        public readonly string Password;

        public User(
            string firstName,
            string lastName,
            string email,
            string password
            )
        {
            FirstName = firstName;
            LastName = lastName;
            Email = email;
            Password = password;
        }

    }
}
