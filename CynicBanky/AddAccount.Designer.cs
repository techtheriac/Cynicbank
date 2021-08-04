
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
            this.amountValidity = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // addAccountType
            // 
            this.addAccountType.AutoSize = true;
            this.addAccountType.Font = new System.Drawing.Font("Aribau Grotesk", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.addAccountType.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(251)))), ((int)(((byte)(236)))), ((int)(((byte)(207)))));
            this.addAccountType.Location = new System.Drawing.Point(313, 230);
            this.addAccountType.Name = "addAccountType";
            this.addAccountType.Size = new System.Drawing.Size(257, 33);
            this.addAccountType.TabIndex = 0;
            this.addAccountType.Text = "Select Account Type";
            // 
            // selectAccount
            // 
            this.selectAccount.FormattingEnabled = true;
            this.selectAccount.ItemHeight = 20;
            this.selectAccount.Items.AddRange(new object[] {
            "Current",
            "Savings"});
            this.selectAccount.Location = new System.Drawing.Point(618, 237);
            this.selectAccount.Name = "selectAccount";
            this.selectAccount.Size = new System.Drawing.Size(269, 28);
            this.selectAccount.TabIndex = 1;
            this.selectAccount.SelectedIndexChanged += new System.EventHandler(this.selectAccount_SelectedIndexChanged);
            // 
            // addInitialBalanceLabel
            // 
            this.addInitialBalanceLabel.AutoSize = true;
            this.addInitialBalanceLabel.Font = new System.Drawing.Font("Aribau Grotesk", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.addInitialBalanceLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(251)))), ((int)(((byte)(236)))), ((int)(((byte)(207)))));
            this.addInitialBalanceLabel.Location = new System.Drawing.Point(326, 351);
            this.addInitialBalanceLabel.Name = "addInitialBalanceLabel";
            this.addInitialBalanceLabel.Size = new System.Drawing.Size(182, 33);
            this.addInitialBalanceLabel.TabIndex = 2;
            this.addInitialBalanceLabel.Text = "Initial Deposit";
            // 
            // initalDepositInput
            // 
            this.initalDepositInput.BackColor = System.Drawing.Color.WhiteSmoke;
            this.initalDepositInput.Location = new System.Drawing.Point(618, 351);
            this.initalDepositInput.Multiline = true;
            this.initalDepositInput.Name = "initalDepositInput";
            this.initalDepositInput.PlaceholderText = "$0.00";
            this.initalDepositInput.Size = new System.Drawing.Size(269, 39);
            this.initalDepositInput.TabIndex = 3;
            this.initalDepositInput.TextChanged += new System.EventHandler(this.initalDepositInput_TextChanged);
            // 
            // addAccountBtn
            // 
            this.addAccountBtn.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(218)))), ((int)(((byte)(194)))));
            this.addAccountBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.addAccountBtn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(218)))), ((int)(((byte)(194)))));
            this.addAccountBtn.Location = new System.Drawing.Point(756, 466);
            this.addAccountBtn.Name = "addAccountBtn";
            this.addAccountBtn.Size = new System.Drawing.Size(131, 58);
            this.addAccountBtn.TabIndex = 4;
            this.addAccountBtn.Text = "Add";
            this.addAccountBtn.UseVisualStyleBackColor = true;
            this.addAccountBtn.Click += new System.EventHandler(this.addAccountBtn_Click);
            // 
            // amountValidity
            // 
            this.amountValidity.AutoSize = true;
            this.amountValidity.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(176)))), ((int)(((byte)(216)))), ((int)(((byte)(220)))));
            this.amountValidity.Location = new System.Drawing.Point(771, 328);
            this.amountValidity.Name = "amountValidity";
            this.amountValidity.Size = new System.Drawing.Size(116, 20);
            this.amountValidity.TabIndex = 5;
            this.amountValidity.Text = "Invalid Amount";
            this.amountValidity.Visible = false;
            // 
            // AddAccount
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(35)))), ((int)(((byte)(120)))));
            this.ClientSize = new System.Drawing.Size(1222, 806);
            this.Controls.Add(this.amountValidity);
            this.Controls.Add(this.addAccountBtn);
            this.Controls.Add(this.initalDepositInput);
            this.Controls.Add(this.addInitialBalanceLabel);
            this.Controls.Add(this.selectAccount);
            this.Controls.Add(this.addAccountType);
            this.Font = new System.Drawing.Font("Aribau Grotesk", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(1240, 853);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(1240, 853);
            this.Name = "AddAccount";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "AddAccount";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.AddAccount_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label addAccountType;
        private System.Windows.Forms.ComboBox selectAccount;
        private System.Windows.Forms.Label addInitialBalanceLabel;
        private System.Windows.Forms.TextBox initalDepositInput;
        private System.Windows.Forms.Button addAccountBtn;
        private System.Windows.Forms.Label amountValidity;
    }
}