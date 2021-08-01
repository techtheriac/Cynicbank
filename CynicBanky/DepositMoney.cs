using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Models;
using Commons;
using CynicBank.Core.Implementations;

namespace CynicBanky
{
    public partial class DepositMoney : Form
    {
        private AccountType _depositTo;
        private int _depositAmount;
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

        private void DepositMoney_Load(object sender, EventArgs e)
        {
            
        }

        private void selectAccount_SelectedIndexChanged(object sender, EventArgs e)
        {
            _depositTo = selectAccount.SelectedItem.ToString() == "Current" ? AccountType.Current : AccountType.Savings;
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
            var transactionHandler = new TransactionRepo(new DbHandler<Transaction>(), new DbHandler<Account>());

            var status = transactionHandler.MakeDeposit(_depositAmount, _depositTo);

            MessageBox.Show(status);
        }
    }
}
