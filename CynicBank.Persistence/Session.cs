using System;
using Models;
namespace CynicBank.Persistence
{
    public static class Session
    {
        public static User LoggedInUser { get; set; }
        public static string ConnectionString { get; set; }
            = @"Data Source=LAPTOP-0VSJ0RU3;Initial Catalog=CynicDB;Integrated Security=True;Pooling=False";
    }
}
