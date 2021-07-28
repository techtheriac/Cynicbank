using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Commons;
using CynicBank.Core.Models;

namespace CynicBanky
{
    public partial class Dashboard : Form
    {
        public Dashboard()
        {
            InitializeComponent();
        }

        private void Dashboard_Load(object sender, EventArgs e)
        {
            if(Session.LoggedInUser != null)
            {
                username.Text = Session.UserName;
            }
        }
    }
}
