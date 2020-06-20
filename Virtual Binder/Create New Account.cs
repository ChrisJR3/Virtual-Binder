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
    public partial class Create_New_Account : UserControl
    {
        int classCounter = 1;

        public string newAccUsername;

        List<Accounts> accountList = new List<Accounts>();
        List<String> classNameList = new List<String>();

        public Create_New_Account()
        {
            InitializeComponent();
            loadAccount();
        }

        private void exitButton2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void moveOnButton_Click(object sender, EventArgs e)
        {
            addAccount();

            MainScreen ms1 = new MainScreen(usernameTextBox.Text);

            MainScreen ms = new MainScreen();
            this.Controls.Add(ms);

            titleLabel2.Visible = false;
            whichClassLabel.Visible = false;
            pleaseEnterClassName.Visible = false;
            classNameTextBox.Visible = false;
            anotherClassButton.Visible = false;
            moveOnButton.Visible = false;
            exitButton2.Visible = false;
        }

        private void anotherClassButton_Click(object sender, EventArgs e)
        {
            classNameList.Add(classNameTextBox.Text);

            if (classCounter == 5)
            {
                classNameTextBox.Text = "You have reached the class limit, please move on.";
            }
            else
            {
                classCounter++;
                whichClassLabel.Text = "CLASS " + classCounter;
            }
        }

        public void addAccount()
        {
            string firstClassName = classNameList[1];

            XmlWriter writer = XmlWriter.Create("Resources/XMLAccountFile.xml", null);

            writer.WriteStartElement("Account");

            writer.WriteStartElement("Account" + usernameTextBox.Text);

            writer.WriteElementString("Username", usernameTextBox.Text);
            writer.WriteElementString("Email", emailTextBox.Text);
            writer.WriteElementString("Password", passwordTextBox1.Text);
            writer.WriteElementString("Class 1", firstClassName);
            writer.WriteElementString("Class 1 Grade", "0");
            writer.WriteElementString("Class 1 Weight", "0");
            if (classNameList[2] != null)
            {
                writer.WriteElementString("Class 2", classNameList[2]);
                writer.WriteElementString("Class 2 Grade", "0");
                writer.WriteElementString("Class 2 Weight", "0");
            }
            if (classNameList[3] != null)
            {
                writer.WriteElementString("Class 3", classNameList[3]);
                writer.WriteElementString("Class 3 Grade", "0");
                writer.WriteElementString("Class 3 Weight", "0");
            }
            if (classNameList[4] != null)
            {
                writer.WriteElementString("Class 4", classNameList[4]);
                writer.WriteElementString("Class 4 Grade", "0");
                writer.WriteElementString("Class 4 Weight", "0");
            }
            if (classNameList[5] != null)
            {
                writer.WriteElementString("Class 5", classNameList[5]);
                writer.WriteElementString("Class 5 Grade", "0");
                writer.WriteElementString("Class 5 Weight", "0");
            }

            writer.WriteEndElement();
            
            writer.WriteEndElement();

            writer.Close();
        }

        public void loadAccount()
        {
            string newUsername, newEmail, newPassword, newClass1, newClass2, newClass3, newClass4, newClass5;
            int newClass1Average, newClass2Average, newClass3Average, newClass4Average, newClass5Average;
            int newClass1Weight, newClass2Weight, newClass3Weight, newClass4Weight, newClass5Weight;

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

                    Accounts newAcc = new Accounts(newUsername, newEmail, newPassword, newClass1, newClass2, newClass3,
                        newClass4, newClass5, newClass1Average, newClass1Weight, newClass2Average, newClass2Weight,
                        newClass3Average, newClass3Weight, newClass4Average, newClass4Weight, newClass5Average, newClass5Weight);
                    accountList.Add(newAcc);
                }
            }

            reader.Close();
        }

        private void createAccountButton2_Click(object sender, EventArgs e)
        {
            if (passwordTextBox1.Text == passwordTextBox2.Text)
            {
                emailLabel.Visible = false;
                usernameLabel.Visible = false;
                passwordLabel1.Visible = false;
                passwordLabel2.Visible = false;
                emailTextBox.Visible = false;
                usernameTextBox.Visible = false;
                passwordTextBox1.Visible = false;
                passwordTextBox2.Visible = false;
                backgroundTextBox2.Visible = false;
                createAccountButton2.Visible = false;

                pleaseEnterClassName.Visible = true;
                classNameTextBox.Visible = true;
            }
            else if (passwordTextBox1.Text != passwordTextBox2.Text)
            {
                passwordTextBox1.Text = "Please enter matching passwords.";
                passwordTextBox2.Text = "";
            }        
        }
    }
}
