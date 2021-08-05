
namespace CynicBanky
{
    partial class DepositMoney
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
            this.depositToLabel = new System.Windows.Forms.Label();
            this.selectAccount = new System.Windows.Forms.ComboBox();
            this.depositAmountLabel = new System.Windows.Forms.Label();
            this.depositAmountInput = new System.Windows.Forms.TextBox();
            this.depositMoneyBtn = new System.Windows.Forms.Button();
            this.amountValidity = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // depositToLabel
            // 
            this.depositToLabel.AutoSize = true;
            this.depositToLabel.Font = new System.Drawing.Font("Aribau Grotesk", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.depositToLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(251)))), ((int)(((byte)(236)))), ((int)(((byte)(207)))));
            this.depositToLabel.Location = new System.Drawing.Point(312, 230);
            this.depositToLabel.Name = "depositToLabel";
            this.depositToLabel.Size = new System.Drawing.Size(43, 33);
            this.depositToLabel.TabIndex = 0;
            this.depositToLabel.Text = "To";
            this.depositToLabel.Click += new System.EventHandler(this.label1_Click);
            // 
            // selectAccount
            // 
            this.selectAccount.FormattingEnabled = true;
            this.selectAccount.Location = new System.Drawing.Point(504, 235);
            this.selectAccount.Name = "selectAccount";
            this.selectAccount.Size = new System.Drawing.Size(306, 28);
            this.selectAccount.TabIndex = 1;
            this.selectAccount.SelectedIndexChanged += new System.EventHandler(this.selectAccount_SelectedIndexChanged);
            // 
            // depositAmountLabel
            // 
            this.depositAmountLabel.AutoSize = true;
            this.depositAmountLabel.Font = new System.Drawing.Font("Aribau Grotesk", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.depositAmountLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(251)))), ((int)(((byte)(236)))), ((int)(((byte)(207)))));
            this.depositAmountLabel.Location = new System.Drawing.Point(312, 369);
            this.depositAmountLabel.Name = "depositAmountLabel";
            this.depositAmountLabel.Size = new System.Drawing.Size(110, 33);
            this.depositAmountLabel.TabIndex = 2;
            this.depositAmountLabel.Text = "Amount";
            this.depositAmountLabel.Click += new System.EventHandler(this.depositAmountLabel_Click);
            // 
            // depositAmountInput
            // 
            this.depositAmountInput.Location = new System.Drawing.Point(504, 362);
            this.depositAmountInput.Multiline = true;
            this.depositAmountInput.Name = "depositAmountInput";
            this.depositAmountInput.Size = new System.Drawing.Size(306, 46);
            this.depositAmountInput.TabIndex = 3;
            this.depositAmountInput.TextChanged += new System.EventHandler(this.depositAmountInput_TextChanged);
            // 
            // depositMoneyBtn
            // 
            this.depositMoneyBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.depositMoneyBtn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(218)))), ((int)(((byte)(194)))));
            this.depositMoneyBtn.Location = new System.Drawing.Point(674, 479);
            this.depositMoneyBtn.Name = "depositMoneyBtn";
            this.depositMoneyBtn.Size = new System.Drawing.Size(136, 70);
            this.depositMoneyBtn.TabIndex = 4;
            this.depositMoneyBtn.Text = "Deposit";
            this.depositMoneyBtn.UseVisualStyleBackColor = true;
            this.depositMoneyBtn.Click += new System.EventHandler(this.depositMoneyBtn_Click);
            // 
            // amountValidity
            // 
            this.amountValidity.AutoSize = true;
            this.amountValidity.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.amountValidity.Location = new System.Drawing.Point(690, 335);
            this.amountValidity.Name = "amountValidity";
            this.amountValidity.Size = new System.Drawing.Size(116, 20);
            this.amountValidity.TabIndex = 5;
            this.amountValidity.Text = "Invalid Amount";
            this.amountValidity.Visible = false;
            // 
            // DepositMoney
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(35)))), ((int)(((byte)(120)))));
            this.ClientSize = new System.Drawing.Size(1222, 806);
            this.Controls.Add(this.amountValidity);
            this.Controls.Add(this.depositMoneyBtn);
            this.Controls.Add(this.depositAmountInput);
            this.Controls.Add(this.depositAmountLabel);
            this.Controls.Add(this.selectAccount);
            this.Controls.Add(this.depositToLabel);
            this.Font = new System.Drawing.Font("Aribau Grotesk", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.MaximumSize = new System.Drawing.Size(1240, 853);
            this.MinimumSize = new System.Drawing.Size(1240, 853);
            this.Name = "DepositMoney";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "DepositMoney";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.DepositMoney_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label depositToLabel;
        private System.Windows.Forms.ComboBox selectAccount;
        private System.Windows.Forms.Label depositAmountLabel;
        private System.Windows.Forms.TextBox depositAmountInput;
        private System.Windows.Forms.Button depositMoneyBtn;
        private System.Windows.Forms.Label amountValidity;
    }
}