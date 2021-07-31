﻿namespace Models
{
    public class User
    {
        /// <summary>
        /// Models Customer details
        /// </summary>
        public string Email { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Password { get; set; }

        public string FullName => $"{FirstName} {LastName}";

        //public User(
        //    string firstName,
        //    string lastName,
        //    string email,
        //    string password
        //    )
        //{
        //    FirstName = firstName;
        //    LastName = lastName;
        //    Email = email;
        //    Password = password;
        //}
    }
}