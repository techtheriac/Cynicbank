using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Commons;

namespace CynicBanky
{
    public partial class Menu : Form
    {
        public Menu()
        {
            InitializeComponent();
        }

        private void sendMoneyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SendMoney sendMoney = new SendMoney();
            sendMoney.MdiParent = this;
            sendMoney.Show();
        }

        private void withdrawMoneyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            WithdrawMoney withdrawMoney = new WithdrawMoney();
            withdrawMoney.MdiParent = this;
            withdrawMoney.Show();
        }

        private void depositCashToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DepositMoney depositMoney = new DepositMoney();
            depositMoney.MdiParent = this;
            depositMoney.Show();
        }

        private void logoutToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void addAccountToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddAccount addAccount = new AddAccount();
            addAccount.MdiParent = this;
            addAccount.Show();
        }

        private void Menu_Load(object sender, EventArgs e)
        {
            Dashboard dashboard = new Dashboard();
            dashboard.MdiParent = this;
            dashboard.Show();
        }

        private void accountSummaryToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AccountSummary accountSummary = new AccountSummary();
            accountSummary.MdiParent = this;
            accountSummary.Show();
        }
    }
}
