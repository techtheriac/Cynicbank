using System;
using System.Collections.Generic;
using System.Text;
using CynicBank.Persistence.Interfaces;
using Models;
using System.Data.SqlClient;

namespace CynicBank.Persistence.Implementations
{
    public class UserManager : IUserManager
    {
        private string ConnectionString = Session.ConnectionString;
        public bool AddUser(User model)
        {

            if(UserExists(model) == true)
            {
                return false;
            }
            else
            {
                string sql = "INSERT INTO Users(Id, FirstName, LastName, FullName, Email, Password, CreatedAt, UpdatedAt)";
                sql += " VALUES(@Id, @FirstName, @LastName, @FullName, @Email, @Password, @CreatedAt, @UpdatedAt)";

                using (SqlConnection connection = new SqlConnection(ConnectionString))
                {
                    using (SqlCommand command = new SqlCommand(sql, connection))
                    {
                        command.Parameters.Add(new SqlParameter("@Id", model.Id));
                        command.Parameters.Add(new SqlParameter("@FirstName", model.FirstName));
                        command.Parameters.Add(new SqlParameter("@LastName", model.LastName));
                        command.Parameters.Add(new SqlParameter("@FullName", model.FullName));
                        command.Parameters.Add(new SqlParameter("@Email", model.Email));
                        command.Parameters.Add(new SqlParameter("@Password", model.Password));
                        command.Parameters.Add(new SqlParameter("@CreatedAt", model.CreatedAt));
                        command.Parameters.Add(new SqlParameter("@UpdatedAt", model.UpdatedAt));

                        connection.Open();
                        int RowsAffected = command.ExecuteNonQuery();
                    }

                }

                return true;
            }
            
                
        }

        public List<User> RetrieveUsers()
        {
            
                using (SqlConnection connection = new SqlConnection(ConnectionString))
                {
                    using (SqlCommand command = new SqlCommand())
                    {
                        connection.Open();
                        command.Connection = connection;
                        
                        command.CommandText = $"SELECT * FROM Users";

                        SqlDataReader dataReader = command.ExecuteReader();

                        List<User> users = new List<User>();

                        while(dataReader.Read())
                        {
                            User user = new User() { };
                            user.Id = dataReader["Id"].ToString();
                            user.FirstName = dataReader["FirstName"].ToString();
                            user.LastName = dataReader["LastName"].ToString();
                            user.Email = dataReader["Email"].ToString();
                            user.Password = dataReader["Password"].ToString();

                            users.Add(user);
                        }

                        return users;
                    }
                    
                }

    }

        public bool UserExists(User model)
        {
            return RetrieveUsers().Exists(x => x.Id == model.Id || x.Email == model.Email);
        }
    }
}
