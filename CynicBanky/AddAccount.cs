using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;
using CynicBank.Core.Implementations;
using Commons;
using Models;

namespace CynicBanky
{
    public partial class AddAccount : Form
    {
        private AccountType _accountType;
        private int _initialBalance;
        private string _successMessage = "Account Created Successfully";
        private string _errorMessage = "Couldn't Create Account. Account Already Exist";
        public AddAccount()
        {
            InitializeComponent();
        }

        private void AddAccount_Load(object sender, EventArgs e)
        {
            //
        }

        private void initalDepositInput_TextChanged(object sender, EventArgs e)
        {
            while (initalDepositInput.TextLength > 0)
            {
                if (Commons.Validate.IsValidAmount(initalDepositInput.Text) == false)
                {
                    amountValidity.Visible = true;
                }
                else
                {
                    amountValidity.Visible = false;
                    _initialBalance = Commons.Validate.SafeParseInt(initalDepositInput.Text);
                }

                break;
            }
        }

        private void addAccountBtn_Click(object sender, EventArgs e)
        {
            var createAccount = new AccountRepo(new DbHandler<Account>());

            if (_accountType == AccountType.Current)
            {
                var status  =
                    createAccount.CreateCurrentAccount(_initialBalance, Session.LoggedInUser);

                MessageBox.Show(status == true ? _successMessage : _errorMessage);
            }
            else
            {
                var status =
                    createAccount.CreateSavingsAccount(_initialBalance, Session.LoggedInUser);

                MessageBox.Show(status == true ? _successMessage : _errorMessage);
            }
        }

        private void selectAccount_SelectedIndexChanged(object sender, EventArgs e)
        {
            _accountType = selectAccount.SelectedItem.ToString() == "Current" ? AccountType.Current : AccountType.Savings;
        }
    }
}
