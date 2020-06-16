using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Virtual_Binder
{
    public partial class LoginScreen : Form
    {
        List<Accounts> accountList = new List<Accounts>();

        public LoginScreen()
        {
            InitializeComponent();
        }

        private void logInButton_Click(object sender, EventArgs e)
        {
            emailOrUsernameLabel.Visible = true;
            passwordLabel.Visible = true;
            emailOrUsernameTextBox.Visible = true;
            passwordTextBox.Visible = true;
            logInButton2.Visible = true;
            backgroundBox1.Visible = true;
        }

        private void createAccountButton_Click(object sender, EventArgs e)
        {
            emailLabel.Visible = true;
            usernameLabel.Visible = true;
            passwordLabel1.Visible = true;
            passwordLabel2.Visible = true;
            emailTextBox.Visible = true;
            usernameTextBox.Visible = true;
            passwordTextBox1.Visible = true;
            passwordTextBox2.Visible = true;
            createAccountButton2.Visible = true;
            backgroundTextBox2.Visible = true;
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void createAccountButton2_Click(object sender, EventArgs e)
        {

        }

        private void logInButton2_Click(object sender, EventArgs e)
        {

        }
    }
}
