using System;
using System.Collections.Generic;
using System.Text;
using CynicBank.Persistence.Interfaces;
using CynicBank.Persistence.Implementations;
using System.Data.SqlClient;
using Models;

namespace CynicBank.Persistence.Implementations
{
    public class TransactionManager : ITransactionManager
    {
        private string ConnectionString = Session.ConnectionString;

        public bool AddTransaction(Transaction model)
        {
            using (SqlConnection connection = new SqlConnection(ConnectionString))
            {
                using (SqlCommand command = new SqlCommand("spAddTransaction", connection))
                {
                    connection.Open();

                    command.CommandType = System.Data.CommandType.StoredProcedure;

                    command.Parameters.AddWithValue("@Id", model.Id);
                    command.Parameters.AddWithValue("@Description", model.Description);
                    command.Parameters.AddWithValue("@Amount", model.Amount);
                    command.Parameters.AddWithValue("@TransactionType", model.TypeOfTransaction.ToString());
                    command.Parameters.AddWithValue("@AccountNumber", model.AccountNumber);
                    command.Parameters.AddWithValue("@CreatedAt", model.CreatedAt);
                    command.Parameters.AddWithValue("@UpdatedAt", model.UpdatedAt);


                    int RowsAffected = command.ExecuteNonQuery();

                    return true;
                }
            }
        }

        public List<Transaction> ReadTransactions()
        {
            using (SqlConnection connection = new SqlConnection(ConnectionString))
            {
                using (SqlCommand command = new SqlCommand("spReadTransactions", connection))
                {
                    connection.Open();
                    command.CommandType = System.Data.CommandType.StoredProcedure;


                    SqlDataReader dataReader = command.ExecuteReader();

                    List<Transaction> transactions = new List<Transaction>();

                    while (dataReader.Read())
                    {
                        Transaction transaction = new Transaction() { };
                        transaction.Id = dataReader["Id"].ToString();
                        transaction.Description = dataReader["Description"].ToString();
                        transaction.AccountNumber = dataReader["AccountNumber"].ToString();
                        transaction.Amount = dataReader.GetDecimal(dataReader.GetOrdinal("Amount"));
                        transaction.TypeOfTransaction = CastEnum(dataReader["TypeOfTransaction"].ToString());
                        transaction.CreatedAt = dataReader.GetDateTime(dataReader.GetOrdinal("CreatedAt"));
                        transaction.UpdatedAt = dataReader.GetDateTime(dataReader.GetOrdinal("UpdatedAt"));

                        transactions.Add(transaction);
                    }

                    return transactions;
                }

            }
        }

        private TransactionType CastEnum(string enumValue) =>
            (enumValue) switch
            {
                ("Debit") => TransactionType.Debit,
                ("Credit") => TransactionType.Credit,
                _ => throw new InvalidCastException($"Can't convert {enumValue} to TransactionType")
            };
    }
}
