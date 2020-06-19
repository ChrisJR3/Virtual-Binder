using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;

namespace Virtual_Binder
{
    public partial class UserControl1 : UserControl
    {
        List<Accounts> accountList = new List<Accounts>();
        List<String> stringList = new List<String>();

        Boolean searchBool = false;

        public string shareUsername, shareEmail, sharePassword;

        public UserControl1()
        {
            InitializeComponent();

            loadAccounts(); // load data from XML file with program starts
        }

        private void createAccountButton2_Click(object sender, EventArgs e)
        {
            if (passwordTextBox1.Text == passwordTextBox2.Text)
            {
                shareUsername = usernameTextBox.Text;
                shareEmail = emailTextBox.Text;
                sharePassword = passwordTextBox1.Text;

                Create_New_Account cna = new Create_New_Account();
                this.Controls.Add(cna);

                Form ls = this.FindForm();
                ls.Controls.Remove(this);
            }
            else if (passwordTextBox1.Text != passwordTextBox2.Text)
            {
                passwordTextBox1.Text = "Please enter matching passwords.";
                passwordTextBox2.Text = "";
            }
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void logInButton2_Click(object sender, EventArgs e)
        {
            searchBool = LinearSearch(stringList, emailOrUsernameTextBox.Text);

            if (searchBool == true)
            {
                addAccounts();
                //go onto main screen 
            }
            else if (searchBool == false)
            {
                emailOrUsernameTextBox.Text = "Please enter a valid username/password.";
                passwordTextBox.Text = "";
            }
        }

        private void logInButton1_Click(object sender, EventArgs e)
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
            string newUsername, newEmail, newPassword, newClass1, newClass2, newClass3, newClass4, newClass5;
            int newClass1Average, newClass2Average, newClass3Average, newClass4Average, newClass5Average;

            XmlReader reader = XmlReader.Create("Resources/XMLAccountFile.xml");

            while (reader.Read())
            {
                if (reader.NodeType == XmlNodeType.Text)
                {
                    newUsername = reader.ReadString();

                    reader.ReadToNextSibling("Email");
                    newEmail = reader.ReadString();

                    reader.ReadToNextSibling("Password");
                    newPassword = reader.ReadString();

                    reader.ReadToNextSibling("Class 1");
                    newClass1 = reader.ReadString();

                    reader.ReadToNextSibling("Class 2");
                    newClass2 = reader.ReadString();

                    reader.ReadToNextSibling("Class 3");
                    newClass3 = reader.ReadString();

                    reader.ReadToNextSibling("Class 4");
                    newClass4 = reader.ReadString();

                    reader.ReadToNextSibling("Class 5");
                    newClass5 = reader.ReadString();

                    reader.ReadToNextSibling("Class 1 Average");
                    newClass1Average = Convert.ToInt32(reader.ReadString());

                    reader.ReadToNextSibling("Class 2 Average");
                    newClass2Average = Convert.ToInt32(reader.ReadString());

                    reader.ReadToNextSibling("Class 3 Average");
                    newClass3Average = Convert.ToInt32(reader.ReadString());

                    reader.ReadToNextSibling("Class 4 Average");
                    newClass4Average = Convert.ToInt32(reader.ReadString());

                    reader.ReadToNextSibling("Class 5 Average");
                    newClass5Average = Convert.ToInt32(reader.ReadString());

                    Accounts newAcc = new Accounts(newUsername, newEmail, newPassword, newClass1, newClass2, newClass3,
                        newClass4, newClass5, newClass1Average, newClass2Average, newClass3Average, newClass4Average, newClass5Average);
                    accountList.Add(newAcc);
                }
            }

            reader.Close();
        }

        public void addAccounts()
        {
            XmlWriter writer = XmlWriter.Create("Resources/XMLAccountFile.xml", null);

            writer.WriteStartElement("Account");

            foreach (Accounts a in accountList)
            {
                writer.WriteStartElement("Account" + usernameTextBox.Text);

                writer.WriteElementString("Username", a.username);
                writer.WriteElementString("Email", a.email);
                writer.WriteElementString("Password", a.password);
                writer.WriteElementString("Class 1", a.class1);
                writer.WriteElementString("Class 2", a.class2);
                writer.WriteElementString("Class 3", a.class3);
                writer.WriteElementString("Class 4", a.class4);
                writer.WriteElementString("Class 5", a.class5);

                writer.WriteEndElement();
            }

            writer.WriteEndElement();

            writer.Close();
        }
    }
}
