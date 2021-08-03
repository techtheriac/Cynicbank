using CynicBank.Core.Implementations;
using System;
using System.Windows.Forms;
using Models;
using CynicBank.Persistence.Implementations;
using CynicBank.Persistence.Interfaces;

namespace CynicBanky
{
    public partial class Login : Form
    {
        private string _email;
        private string _password;
        public Login()
        {
            InitializeComponent();
        }

        private void Login_Load(object sender, EventArgs e)
        {

        }

        private void splitContainer1_Panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            SignUp userSignUp = new SignUp();
            this.Hide();
            userSignUp.Show();
        }

        private void loginEmail_TextChanged(object sender, EventArgs e)
        {
            while (loginEmail.TextLength > 0)
            {
                if (Commons.Validate.IsValidEmail(loginEmail.Text) == false)
                {
                    emailValidity.Visible = true;
                }
                else
                {
                    emailValidity.Visible = false;
                    _email = loginEmail.Text;
                }

                break;
            }
        }

        private void loginPassword_TextChanged(object sender, EventArgs e)
        {
            _password = loginPassword.Text;
        }

        private void loginBtn_Click(object sender, EventArgs e)
        {
            var auth = new AuthRepo(new UserManager());
            bool status = auth.Login(_email, _password);

            if(status == true)
            {
                Menu menu = new Menu();
                this.Hide();
                menu.Show();
            } else
            {
                //MessageBox.Show("Invalid Credentials");

                MessageBox.Show($"{_email} {_password}");

            }
        }

        private void splitContainer1_Panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
