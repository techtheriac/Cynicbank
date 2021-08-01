
namespace CynicBanky
{
    partial class WithdrawMoney
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
            this.withdrawFromLabel = new System.Windows.Forms.Label();
            this.withdrawFrom = new System.Windows.Forms.ComboBox();
            this.withdrawAmountLabel = new System.Windows.Forms.Label();
            this.withdrawAmountInput = new System.Windows.Forms.TextBox();
            this.amountValidity = new System.Windows.Forms.Label();
            this.withdrawButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // withdrawFromLabel
            // 
            this.withdrawFromLabel.AutoSize = true;
            this.withdrawFromLabel.Location = new System.Drawing.Point(56, 61);
            this.withdrawFromLabel.Name = "withdrawFromLabel";
            this.withdrawFromLabel.Size = new System.Drawing.Size(43, 20);
            this.withdrawFromLabel.TabIndex = 0;
            this.withdrawFromLabel.Text = "From";
            // 
            // withdrawFrom
            // 
            this.withdrawFrom.FormattingEnabled = true;
            this.withdrawFrom.Items.AddRange(new object[] {
            "Current",
            "Savings"});
            this.withdrawFrom.Location = new System.Drawing.Point(163, 61);
            this.withdrawFrom.Name = "withdrawFrom";
            this.withdrawFrom.Size = new System.Drawing.Size(196, 28);
            this.withdrawFrom.TabIndex = 1;
            this.withdrawFrom.SelectedIndexChanged += new System.EventHandler(this.withdrawFrom_SelectedIndexChanged);
            // 
            // withdrawAmountLabel
            // 
            this.withdrawAmountLabel.AutoSize = true;
            this.withdrawAmountLabel.Location = new System.Drawing.Point(56, 189);
            this.withdrawAmountLabel.Name = "withdrawAmountLabel";
            this.withdrawAmountLabel.Size = new System.Drawing.Size(62, 20);
            this.withdrawAmountLabel.TabIndex = 0;
            this.withdrawAmountLabel.Text = "Amount";
            // 
            // withdrawAmountInput
            // 
            this.withdrawAmountInput.Location = new System.Drawing.Point(163, 182);
            this.withdrawAmountInput.Name = "withdrawAmountInput";
            this.withdrawAmountInput.Size = new System.Drawing.Size(196, 27);
            this.withdrawAmountInput.TabIndex = 2;
            this.withdrawAmountInput.TextChanged += new System.EventHandler(this.withdrawAmountInput_TextChanged);
            // 
            // amountValidity
            // 
            this.amountValidity.AutoSize = true;
            this.amountValidity.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.amountValidity.Location = new System.Drawing.Point(249, 150);
            this.amountValidity.Name = "amountValidity";
            this.amountValidity.Size = new System.Drawing.Size(110, 20);
            this.amountValidity.TabIndex = 3;
            this.amountValidity.Text = "Invalid Amount";
            this.amountValidity.Visible = false;
            // 
            // withdrawButton
            // 
            this.withdrawButton.Location = new System.Drawing.Point(264, 282);
            this.withdrawButton.Name = "withdrawButton";
            this.withdrawButton.Size = new System.Drawing.Size(94, 29);
            this.withdrawButton.TabIndex = 4;
            this.withdrawButton.Text = "Withdraw";
            this.withdrawButton.UseVisualStyleBackColor = true;
            this.withdrawButton.Click += new System.EventHandler(this.withdrawButton_Click);
            // 
            // WithdrawMoney
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.withdrawButton);
            this.Controls.Add(this.amountValidity);
            this.Controls.Add(this.withdrawAmountInput);
            this.Controls.Add(this.withdrawFrom);
            this.Controls.Add(this.withdrawAmountLabel);
            this.Controls.Add(this.withdrawFromLabel);
            this.Name = "WithdrawMoney";
            this.Text = "WithdrawMoney";
            this.Load += new System.EventHandler(this.WithdrawMoney_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label withdrawFromLabel;
        private System.Windows.Forms.ComboBox withdrawFrom;
        private System.Windows.Forms.Label withdrawAmountLabel;
        private System.Windows.Forms.TextBox withdrawAmountInput;
        private System.Windows.Forms.Label amountValidity;
        private System.Windows.Forms.Button withdrawButton;
    }
}