using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;

namespace Virtual_Binder
{
    public partial class LoginScreen : Form
    {
        List<Accounts> accountList = new List<Accounts>();
        List<String> stringList = new List<String>();
        
        Boolean searchBool = false;

        public LoginScreen()
        {
            InitializeComponent();

            loadAccounts(); // load data from XML file with program starts
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
            if (passwordTextBox1.Text == passwordTextBox2.Text) 
            {
                addAccounts();
                //open new screen
            }
            else if (passwordTextBox1.Text != passwordTextBox2.Text)
            {
                passwordTextBox1.Text = "Please enter matching passwords.";
                passwordTextBox2.Text = "";
            }
        }

        private void logInButton2_Click(object sender, EventArgs e)
        {
            searchBool = LinearSearch(stringList, emailOrUsernameTextBox.Text);

            if (searchBool == true)
            {
                //go onto main screen 
            }
            else if (searchBool == false)
            {
                emailOrUsernameTextBox.Text = "Please enter a valid username/password.";
                passwordTextBox.Text = "";
            }
        }

        public Boolean LinearSearch(List<String> searchList, String searchValue)
        {
            foreach (string s in searchList)
            {
                if (s == searchValue)
                {
                    return true;
                }
            }
            return false;
        }

        public void loadAccounts()
        {
            string newUsername, newEmail, newPassword;

            XmlReader reader = XmlReader.Create("Resources/employeeData.xml");

            while (reader.Read())
            {
                if (reader.NodeType == XmlNodeType.Text)
                {
                    newUsername = reader.ReadString();

                    reader.ReadToNextSibling("firstName");
                    newEmail = reader.ReadString();

                    reader.ReadToNextSibling("lastName");
                    newPassword = reader.ReadString();

                    Accounts newAcc = new Accounts(newUsername, newEmail, newPassword);
                    accountList.Add(newAcc);
                }
            }

            reader.Close();
        }

        public void addAccounts()
        {
            XmlWriter writer = XmlWriter.Create("Resources/employeeData.xml", null);

            writer.WriteStartElement("Employees");

            foreach (Accounts a in accountList)
            {
                writer.WriteStartElement("Account" + emailOrUsernameTextBox.Text);

                writer.WriteElementString("Username", a.username);
                writer.WriteElementString("Email", a.email);
                writer.WriteElementString("Password", a.password);

                writer.WriteEndElement();
            }

            writer.WriteEndElement();

            writer.Close();
        }
    }
}
