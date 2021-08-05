using System;
using System.Collections.Generic;
using System.Text;
using CynicBank.Core.Interfaces;
using Models;
using CynicBank.Persistence.Implementations;
using CynicBank.Persistence.Interfaces;
using CynicBank.Persistence;

namespace CynicBank.Core.Implementations
{
    public class TransactionRepo : ITransactionRepo
    {
        /// <summary>
        /// This repository has two dependencies
        /// AccountManager and TransactionManager
        /// Reads and Updates account (Debit or credit)
        /// Appends new transaction record to transaction table
        /// </summary>
        /// 

        private readonly IAccountManager _AccountManager;
        private readonly ITransactionManager _TransactionManager;

        public TransactionRepo(ITransactionManager transactionManager, IAccountManager accountManager)
        {
            _AccountManager = accountManager;
            _TransactionManager = transactionManager;
        }

        public string MakeDeposit(decimal amount, string accountNumber)
        {
            var userId = Session.LoggedInUser.Id;

            List<Account> accounts = _AccountManager.RetrieveAccounts();

            bool doesExist = accounts.Exists(x => x.UserId == userId && x.AccountNumber == accountNumber);

            if(doesExist == false)
            {
                return "Transaction failed. No such account";
            } 
            else
            {
                _AccountManager.CreditAccount(accountNumber, amount);

                var generatedTransaction = new Transaction
                {
                    Amount = amount,
                    Description = "Deposit by self",
                    TypeOfTransaction = TransactionType.Credit,
                    AccountNumber = accountNumber
                };

                var status = _TransactionManager.AddTransaction(generatedTransaction);

                return (status == true ? "Transaction successful" : "Transaction failed");
            }
        }

        public string SendMoney(decimal amount, AccountType from, string to)
        {
            throw new NotImplementedException();
        }


        public string WithdrawMoney(decimal amount, AccountType from)
        {
            string UiMessage = String.Empty;

            // Determine Withdraw rule based on account type
            Func<int, int, bool> NotAllowableAmount =
                from == AccountType.Current ?
                CurrentNotAllowableAmount :
                SavingNotAllowableAmount;

            
            var accountId = Session.LoggedInUser.Email;
      
            
            var generatedTransaction = new Transaction
            {
                Id = Session.LoggedInUser.Email,
                Amount = amount,
                Description = "Self",
                TypeOfTransaction = TransactionType.Debit,
            };

            return UiMessage;
        }

        // Either is run based on account type rules
        Func<int, int, bool> CurrentNotAllowableAmount = (amount, balance) =>
            balance < amount;
    

        Func<int, int, bool> SavingNotAllowableAmount = (amount, balance) =>
            balance <= 1000 || amount > balance;
    }
}
