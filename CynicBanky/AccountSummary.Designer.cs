﻿
namespace CynicBanky
{
    partial class AccountSummary
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
            this.AccountDetails = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.transactionHistory = new System.Windows.Forms.Label();
            this.history = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.AccountDetails)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.history)).BeginInit();
            this.SuspendLayout();
            // 
            // AccountDetails
            // 
            this.AccountDetails.AllowUserToAddRows = false;
            this.AccountDetails.AllowUserToDeleteRows = false;
            this.AccountDetails.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.AccountDetails.Location = new System.Drawing.Point(52, 95);
            this.AccountDetails.Name = "AccountDetails";
            this.AccountDetails.ReadOnly = true;
            this.AccountDetails.RowHeadersWidth = 51;
            this.AccountDetails.RowTemplate.Height = 29;
            this.AccountDetails.Size = new System.Drawing.Size(970, 188);
            this.AccountDetails.TabIndex = 0;
            this.AccountDetails.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.AccountDetails_CellContentClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("AvenirNext LT Pro Regular", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(52, 45);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(207, 30);
            this.label1.TabIndex = 1;
            this.label1.Text = "Account Balance";
            // 
            // transactionHistory
            // 
            this.transactionHistory.AutoSize = true;
            this.transactionHistory.Font = new System.Drawing.Font("AvenirNext LT Pro Regular", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.transactionHistory.Location = new System.Drawing.Point(63, 338);
            this.transactionHistory.Name = "transactionHistory";
            this.transactionHistory.Size = new System.Drawing.Size(223, 30);
            this.transactionHistory.TabIndex = 1;
            this.transactionHistory.Text = "Tranaction History";
            // 
            // history
            // 
            this.history.AllowUserToAddRows = false;
            this.history.AllowUserToDeleteRows = false;
            this.history.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.history.Location = new System.Drawing.Point(63, 405);
            this.history.Name = "history";
            this.history.ReadOnly = true;
            this.history.RowHeadersWidth = 51;
            this.history.RowTemplate.Height = 29;
            this.history.Size = new System.Drawing.Size(959, 188);
            this.history.TabIndex = 2;
            // 
            // AccountSummary
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1094, 508);
            this.Controls.Add(this.history);
            this.Controls.Add(this.transactionHistory);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.AccountDetails);
            this.Name = "AccountSummary";
            this.Text = "AccountSummary";
            this.Load += new System.EventHandler(this.AccountSummary_Load);
            ((System.ComponentModel.ISupportInitialize)(this.AccountDetails)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.history)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView AccountDetails;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label transactionHistory;
        private System.Windows.Forms.DataGridView history;
    }
}