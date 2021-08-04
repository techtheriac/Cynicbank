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
                using (SqlConnection connection = new SqlConnection(ConnectionString))
                {
                    using (SqlCommand command = new SqlCommand("addNewUser", connection))
                    {
                        connection.Open();

                        command.CommandType = System.Data.CommandType.StoredProcedure;

                        command.Parameters.AddWithValue("@Id", model.Id);
                        command.Parameters.AddWithValue("@FirstName", model.FirstName);
                        command.Parameters.AddWithValue("@LastName", model.LastName);
                        command.Parameters.AddWithValue("@FullName", model.FullName);
                        command.Parameters.AddWithValue("@Email", model.Email);
                        command.Parameters.AddWithValue("@Password", model.Password);
                        command.Parameters.AddWithValue("@CreatedAt", model.CreatedAt);
                        command.Parameters.AddWithValue("@UpdatedAt", model.UpdatedAt);

                        
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
                    using (SqlCommand command = new SqlCommand("spRetrieveUsers", connection))
                    {
                        connection.Open();
                        command.CommandType = System.Data.CommandType.StoredProcedure;
                    

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
