
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
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.withdrawAmountLabel = new System.Windows.Forms.Label();
            this.withdrawAmountInput = new System.Windows.Forms.TextBox();
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
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Current",
            "Savings"});
            this.comboBox1.Location = new System.Drawing.Point(163, 61);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(151, 28);
            this.comboBox1.TabIndex = 1;
            // 
            // withdrawAmountLabel
            // 
            this.withdrawAmountLabel.AutoSize = true;
            this.withdrawAmountLabel.Location = new System.Drawing.Point(56, 165);
            this.withdrawAmountLabel.Name = "withdrawAmountLabel";
            this.withdrawAmountLabel.Size = new System.Drawing.Size(62, 20);
            this.withdrawAmountLabel.TabIndex = 0;
            this.withdrawAmountLabel.Text = "Amount";
            // 
            // withdrawAmountInput
            // 
            this.withdrawAmountInput.Location = new System.Drawing.Point(163, 158);
            this.withdrawAmountInput.Name = "withdrawAmountInput";
            this.withdrawAmountInput.Size = new System.Drawing.Size(151, 27);
            this.withdrawAmountInput.TabIndex = 2;
            // 
            // WithdrawMoney
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.withdrawAmountInput);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.withdrawAmountLabel);
            this.Controls.Add(this.withdrawFromLabel);
            this.Name = "WithdrawMoney";
            this.Text = "WithdrawMoney";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label withdrawFromLabel;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label withdrawAmountLabel;
        private System.Windows.Forms.TextBox withdrawAmountInput;
    }
}