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
    public partial class MainScreen : UserControl
    {
        int currentClass = 1;

        List<Accounts> specificAccount = new List<Accounts>();

        public MainScreen()
        {
            InitializeComponent();
            loadAccounts();
        }

        private void exitButton3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void class1Button_Click(object sender, EventArgs e)
        {
            currentClass = 1;

            class1Button.ForeColor = Color.Black;
            class2Button.ForeColor = Color.Gray;
            class3Button.ForeColor = Color.Gray;
            class4Button.ForeColor = Color.Gray;
            class5Button.ForeColor = Color.Gray;

            autoFillLabel.Text = specificAccount.class1;
        }

        private void classButton2_Click(object sender, EventArgs e)
        {
            currentClass = 2;

            class1Button.ForeColor = Color.Gray;
            class2Button.ForeColor = Color.Black;
            class3Button.ForeColor = Color.Gray;
            class4Button.ForeColor = Color.Gray;
            class5Button.ForeColor = Color.Gray;

            autoFillLabel.Text = specificAccount.class2;
        }

        private void classButton3_Click(object sender, EventArgs e)
        {
            currentClass = 3;

            class1Button.ForeColor = Color.Gray;
            class2Button.ForeColor = Color.Gray;
            class3Button.ForeColor = Color.Black;
            class4Button.ForeColor = Color.Gray;
            class5Button.ForeColor = Color.Gray;

            autoFillLabel.Text = specificAccount.class3;
        }

        private void classButton4_Click(object sender, EventArgs e)
        {
            currentClass = 4;

            class1Button.ForeColor = Color.Gray;
            class2Button.ForeColor = Color.Gray;
            class3Button.ForeColor = Color.Gray;
            class4Button.ForeColor = Color.Black;
            class5Button.ForeColor = Color.Gray;

            autoFillLabel.Text = specificAccount.class4;
        }

        private void classButton5_Click(object sender, EventArgs e)
        {
            currentClass = 5;

            class1Button.ForeColor = Color.Gray;
            class2Button.ForeColor = Color.Gray;
            class3Button.ForeColor = Color.Gray;
            class4Button.ForeColor = Color.Gray;
            class5Button.ForeColor = Color.Black;

            autoFillLabel.Text = specificAccount.class5;
        }

        private void MainScreen_Load(object sender, EventArgs e)
        {            
            class1Button.Text = specificAccount.class1;
            class2Button.Text = specificAccount.class1;
            class3Button.Text = specificAccount.class1;
            class4Button.Text = specificAccount.class1;
            class5Button.Text = specificAccount.class1;

            class1Button.ForeColor = Color.Black;
            class2Button.ForeColor = Color.Gray;
            class3Button.ForeColor = Color.Gray;
            class4Button.ForeColor = Color.Gray;
            class5Button.ForeColor = Color.Gray;

            autoFillLabel.Text = specificAccount.class1;
        }

        public void loadAccounts()
        {
            string newUsername, newEmail, newPassword, newClass1, newClass2, newClass3, newClass4, newClass5;

            XmlReader reader = XmlReader.Create("Resources/XMLAccountFile.xml");

            while (reader.Read())
            {
                if (reader.NodeType == sharedVariable)
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

                    Accounts newAcc = new Accounts(newUsername, newEmail, newPassword, newClass1, newClass2, newClass3, newClass4, newClass5);
                    specificAccount.Add(newAcc);
                }
            }

            reader.Close();
        }

        private void addGradeButton_Click(object sender, EventArgs e)
        {
            int a;
            int b;
            a = Convert.ToInt32(newestGradeTextBox.Text);
            b = Convert.ToInt32(totalPercentTextBox.Text);
            int newAverage;

            if (specificAmccount.class1Average == 0 & currentClass == 1)
            {
                newAverage = calculateMethod(0, a, b);
            }
            else if (specificAmccount.class2Average == 0 & currentClass == 2)
            {
                newAverage = calculateMethod(0, a, b);
            }
            else if (specificAmccount.class3Average == 0 & currentClass == 3)
            {
                newAverage = calculateMethod(0, a, b);
            }
            else if (specificAmccount.class4Average == 0 & currentClass == 4)
            {
                newAverage = calculateMethod(0, a, b);
            }
            else if (specificAmccount.class5Average == 0 & currentClass == 5)
            {
                newAverage = calculateMethod(0, a, b);
            }
        }

        public void calculateMethod(int currentAverage, int newGradePercent, int newGradePercentWorth)
        {
            //Put calculations in here and stuff
        }
    }
}
