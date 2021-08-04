using System;
namespace Models
{
    public class User
    {
        /// <summary>
        /// Models Customer details
        /// </summary>
        public string Id { get; set; }
        public string Email { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Password { get; set; }
        public string FullName { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime UpdatedAt { get; set; }

        private string GetFullName(string first, string last) => $"{first} {last}";

        public User()
        {

        }
        public User
         (string firstName,
          string lastName,
          string email,
          string password
         )
        {
            FirstName = firstName;
            LastName = lastName;
            Email = email;
            Password = password;
            Id = Guid.NewGuid().ToString();
            CreatedAt = DateTime.Now;
            UpdatedAt = DateTime.Now;
            FullName = GetFullName(firstName, lastName);
        }
    }
}
