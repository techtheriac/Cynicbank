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

        public string MakeDeposit(int amount, AccountType to)
        {
            var accountId = Session.LoggedInUser.Email;
            var accountsList = _accountsHandler.ReadFile(AccountsPath);

            bool doesAccountExist =
                accountsList.Exists(x => x.Id ==  accountId && x.AccountType == to);

            if (doesAccountExist == false)
            {
                return "Account does not exist";
            }
            else
            {
                foreach (var item in accountsList)
                {
                    if (item.Id == accountId && item.AccountType == to)
                    {
                        item.AccountBalance += amount;
                    }
                }
            }

            var generatedTransaction = new Transaction
            {
                Id = Session.LoggedInUser.Email,
                Amount = amount,
                Description = "Deposit by self",
                TypeOfTransaction = TransactionType.Credit,
            };

            _accountsHandler.Update(accountsList, AccountsPath);
            _transactionHandler.WriteToFile(generatedTransaction, TransactionsPath);

            return "Transaction Successful";
        }

        public string SendBetweenAccounts(AccountType from, AccountType to)
        {
            throw new NotImplementedException();
        }


        public string WithdrawMoney(int amount, AccountType from)
        {
            string UiMessage = String.Empty;

            // Determine Withdraw rule based on account type
            Func<int, int, bool> NotAllowableAmount =
                from == AccountType.Current ?
                CurrentNotAllowableAmount :
                SavingNotAllowableAmount;

            
            var accountId = Session.LoggedInUser.Email;
            var accountsList = _accountsHandler.ReadFile(AccountsPath);

            bool doesAccountExist =
                accountsList.Exists(x => x.Id == accountId && x.AccountType == from);

            if(doesAccountExist == false)
            {
                return "Account does not exist";
            }
            else
            {
                foreach (var item in accountsList)
                {
                   if(item.Id == accountId && item.AccountType == from)
                    {
                        if(NotAllowableAmount(amount, item.AccountBalance) == true)
                        {
                            UiMessage = "Insufficient funds";
                            break;
                        }
                        else
                        {
                            item.AccountBalance -= amount;
                            UiMessage = "Successful";
                        }
                    }
                }
            }

            var generatedTransaction = new Transaction
            {
                Id = Session.LoggedInUser.Email,
                Amount = amount,
                Description = "Self",
                TypeOfTransaction = TransactionType.Debit,
            };

            _accountsHandler.Update(accountsList, AccountsPath);
            _transactionHandler.WriteToFile(generatedTransaction, TransactionsPath);

            return UiMessage;
        }

        Func<int, int, bool> CurrentNotAllowableAmount = (amount, balance) =>
            balance < amount;
    

        Func<int, int, bool> SavingNotAllowableAmount = (amount, balance) =>
            balance <= 1000 || amount > balance;
    }
}
