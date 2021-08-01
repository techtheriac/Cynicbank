using System;
using System.Collections.Generic;
using System.Text;
using CynicBank.Core.Interfaces;
using Models;

namespace CynicBank.Core.Implementations
{
    public class TransactionRepo : ITransactionRepo
    {
        private string AccountsPath
          = @"C:\Users\hp\source\repos\CynicBank\db\accounts.csv";

        private string TransactionsPath
         = @"C:\Users\hp\source\repos\CynicBank\db\transactions.csv";

        DbHandler<Transaction> _transactionHandler;
        DbHandler<Account> _accountsHandler;

        public TransactionRepo(DbHandler<Transaction> transactionHandler, DbHandler<Account> accooutsHandler)
        {
            _transactionHandler = transactionHandler;
            _accountsHandler = accooutsHandler;
        }

        public bool MakeDeposit(int amount, AccountType to)
        {
            var accountId = Session.LoggedInUser.Email;
            var accountsList = _accountsHandler.ReadFile(AccountsPath);

            //Check if such account exist first.
            //If not return false
            //Otherwise carryout transaction

            bool doesAccountExist =
                accountsList.Exists(x => x.Id ==  accountId && x.AccountType == to);

            if (doesAccountExist == false)
            {
                return false;
            }
            else
            {
                foreach (var item in accountsList)
                {
                    if (item.Id == Session.LoggedInUser.Email && item.AccountType == to)
                    {
                        item.AccountBalance += amount;
                    }
                }
            }

            //Append new Transaction to List
            //Update accounts File

            var generatedTransaction = new Transaction
            {
                Id = Session.LoggedInUser.Email,
                Amount = amount,
                Description = "Deposit by self",
                TypeOfTransaction = TransactionType.Credit,
            };

            _accountsHandler.Update(accountsList, AccountsPath);
            _transactionHandler.WriteToFile(generatedTransaction, TransactionsPath);

            return true;
        }

        public bool SendBetweenAccounts(AccountType from, AccountType to)
        {
            throw new NotImplementedException();
        }

        public bool SendMoney(int amount, string to)
        {
            throw new NotImplementedException();
        }

        public bool WithdrawMoney(int amount, AccountType from)
        {
            throw new NotImplementedException();
        }
    }
}
