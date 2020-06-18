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

        public string newAccUsername, newAccEmail, newAccPassword;

        public Create_New_Account()
        {
            InitializeComponent();
            newAccUsername = UserControl.shareUsername;
        }

        private void exitButton2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void moveOnButton_Click(object sender, EventArgs e)
        {
            classCounter++;
            whichClassLabel.Text = "CLASS " + classCounter;
        }

        private void anotherClassButton_Click(object sender, EventArgs e)
        {
            addAccounts();

            classCounter++;
            whichClassLabel.Text = "CLASS " + classCounter;
        }

        public void addAccounts()
        {
            XmlWriter writer = XmlWriter.Create("Resources/XMLAccountFile.xml", null);

            writer.WriteStartElement("Account");

            foreach (Accounts a in accountList)
            {
                writer.WriteStartElement("Account" + emailOrUsernameTextBox.Text);

                writer.WriteElementString("Username", a.username);
                writer.WriteElementString("Email", a.email);
                writer.WriteElementString("Password", a.password);
                writer.WriteElementString("Class Number", Convert.ToString(a.classNumber));
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
