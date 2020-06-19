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
        string usernameOrEmailPrev;

        List<Accounts> specificAccount = new List<Accounts>();

        public MainScreen()
        {
            InitializeComponent();
        }

        public MainScreen(string usernameOrEmail)
        {
            InitializeComponent();
            this.usernameOrEmailPrev = usernameOrEmail;

            loadAccount(usernameOrEmail);
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

            autoFillLabel.Text = specificAccount[1].class1;
        }

        private void classButton2_Click(object sender, EventArgs e)
        {
            currentClass = 2;

            class1Button.ForeColor = Color.Gray;
            class2Button.ForeColor = Color.Black;
            class3Button.ForeColor = Color.Gray;
            class4Button.ForeColor = Color.Gray;
            class5Button.ForeColor = Color.Gray;

            autoFillLabel.Text = specificAccount[1].class2;
        }

        private void classButton3_Click(object sender, EventArgs e)
        {
            currentClass = 3;

            class1Button.ForeColor = Color.Gray;
            class2Button.ForeColor = Color.Gray;
            class3Button.ForeColor = Color.Black;
            class4Button.ForeColor = Color.Gray;
            class5Button.ForeColor = Color.Gray;

            autoFillLabel.Text = specificAccount[1].class3;
        }

        private void classButton4_Click(object sender, EventArgs e)
        {
            currentClass = 4;

            class1Button.ForeColor = Color.Gray;
            class2Button.ForeColor = Color.Gray;
            class3Button.ForeColor = Color.Gray;
            class4Button.ForeColor = Color.Black;
            class5Button.ForeColor = Color.Gray;

            autoFillLabel.Text = specificAccount[1].class4;
        }

        private void classButton5_Click(object sender, EventArgs e)
        {
            currentClass = 5;

            class1Button.ForeColor = Color.Gray;
            class2Button.ForeColor = Color.Gray;
            class3Button.ForeColor = Color.Gray;
            class4Button.ForeColor = Color.Gray;
            class5Button.ForeColor = Color.Black;

            autoFillLabel.Text = specificAccount[1].class5;
        }

        private void MainScreen_Load(object sender, EventArgs e)
        {            
            class1Button.Text = specificAccount[1].class1;
            class2Button.Text = specificAccount[1].class2;
            class3Button.Text = specificAccount[1].class3;
            class4Button.Text = specificAccount[1].class4;
            class5Button.Text = specificAccount[1].class5;

            class1Button.ForeColor = Color.Black;
            class2Button.ForeColor = Color.Gray;
            class3Button.ForeColor = Color.Gray;
            class4Button.ForeColor = Color.Gray;
            class5Button.ForeColor = Color.Gray;

            autoFillLabel.Text = specificAccount[1].class1;
        }

        private void addGradeButton_Click(object sender, EventArgs e)
        {
            int a;
            int b;
            a = Convert.ToInt32(newestGradeTextBox.Text);
            b = Convert.ToInt32(totalPercentTextBox.Text);
            int newAverage;

            if (currentClass == 1)
            {
                calculateMethod(specificAccount[1].newClass1Average, a, b);
            }
            else if (currentClass == 2)
            {
                calculateMethod(specificAccount[1].newClass2Average, a, b);
            }
            else if (currentClass == 3)
            {
                calculateMethod(specificAccount[1].newClass3Average, a, b);
            }
            else if (currentClass == 4)
            {
                calculateMethod(specificAccount[1].newClass4Average, a, b);
            }
            else if (currentClass == 5)
            {
                calculateMethod(specificAccount[1].newClass5Average, a, b);
            }
        }

        public void calculateMethod(int currentAverage, int newGradePercent, int newGradePercentWorth)
        {
            //Put calculations in here and stuff
        }

        public void loadAccount(string usernameOrEmail)
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

                    if (newUsername == usernameOrEmail || newEmail == usernameOrEmail)
                    {
                        Accounts newAcc = new Accounts(newUsername, newEmail, newPassword, newClass1, newClass2, newClass3,
                       newClass4, newClass5, newClass1Average, newClass2Average, newClass3Average, newClass4Average, newClass5Average);
                        specificAccount.Add(newAcc);
                    }                  
                }
            }

            reader.Close();
        }
    }
}
