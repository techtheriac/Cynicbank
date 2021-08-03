using System;
using CynicBank.Persistence.Implementations;
using Models;

namespace TestDB
{
    class Program
    {
        static void Main(string[] args)
        {
            UserManager userManager = new UserManager();

            var newUser = new User
            {
                FirstName = "Fabian",
                LastName = "Jachi",
                Email = "Lawal",
                Password = "gowon",
            };

            userManager.AddUser(newUser);

            var res = userManager.RetrieveUsers();

            foreach (var item in res)
            {
                Console.WriteLine(item.Email);
            }
        }
    }
}
