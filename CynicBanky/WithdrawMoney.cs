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
    public partial class WithdrawMoney : Form
    {
        private AccountType _withdrawFrom;
        private int _withdrawAmount;
        public WithdrawMoney()
        {
            InitializeComponent();
        }

        private void WithdrawMoney_Load(object sender, EventArgs e)
        {

        }

        private void withdrawFrom_SelectedIndexChanged(object sender, EventArgs e)
        {
            _withdrawFrom = 
                withdrawFrom.SelectedItem.ToString() == "Current" ? 
                AccountType.Current : 
                AccountType.Savings;
        }

        private void withdrawAmountInput_TextChanged(object sender, EventArgs e)
        {
            while (withdrawAmountInput.TextLength > 0)
            {
                if (Commons.Validate.IsValidAmount(withdrawAmountInput.Text) == false)
                {
                    amountValidity.Visible = true;
                }
                else
                {
                    amountValidity.Visible = false;
                    _withdrawAmount = Commons.Validate.SafeParseInt(withdrawAmountInput.Text);
                }

                break;
            }
        }

        private void withdrawButton_Click(object sender, EventArgs e)
        {
            var transactionHandler = new TransactionRepo(new DbHandler<Transaction>(), new DbHandler<Account>());

            var status = transactionHandler.WithdrawMoney(_withdrawAmount, _withdrawFrom);

            MessageBox.Show(status);
        }
    }
}
