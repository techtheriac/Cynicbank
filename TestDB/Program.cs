using System;
using CynicBank.Persistence.Implementations;
using Models;
using System.Collections;

namespace TestDB
{
    class Program
    {
        static void Main(string[] args)
        {
            UserManager userManager = new UserManager();

            var newUser = new User
                (
                "Gbolahan",
                "Alabi",
                "gbolahanalabi@yahoo.com",
                "alibi"
                );

            userManager.AddUser(newUser);

            var res = userManager.RetrieveUsers();

            foreach (var item in res)
            {
                Console.WriteLine(item.FullName);
            }
        }
    }
}
