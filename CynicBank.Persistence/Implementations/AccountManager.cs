using System;
using System.Collections.Generic;
using System.Text;
using CynicBank.Persistence.Interfaces;
using Models;
using System.Data.SqlClient;

namespace CynicBank.Persistence.Implementations
{
    public class AccountManager : IAccountManager
    {
        private string ConnectionString { get; set; } = Session.ConnectionString;
        public bool AccountExist(Account model)
        {
            return RetrieveAccounts().Exists(x => x.AccountType == model.AccountType && x.UserId == model.UserId);
        }

        public bool AddAccount(Account model)
        {
            if(AccountExist(model) == true)
            {
                return false;
            }
            else
            {
                using (SqlConnection connection = new SqlConnection(ConnectionString))
                {
                    using (SqlCommand command = new SqlCommand("spCreateBankAccount", connection))
                    {
                        connection.Open();

                        command.CommandType = System.Data.CommandType.StoredProcedure;

                        command.Parameters.AddWithValue("@Id", model.Id);
                        command.Parameters.AddWithValue("@AccountType", model.AccountType.ToString());
                        command.Parameters.AddWithValue("@AccountNumber", model.AccountNumber);
                        command.Parameters.AddWithValue("@AccountName", model.AccountName);
                        command.Parameters.AddWithValue("@UserId", model.UserId);
                        command.Parameters.AddWithValue("@AccountBalance", model.AccountBalance);
                        command.Parameters.AddWithValue("@CreatedAt", model.CreatedAt);
                        command.Parameters.AddWithValue("@UpdatedAt", model.UpdatedAt);


                        int RowsAffected = command.ExecuteNonQuery();
                    }

                }

                return true;
            }
        }

        public Account RetrieveAccount(User model, AccountType accountType)
        {
            throw new NotImplementedException();
        }

        public List<Account> RetrieveAccounts()
        {
            using (SqlConnection connection = new SqlConnection(ConnectionString))
            {
                using (SqlCommand command = new SqlCommand("spRetrieveBankAccounts", connection))
                {
                    connection.Open();
                    command.CommandType = System.Data.CommandType.StoredProcedure;


                    SqlDataReader dataReader = command.ExecuteReader();

                    List<Account> accounts = new List<Account>();

                    while (dataReader.Read())
                    {
                        Account account = new Account() { };
                        account.Id = dataReader["Id"].ToString();
                        account.AccountType = CastEnum(dataReader["AccountType"].ToString());
                        account.AccountNumber = dataReader["AccountNumber"].ToString();
                        account.AccountName = dataReader["AccountName"].ToString();
                        account.UserId = dataReader["UserId"].ToString();
                        account.AccountBalance = dataReader.GetDecimal(dataReader.GetOrdinal("AccountBalance"));
                        account.CreatedAt = dataReader.GetDateTime(dataReader.GetOrdinal("CreatedAt"));
                        account.UpdatedAt = dataReader.GetDateTime(dataReader.GetOrdinal("UpdatedAt"));

                        accounts.Add(account);
                    }

                    return accounts;
                }

            }
        }

        public bool CreditAccount(string accountNumber, decimal amount)
        {
            using (SqlConnection connection = new SqlConnection(ConnectionString))
            {
                using (SqlCommand command = new SqlCommand("spUpdateAccountBalanceCredit", connection))
                {
                    connection.Open();

                    command.CommandType = System.Data.CommandType.StoredProcedure;

                    command.Parameters.AddWithValue("@AccountNumber", accountNumber);
                    command.Parameters.AddWithValue("@Amount", amount);
                 


                    int RowsAffected = command.ExecuteNonQuery();
                }

            }

            return true;

        }

        private AccountType CastEnum(string enumValue) =>
            (enumValue) switch
            {
                ("Current") => AccountType.Current,
                ("Savings") => AccountType.Savings,
                _ => throw new InvalidCastException($"Can't convert {enumValue} to AccountType")
            };
    }
}
