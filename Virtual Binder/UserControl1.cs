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

        public int screenChosing = 3;

        Boolean searchBool = false;

        public string shareUsername, shareEmail, sharePassword;

        public UserControl1()
        {
            InitializeComponent();

            loadAccounts(); // load data from XML file with program starts
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
                emailOrUsernameLabel.Visible = false;
                passwordLabel.Visible = false;
                emailOrUsernameTextBox.Visible = false;
                passwordTextBox.Visible = false;
                backgroundBox1.Visible = false;
                logInButton2.Visible = false;
                createAccountButton.Visible = false;
                logInButton1.Visible = false;
                titleLabel.Visible = false;
                exitButton.Visible = false;

                MainScreen ms2 = new MainScreen();
                this.Controls.Add(ms2);
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
            emailOrUsernameLabel.Visible = false;
            passwordLabel.Visible = false;
            emailOrUsernameTextBox.Visible = false;
            passwordTextBox.Visible = false;
            backgroundBox1.Visible = false;
            logInButton2.Visible = false;
            createAccountButton.Visible = false;
            logInButton1.Visible = false;
            titleLabel.Visible = false;
            exitButton.Visible = false;

            Create_New_Account cna = new Create_New_Account();
            this.Controls.Add(cna);
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
            int newClass1Weight, newClass2Weight, newClass3Weight, newClass4Weight, newClass5Weight;

            XmlReader reader = XmlReader.Create("Resources/XMLAccountFile.xml");

            while (reader.Read())
            {
                if (reader.NodeType == XmlNodeType.Text)
                {
                    reader.ReadStartElement();

                    reader.ReadToDescendant("Username");
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

                    reader.ReadToNextSibling("Class 1 Weight");
                    newClass1Weight = Convert.ToInt32(reader.ReadString());

                    reader.ReadToNextSibling("Class 2 Average");
                    newClass2Average = Convert.ToInt32(reader.ReadString());

                    reader.ReadToNextSibling("Class 2 Weight");
                    newClass2Weight = Convert.ToInt32(reader.ReadString());

                    reader.ReadToNextSibling("Class 3 Average");
                    newClass3Average = Convert.ToInt32(reader.ReadString());

                    reader.ReadToNextSibling("Class 3 Weight");
                    newClass3Weight = Convert.ToInt32(reader.ReadString());

                    reader.ReadToNextSibling("Class 4 Average");
                    newClass4Average = Convert.ToInt32(reader.ReadString());

                    reader.ReadToNextSibling("Class 4 Weight");
                    newClass4Weight = Convert.ToInt32(reader.ReadString());

                    reader.ReadToNextSibling("Class 5 Average");
                    newClass5Average = Convert.ToInt32(reader.ReadString());

                    reader.ReadToNextSibling("Class 5 Weight");
                    newClass5Weight = Convert.ToInt32(reader.ReadString());

                    reader.ReadEndElement();

                    Accounts newAcc = new Accounts(newUsername, newEmail, newPassword, newClass1, newClass2, newClass3,
                        newClass4, newClass5, newClass1Average, newClass1Weight, newClass2Average, newClass2Weight,
                        newClass3Average, newClass3Weight, newClass4Average, newClass4Weight, newClass5Average, newClass5Weight);
                    accountList.Add(newAcc);
                }
            }
            reader.Close();
        }
    }
}
