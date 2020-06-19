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

        List<Accounts> accountList = new List<Accounts>();

        public Create_New_Account()
        {
            InitializeComponent();
            loadAccounts();
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
                writer.WriteStartElement("Account" + newAccUsername);

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
    }
}
