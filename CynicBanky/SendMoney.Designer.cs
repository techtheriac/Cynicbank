
namespace CynicBanky
{
    partial class SendMoney
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
            this.sendFromLabel = new System.Windows.Forms.Label();
            this.sendToLabel = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.sendMoneyBtn = new System.Windows.Forms.Button();
            this.sendAmountLabel = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // sendFromLabel
            // 
            this.sendFromLabel.AutoSize = true;
            this.sendFromLabel.Location = new System.Drawing.Point(90, 81);
            this.sendFromLabel.Name = "sendFromLabel";
            this.sendFromLabel.Size = new System.Drawing.Size(43, 20);
            this.sendFromLabel.TabIndex = 0;
            this.sendFromLabel.Text = "From";
            // 
            // sendToLabel
            // 
            this.sendToLabel.AutoSize = true;
            this.sendToLabel.Location = new System.Drawing.Point(90, 170);
            this.sendToLabel.Name = "sendToLabel";
            this.sendToLabel.Size = new System.Drawing.Size(25, 20);
            this.sendToLabel.TabIndex = 0;
            this.sendToLabel.Text = "To";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Current",
            "Savings"});
            this.comboBox1.Location = new System.Drawing.Point(260, 78);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(151, 28);
            this.comboBox1.TabIndex = 1;
            // 
            // comboBox2
            // 
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Items.AddRange(new object[] {
            "Current",
            "Savings"});
            this.comboBox2.Location = new System.Drawing.Point(260, 170);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(151, 28);
            this.comboBox2.TabIndex = 1;
            // 
            // sendMoneyBtn
            // 
            this.sendMoneyBtn.Location = new System.Drawing.Point(317, 333);
            this.sendMoneyBtn.Name = "sendMoneyBtn";
            this.sendMoneyBtn.Size = new System.Drawing.Size(94, 29);
            this.sendMoneyBtn.TabIndex = 2;
            this.sendMoneyBtn.Text = "Send";
            this.sendMoneyBtn.UseVisualStyleBackColor = true;
            // 
            // sendAmountLabel
            // 
            this.sendAmountLabel.AutoSize = true;
            this.sendAmountLabel.Location = new System.Drawing.Point(90, 262);
            this.sendAmountLabel.Name = "sendAmountLabel";
            this.sendAmountLabel.Size = new System.Drawing.Size(62, 20);
            this.sendAmountLabel.TabIndex = 0;
            this.sendAmountLabel.Text = "Amount";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(260, 262);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(151, 27);
            this.textBox1.TabIndex = 3;
            // 
            // SendMoney
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.sendMoneyBtn);
            this.Controls.Add(this.comboBox2);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.sendAmountLabel);
            this.Controls.Add(this.sendToLabel);
            this.Controls.Add(this.sendFromLabel);
            this.Name = "SendMoney";
            this.Text = "SendMoney";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label sendFromLabel;
        private System.Windows.Forms.Label sendToLabel;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.Button sendMoneyBtn;
        private System.Windows.Forms.Label sendAmountLabel;
        private System.Windows.Forms.TextBox textBox1;
    }
}