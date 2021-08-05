using System;
using System.Windows.Forms;
using System.Collections.Generic;
using System.Collections;
using Models;
using CynicBank.Core.Implementations;
using CynicBank.Persistence.Implementations;
using CynicBank.Persistence.Interfaces;
using CynicBank.Persistence;

namespace CynicBanky
{
    public partial class DepositMoney : Form
    {
        private string _depositTo;
        private int _depositAmount;
        private List<Account> UserAccounts;
        
        public DepositMoney()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void depositAmountLabel_Click(object sender, EventArgs e)
        {

        }
        /// <summary>
        /// populates select acount combo with logged in user
        /// Account Number
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void DepositMoney_Load(object sender, EventArgs e)
        {
            UserAccounts = Session.GetLoggedInUserAccounts();

            foreach (var item in UserAccounts)
            {
                selectAccount.Items.Add(item.AccountNumber);
            }
        }

        private void selectAccount_SelectedIndexChanged(object sender, EventArgs e)
        {
            _depositTo = selectAccount.SelectedItem.ToString();
        }

        private void depositAmountInput_TextChanged(object sender, EventArgs e)
        {
            while (depositAmountInput.TextLength > 0)
            {
                if (Commons.Validate.IsValidAmount(depositAmountInput.Text) == false)
                {
                    amountValidity.Visible = true;
                }
                else
                {
                    amountValidity.Visible = false;
                    _depositAmount = Commons.Validate.SafeParseInt(depositAmountInput.Text);
                }

                break;
            }
        }

        private void depositMoneyBtn_Click(object sender, EventArgs e)
        {
            var transactionHandler = new TransactionRepo(new TransactionManager(), new AccountManager());

            var status = transactionHandler.MakeDeposit(_depositAmount, _depositTo);

            MessageBox.Show(status);
        }
    }
}
