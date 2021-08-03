using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using CynicBank.Core.Implementations;
using Models;

namespace CynicBanky
{
    public partial class AccountSummary : Form
    {
        private string AccountsPath
        = @"C:\Users\hp\source\repos\CynicBank\db\accounts.csv";
        private string TransactionsPath
        = @"C:\Users\hp\source\repos\CynicBank\db\transactions.csv";

        public AccountSummary()
        {
            InitializeComponent();
        }

        private void AccountDetails_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void AccountSummary_Load(object sender, EventArgs e)
        {

            DbHandler<Account> Finder = new DbHandler<Account>();
            DbHandler<Transaction> Finder1 = new DbHandler<Transaction>();
            var accountList = Finder.ReadFile(AccountsPath);
            var transactionsList = Finder1.ReadFile(TransactionsPath);



            DataTable table = new DataTable();
            table.Columns.Add("Account Number", typeof(string));
            table.Columns.Add("Account Type", typeof(string));
            table.Columns.Add("Account Balance", typeof(int));

            foreach (var item in accountList)
            {
                if(item.Id == Session.LoggedInUser.Email)
                {
                    table.Rows.Add(item.AccountNumber, item.AccountType, item.AccountBalance);
                }
            }

            AccountDetails.DataSource = table;

            DataTable table1 = new DataTable();
            table1.Columns.Add("Date");
            table1.Columns.Add("Description", typeof(string));
            table1.Columns.Add("Amount");
            table1.Columns.Add("Type");

            foreach (var item in transactionsList)
            {
                if(item.Id == Session.LoggedInUser.Email)
                {
                    table1.Rows.Add(item.CreatedAt, item.Description, item.Amount, item.TypeOfTransaction);
                }
            }

            history.DataSource = table1;


        }
    }
}
