using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Commons;
using CynicBank.Core.Models;
using CynicBank.Core.Implementations;
using CynicBank.Core.Interfaces;

namespace CynicBanky
{
    public partial class SignUp : Form
    {
        private string _firstName;
        private string _lastName;
        private string _emial;
        private string _passwordTemp;
        private string _password;

        public SignUp()
        {
            InitializeComponent();
        }

        private void firstNameLabel_Click(object sender, EventArgs e)
        {

        }

        private void firstNameValidity_Click(object sender, EventArgs e)
        {

        }

        private void firstNameInput_TextChanged(object sender, EventArgs e)
        {
            while (firstNameInput.TextLength > 0)
            {
                if (Commons.Validate.IsValidName(firstNameInput.Text) == false)
                {
                    firstNameValidity.Visible = true;
                }
                else
                {
                    firstNameValidity.Visible = false;
                    _firstName = firstNameInput.Text;
                }

                break;
            }
        }

        private void lastNameInput_TextChanged(object sender, EventArgs e)
        {
            while (lastNameInput.TextLength > 0)
            {
                if (Commons.Validate.IsValidName(lastNameInput.Text) == false)
                {
                    lastNameValidity.Visible = true;
                }
                else
                {
                    lastNameValidity.Visible = false;
                    _lastName = lastNameInput.Text;
                }

                break;
            }
        }

        private void emailInput_TextChanged(object sender, EventArgs e)
        {
            while (emailInput.TextLength > 0)
            {
                if (Commons.Validate.IsValidEmail(emailInput.Text) == false)
                {
                    emailValidity.Visible = true;
                }
                else
                {
                    emailValidity.Visible = false;
                    _emial = emailInput.Text;
                }

                break;
            }
        }

        private void loginLinkbtn_Click(object sender, EventArgs e)
        {
            Login loginInstance = new Login();
            this.Hide();
            loginInstance.Show();
        }

        private void textBox1_TextChanged_1(object sender, EventArgs e)
        {
            
        }

        private void confirmPassword_TextChanged(object sender, EventArgs e)
        {
            while (confirmPassword.TextLength > 0)
            {
                if (_passwordTemp != confirmPassword.Text)
                {
                    passwordValidity1.Visible = true;
                }
                else
                {
                    passwordValidity1.Visible = false;
                    _password = _passwordTemp;
                }

                break;
            }
        }

        private void choosePassword_TextChanged(object sender, EventArgs e)
        {
            _passwordTemp = choosePassword.Text;
        }

        private void signupBtn_Click(object sender, EventArgs e)
        {
            bool evaluateValidity =
                Commons.Validate.IsValidName(_firstName) ||
                Commons.Validate.IsValidName(_lastName) ||
                Commons.Validate.IsValidEmail(_emial) ||
                _password != null;
            
            if(evaluateValidity != true)
            {
                MessageBox.Show("Error");
            } else
            {
                var UserAction = new UserRepo();
                var userModel = new User { FirstName = _firstName, LastName = _lastName, Email = _emial, Password = _password };
                bool status = UserAction.AddNewUser(userModel);

                if(status == true)
                {
                    var login = new Login();
                    this.Hide();
                    login.Show();
                }
            }
        }

        private void SignUp_Load(object sender, EventArgs e)
        {

        }

        private void splitContainer1_Panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
