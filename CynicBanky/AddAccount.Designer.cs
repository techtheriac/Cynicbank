
namespace CynicBanky
{
    partial class AddAccount
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
            this.addAccountType = new System.Windows.Forms.Label();
            this.selectAccount = new System.Windows.Forms.ComboBox();
            this.addInitialBalanceLabel = new System.Windows.Forms.Label();
            this.initalDepositInput = new System.Windows.Forms.TextBox();
            this.addAccountBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // addAccountType
            // 
            this.addAccountType.AutoSize = true;
            this.addAccountType.Location = new System.Drawing.Point(78, 102);
            this.addAccountType.Name = "addAccountType";
            this.addAccountType.Size = new System.Drawing.Size(142, 20);
            this.addAccountType.TabIndex = 0;
            this.addAccountType.Text = "Select Account Type";
            // 
            // selectAccount
            // 
            this.selectAccount.FormattingEnabled = true;
            this.selectAccount.Items.AddRange(new object[] {
            "Current",
            "Savings"});
            this.selectAccount.Location = new System.Drawing.Point(298, 94);
            this.selectAccount.Name = "selectAccount";
            this.selectAccount.Size = new System.Drawing.Size(151, 28);
            this.selectAccount.TabIndex = 1;
            // 
            // addInitialBalanceLabel
            // 
            this.addInitialBalanceLabel.AutoSize = true;
            this.addInitialBalanceLabel.Location = new System.Drawing.Point(90, 187);
            this.addInitialBalanceLabel.Name = "addInitialBalanceLabel";
            this.addInitialBalanceLabel.Size = new System.Drawing.Size(102, 20);
            this.addInitialBalanceLabel.TabIndex = 2;
            this.addInitialBalanceLabel.Text = "Initial Deposit";
            // 
            // initalDepositInput
            // 
            this.initalDepositInput.Location = new System.Drawing.Point(298, 184);
            this.initalDepositInput.Name = "initalDepositInput";
            this.initalDepositInput.Size = new System.Drawing.Size(151, 27);
            this.initalDepositInput.TabIndex = 3;
            // 
            // addAccountBtn
            // 
            this.addAccountBtn.Location = new System.Drawing.Point(354, 290);
            this.addAccountBtn.Name = "addAccountBtn";
            this.addAccountBtn.Size = new System.Drawing.Size(94, 29);
            this.addAccountBtn.TabIndex = 4;
            this.addAccountBtn.Text = "Add";
            this.addAccountBtn.UseVisualStyleBackColor = true;
            // 
            // AddAccount
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.addAccountBtn);
            this.Controls.Add(this.initalDepositInput);
            this.Controls.Add(this.addInitialBalanceLabel);
            this.Controls.Add(this.selectAccount);
            this.Controls.Add(this.addAccountType);
            this.Name = "AddAccount";
            this.Text = "AddAccount";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label addAccountType;
        private System.Windows.Forms.ComboBox selectAccount;
        private System.Windows.Forms.Label addInitialBalanceLabel;
        private System.Windows.Forms.TextBox initalDepositInput;
        private System.Windows.Forms.Button addAccountBtn;
    }
}