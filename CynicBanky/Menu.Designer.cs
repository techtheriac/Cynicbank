
namespace CynicBanky
{
    partial class Menu
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.accountToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addAccountToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.transactionsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sendMoneyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.withdrawMoneyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.depositCashToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.miscToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.logoutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.accountSummaryToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.accountToolStripMenuItem,
            this.transactionsToolStripMenuItem,
            this.miscToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(7, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(900, 28);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // accountToolStripMenuItem
            // 
            this.accountToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addAccountToolStripMenuItem,
            this.accountSummaryToolStripMenuItem});
            this.accountToolStripMenuItem.Name = "accountToolStripMenuItem";
            this.accountToolStripMenuItem.Size = new System.Drawing.Size(77, 24);
            this.accountToolStripMenuItem.Text = "Account";
            // 
            // addAccountToolStripMenuItem
            // 
            this.addAccountToolStripMenuItem.Name = "addAccountToolStripMenuItem";
            this.addAccountToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.addAccountToolStripMenuItem.Text = "Add Account";
            this.addAccountToolStripMenuItem.Click += new System.EventHandler(this.addAccountToolStripMenuItem_Click);
            // 
            // transactionsToolStripMenuItem
            // 
            this.transactionsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.sendMoneyToolStripMenuItem,
            this.withdrawMoneyToolStripMenuItem,
            this.depositCashToolStripMenuItem});
            this.transactionsToolStripMenuItem.Name = "transactionsToolStripMenuItem";
            this.transactionsToolStripMenuItem.Size = new System.Drawing.Size(104, 24);
            this.transactionsToolStripMenuItem.Text = "Transactions";
            // 
            // sendMoneyToolStripMenuItem
            // 
            this.sendMoneyToolStripMenuItem.Name = "sendMoneyToolStripMenuItem";
            this.sendMoneyToolStripMenuItem.Size = new System.Drawing.Size(205, 26);
            this.sendMoneyToolStripMenuItem.Text = "Send Money";
            this.sendMoneyToolStripMenuItem.Click += new System.EventHandler(this.sendMoneyToolStripMenuItem_Click);
            // 
            // withdrawMoneyToolStripMenuItem
            // 
            this.withdrawMoneyToolStripMenuItem.Name = "withdrawMoneyToolStripMenuItem";
            this.withdrawMoneyToolStripMenuItem.Size = new System.Drawing.Size(205, 26);
            this.withdrawMoneyToolStripMenuItem.Text = "Withdraw Money";
            this.withdrawMoneyToolStripMenuItem.Click += new System.EventHandler(this.withdrawMoneyToolStripMenuItem_Click);
            // 
            // depositCashToolStripMenuItem
            // 
            this.depositCashToolStripMenuItem.Name = "depositCashToolStripMenuItem";
            this.depositCashToolStripMenuItem.Size = new System.Drawing.Size(205, 26);
            this.depositCashToolStripMenuItem.Text = "Deposit Cash";
            this.depositCashToolStripMenuItem.Click += new System.EventHandler(this.depositCashToolStripMenuItem_Click);
            // 
            // miscToolStripMenuItem
            // 
            this.miscToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.logoutToolStripMenuItem});
            this.miscToolStripMenuItem.Name = "miscToolStripMenuItem";
            this.miscToolStripMenuItem.Size = new System.Drawing.Size(53, 24);
            this.miscToolStripMenuItem.Text = "Misc";
            // 
            // logoutToolStripMenuItem
            // 
            this.logoutToolStripMenuItem.Name = "logoutToolStripMenuItem";
            this.logoutToolStripMenuItem.Size = new System.Drawing.Size(139, 26);
            this.logoutToolStripMenuItem.Text = "Logout";
            this.logoutToolStripMenuItem.Click += new System.EventHandler(this.logoutToolStripMenuItem_Click);
            // 
            // accountSummaryToolStripMenuItem
            // 
            this.accountSummaryToolStripMenuItem.Name = "accountSummaryToolStripMenuItem";
            this.accountSummaryToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.accountSummaryToolStripMenuItem.Text = "Account Summary";
            this.accountSummaryToolStripMenuItem.Click += new System.EventHandler(this.accountSummaryToolStripMenuItem_Click);
            // 
            // Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(900, 405);
            this.Controls.Add(this.menuStrip1);
            this.Font = new System.Drawing.Font("Avenir LT Std 55 Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Menu";
            this.Text = "Menu";
            this.Load += new System.EventHandler(this.Menu_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem accountToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addAccountToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem transactionsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sendMoneyToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem withdrawMoneyToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem depositCashToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem miscToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem logoutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem accountSummaryToolStripMenuItem;
    }
}