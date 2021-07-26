
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
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.depositAmountLabel = new System.Windows.Forms.Label();
            this.depositAmountInput = new System.Windows.Forms.TextBox();
            this.depositMoneyBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // depositToLabel
            // 
            this.depositToLabel.AutoSize = true;
            this.depositToLabel.Location = new System.Drawing.Point(66, 75);
            this.depositToLabel.Name = "depositToLabel";
            this.depositToLabel.Size = new System.Drawing.Size(25, 20);
            this.depositToLabel.TabIndex = 0;
            this.depositToLabel.Text = "To";
            this.depositToLabel.Click += new System.EventHandler(this.label1_Click);
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Savings",
            "Current"});
            this.comboBox1.Location = new System.Drawing.Point(174, 75);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(151, 28);
            this.comboBox1.TabIndex = 1;
            // 
            // depositAmountLabel
            // 
            this.depositAmountLabel.AutoSize = true;
            this.depositAmountLabel.Location = new System.Drawing.Point(66, 144);
            this.depositAmountLabel.Name = "depositAmountLabel";
            this.depositAmountLabel.Size = new System.Drawing.Size(62, 20);
            this.depositAmountLabel.TabIndex = 2;
            this.depositAmountLabel.Text = "Amount";
            this.depositAmountLabel.Click += new System.EventHandler(this.depositAmountLabel_Click);
            // 
            // depositAmountInput
            // 
            this.depositAmountInput.Location = new System.Drawing.Point(174, 137);
            this.depositAmountInput.Name = "depositAmountInput";
            this.depositAmountInput.Size = new System.Drawing.Size(151, 27);
            this.depositAmountInput.TabIndex = 3;
            // 
            // depositMoneyBtn
            // 
            this.depositMoneyBtn.Location = new System.Drawing.Point(230, 233);
            this.depositMoneyBtn.Name = "depositMoneyBtn";
            this.depositMoneyBtn.Size = new System.Drawing.Size(94, 29);
            this.depositMoneyBtn.TabIndex = 4;
            this.depositMoneyBtn.Text = "Deposit";
            this.depositMoneyBtn.UseVisualStyleBackColor = true;
            // 
            // DepositMoney
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.depositMoneyBtn);
            this.Controls.Add(this.depositAmountInput);
            this.Controls.Add(this.depositAmountLabel);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.depositToLabel);
            this.Name = "DepositMoney";
            this.Text = "DepositMoney";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.DepositMoney_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label depositToLabel;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label depositAmountLabel;
        private System.Windows.Forms.TextBox depositAmountInput;
        private System.Windows.Forms.Button depositMoneyBtn;
    }
}