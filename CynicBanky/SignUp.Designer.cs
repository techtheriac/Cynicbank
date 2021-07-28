
namespace CynicBanky
{
    partial class SignUp
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
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.choosePassword = new System.Windows.Forms.TextBox();
            this.confirmPassword = new System.Windows.Forms.TextBox();
            this.signupBtn = new System.Windows.Forms.Button();
            this.loginLinkbtn = new System.Windows.Forms.Button();
            this.emailInput = new System.Windows.Forms.TextBox();
            this.lastNameInput = new System.Windows.Forms.TextBox();
            this.passwordValidity1 = new System.Windows.Forms.Label();
            this.emailValidity = new System.Windows.Forms.Label();
            this.firstNameInput = new System.Windows.Forms.TextBox();
            this.confirmPasswordLabel = new System.Windows.Forms.Label();
            this.lastNameValidity = new System.Windows.Forms.Label();
            this.passwordLabel = new System.Windows.Forms.Label();
            this.emailLabel = new System.Windows.Forms.Label();
            this.firstNameValidity = new System.Windows.Forms.Label();
            this.lastNameLabel = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.firstNameLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            this.splitContainer1.Cursor = System.Windows.Forms.Cursors.VSplit;
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.choosePassword);
            this.splitContainer1.Panel2.Controls.Add(this.confirmPassword);
            this.splitContainer1.Panel2.Controls.Add(this.signupBtn);
            this.splitContainer1.Panel2.Controls.Add(this.loginLinkbtn);
            this.splitContainer1.Panel2.Controls.Add(this.emailInput);
            this.splitContainer1.Panel2.Controls.Add(this.lastNameInput);
            this.splitContainer1.Panel2.Controls.Add(this.passwordValidity1);
            this.splitContainer1.Panel2.Controls.Add(this.emailValidity);
            this.splitContainer1.Panel2.Controls.Add(this.firstNameInput);
            this.splitContainer1.Panel2.Controls.Add(this.confirmPasswordLabel);
            this.splitContainer1.Panel2.Controls.Add(this.lastNameValidity);
            this.splitContainer1.Panel2.Controls.Add(this.passwordLabel);
            this.splitContainer1.Panel2.Controls.Add(this.emailLabel);
            this.splitContainer1.Panel2.Controls.Add(this.firstNameValidity);
            this.splitContainer1.Panel2.Controls.Add(this.lastNameLabel);
            this.splitContainer1.Panel2.Controls.Add(this.label1);
            this.splitContainer1.Panel2.Controls.Add(this.firstNameLabel);
            this.splitContainer1.Size = new System.Drawing.Size(1240, 670);
            this.splitContainer1.SplitterDistance = 312;
            this.splitContainer1.TabIndex = 0;
            // 
            // choosePassword
            // 
            this.choosePassword.Location = new System.Drawing.Point(107, 462);
            this.choosePassword.Name = "choosePassword";
            this.choosePassword.Size = new System.Drawing.Size(329, 27);
            this.choosePassword.TabIndex = 4;
            this.choosePassword.TextChanged += new System.EventHandler(this.choosePassword_TextChanged);
            // 
            // confirmPassword
            // 
            this.confirmPassword.Location = new System.Drawing.Point(107, 558);
            this.confirmPassword.Name = "confirmPassword";
            this.confirmPassword.Size = new System.Drawing.Size(329, 27);
            this.confirmPassword.TabIndex = 3;
            this.confirmPassword.TextChanged += new System.EventHandler(this.confirmPassword_TextChanged);
            // 
            // signupBtn
            // 
            this.signupBtn.Location = new System.Drawing.Point(342, 613);
            this.signupBtn.Name = "signupBtn";
            this.signupBtn.Size = new System.Drawing.Size(94, 29);
            this.signupBtn.TabIndex = 2;
            this.signupBtn.Text = "Sign Up";
            this.signupBtn.UseVisualStyleBackColor = true;
            this.signupBtn.Click += new System.EventHandler(this.signupBtn_Click);
            // 
            // loginLinkbtn
            // 
            this.loginLinkbtn.Location = new System.Drawing.Point(699, 136);
            this.loginLinkbtn.Name = "loginLinkbtn";
            this.loginLinkbtn.Size = new System.Drawing.Size(94, 29);
            this.loginLinkbtn.TabIndex = 2;
            this.loginLinkbtn.Text = "Log in";
            this.loginLinkbtn.UseVisualStyleBackColor = true;
            this.loginLinkbtn.Click += new System.EventHandler(this.loginLinkbtn_Click);
            // 
            // emailInput
            // 
            this.emailInput.Location = new System.Drawing.Point(107, 355);
            this.emailInput.Name = "emailInput";
            this.emailInput.PlaceholderText = "johndoe@gmail.com";
            this.emailInput.Size = new System.Drawing.Size(329, 27);
            this.emailInput.TabIndex = 1;
            this.emailInput.TextChanged += new System.EventHandler(this.emailInput_TextChanged);
            // 
            // lastNameInput
            // 
            this.lastNameInput.Location = new System.Drawing.Point(107, 244);
            this.lastNameInput.Name = "lastNameInput";
            this.lastNameInput.Size = new System.Drawing.Size(329, 27);
            this.lastNameInput.TabIndex = 1;
            this.lastNameInput.TextChanged += new System.EventHandler(this.lastNameInput_TextChanged);
            // 
            // passwordValidity1
            // 
            this.passwordValidity1.AutoSize = true;
            this.passwordValidity1.Location = new System.Drawing.Point(283, 513);
            this.passwordValidity1.Name = "passwordValidity1";
            this.passwordValidity1.Size = new System.Drawing.Size(153, 20);
            this.passwordValidity1.TabIndex = 0;
            this.passwordValidity1.Text = "Password don\'t match";
            this.passwordValidity1.Visible = false;
            // 
            // emailValidity
            // 
            this.emailValidity.AutoSize = true;
            this.emailValidity.Location = new System.Drawing.Point(316, 311);
            this.emailValidity.Name = "emailValidity";
            this.emailValidity.Size = new System.Drawing.Size(120, 20);
            this.emailValidity.TabIndex = 0;
            this.emailValidity.Text = "Enter valid Email";
            this.emailValidity.Visible = false;
            // 
            // firstNameInput
            // 
            this.firstNameInput.Location = new System.Drawing.Point(107, 136);
            this.firstNameInput.Name = "firstNameInput";
            this.firstNameInput.Size = new System.Drawing.Size(329, 27);
            this.firstNameInput.TabIndex = 1;
            this.firstNameInput.TextChanged += new System.EventHandler(this.firstNameInput_TextChanged);
            // 
            // confirmPasswordLabel
            // 
            this.confirmPasswordLabel.AutoSize = true;
            this.confirmPasswordLabel.Location = new System.Drawing.Point(107, 513);
            this.confirmPasswordLabel.Name = "confirmPasswordLabel";
            this.confirmPasswordLabel.Size = new System.Drawing.Size(129, 20);
            this.confirmPasswordLabel.TabIndex = 0;
            this.confirmPasswordLabel.Text = "Confirm password";
            // 
            // lastNameValidity
            // 
            this.lastNameValidity.AutoSize = true;
            this.lastNameValidity.Location = new System.Drawing.Point(316, 200);
            this.lastNameValidity.Name = "lastNameValidity";
            this.lastNameValidity.Size = new System.Drawing.Size(120, 20);
            this.lastNameValidity.TabIndex = 0;
            this.lastNameValidity.Text = "Enter valid name";
            this.lastNameValidity.Visible = false;
            // 
            // passwordLabel
            // 
            this.passwordLabel.AutoSize = true;
            this.passwordLabel.Location = new System.Drawing.Point(107, 421);
            this.passwordLabel.Name = "passwordLabel";
            this.passwordLabel.Size = new System.Drawing.Size(129, 20);
            this.passwordLabel.TabIndex = 0;
            this.passwordLabel.Text = "Choose  password";
            // 
            // emailLabel
            // 
            this.emailLabel.AutoSize = true;
            this.emailLabel.Location = new System.Drawing.Point(107, 311);
            this.emailLabel.Name = "emailLabel";
            this.emailLabel.Size = new System.Drawing.Size(46, 20);
            this.emailLabel.TabIndex = 0;
            this.emailLabel.Text = "Email";
            // 
            // firstNameValidity
            // 
            this.firstNameValidity.AutoSize = true;
            this.firstNameValidity.Location = new System.Drawing.Point(316, 92);
            this.firstNameValidity.Name = "firstNameValidity";
            this.firstNameValidity.Size = new System.Drawing.Size(120, 20);
            this.firstNameValidity.TabIndex = 0;
            this.firstNameValidity.Text = "Enter valid name";
            this.firstNameValidity.Visible = false;
            this.firstNameValidity.Click += new System.EventHandler(this.firstNameValidity_Click);
            // 
            // lastNameLabel
            // 
            this.lastNameLabel.AutoSize = true;
            this.lastNameLabel.Location = new System.Drawing.Point(107, 200);
            this.lastNameLabel.Name = "lastNameLabel";
            this.lastNameLabel.Size = new System.Drawing.Size(79, 20);
            this.lastNameLabel.TabIndex = 0;
            this.lastNameLabel.Text = "Last Name";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(615, 92);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(178, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Already have an account?";
            // 
            // firstNameLabel
            // 
            this.firstNameLabel.AutoSize = true;
            this.firstNameLabel.Location = new System.Drawing.Point(107, 92);
            this.firstNameLabel.Name = "firstNameLabel";
            this.firstNameLabel.Size = new System.Drawing.Size(80, 20);
            this.firstNameLabel.TabIndex = 0;
            this.firstNameLabel.Text = "First Name";
            this.firstNameLabel.Click += new System.EventHandler(this.firstNameLabel_Click);
            // 
            // SignUp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1240, 670);
            this.Controls.Add(this.splitContainer1);
            this.Name = "SignUp";
            this.Text = "SignUp";
            this.Load += new System.EventHandler(this.SignUp_Load);
            this.splitContainer1.Panel2.ResumeLayout(false);
            this.splitContainer1.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.Button signupBtn;
        private System.Windows.Forms.Button loginLinkbtn;
        private System.Windows.Forms.TextBox emailInput;
        private System.Windows.Forms.TextBox lastNameInput;
        private System.Windows.Forms.Label emailValidity;
        private System.Windows.Forms.TextBox firstNameInput;
        private System.Windows.Forms.Label lastNameValidity;
        private System.Windows.Forms.Label passwordLabel;
        private System.Windows.Forms.Label emailLabel;
        private System.Windows.Forms.Label firstNameValidity;
        private System.Windows.Forms.Label lastNameLabel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label firstNameLabel;
        private System.Windows.Forms.Label confirmPasswordLabel;
        private System.Windows.Forms.Label passwordValidity1;
        private System.Windows.Forms.TextBox confirmPassword;
        private System.Windows.Forms.TextBox choosePassword;
    }
}