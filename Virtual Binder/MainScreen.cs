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

            currentTotalLabel.Text = "Your current total grade is: " + specificAccount[1].newClass1Average;
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

            currentTotalLabel.Text = "Your current total grade is: " + specificAccount[1].newClass2Average;
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

            currentTotalLabel.Text = "Your current total grade is: " + specificAccount[1].newClass3Average;
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

            currentTotalLabel.Text = "Your current total grade is: " + specificAccount[1].newClass4Average;
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

            currentTotalLabel.Text = "Your current total grade is: " + specificAccount[1].newClass5Average;
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

            currentTotalLabel.Text = "Your current total grade is: " + specificAccount[1].newClass1Average;
        }

        private void addGradeButton_Click(object sender, EventArgs e)
        {
            int newGradePercent;
            int newGradePercentWorth;
            newGradePercent = Convert.ToInt32(newestGradeTextBox.Text);
            newGradePercentWorth = Convert.ToInt32(totalPercentTextBox.Text); 

            if (currentClass == 1 && newGradePercentWorth + specificAccount[1].newClass1Average >= 101)
            {
                calculateMethod(specificAccount[1].newClass1Average, specificAccount[1].newClass1Weight, newGradePercent, newGradePercentWorth);
            }
            else if (currentClass == 2 && newGradePercentWorth + specificAccount[1].newClass2Average >= 101)
            {
                calculateMethod(specificAccount[1].newClass2Average, specificAccount[1].newClass2Weight, newGradePercent, newGradePercentWorth);
            }
            else if (currentClass == 3 && newGradePercentWorth + specificAccount[1].newClass3Average >= 101)
            {
                calculateMethod(specificAccount[1].newClass3Average, specificAccount[1].newClass3Weight, newGradePercent, newGradePercentWorth);
            }
            else if (currentClass == 4 && newGradePercentWorth + specificAccount[1].newClass4Average >= 101)
            {
                calculateMethod(specificAccount[1].newClass4Average, specificAccount[1].newClass4Weight, newGradePercent, newGradePercentWorth);
            }
            else if (currentClass == 5 && newGradePercentWorth + specificAccount[1].newClass5Average >= 101)
            {
                calculateMethod(specificAccount[1].newClass5Average, specificAccount[1].newClass5Weight, newGradePercent, newGradePercentWorth);
            }
            else
            {
                newestGradeTextBox.Text = "Please enter valid numbers.";
                totalPercentTextBox.Text = "Percentage may have exceeded 100%";
            }
        }

        public void calculateMethod(int currentAverage, int currentWeight, int newGradePercent, int newGradePercentWorth)
        {
            //Put calculations in here and stuff
            double newAverage1 = ((currentWeight/100)*currentAverage) + ((newGradePercentWorth/100)*newGradePercent);
            int newAverage = currentAverage = Convert.ToInt32(newAverage1);
            int newWeight = currentWeight + newGradePercentWorth;

            addNewGradeAndWeight(newAverage, newWeight, currentAverage, currentWeight);           
        }

        public void loadAccount(string usernameOrEmail)
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

                    if (newUsername == usernameOrEmail || newEmail == usernameOrEmail)
                    {
                        Accounts newAcc = new Accounts(newUsername, newEmail, newPassword, newClass1, newClass2, newClass3,
                         newClass4, newClass5, newClass1Average, newClass1Weight, newClass2Average, newClass2Weight,
                         newClass3Average, newClass3Weight, newClass4Average, newClass4Weight, newClass5Average, newClass5Weight);
                        specificAccount.Add(newAcc);
                    }                  
                }
            }

            reader.Close();
        }

        public void addNewGradeAndWeight(int newAverage, int newWeight, int originalAverage, int originalWeight)
        {
            //open XML file and place it in doc 
            XmlDocument doc = new System.Xml.XmlDocument();
            doc.Load("Resources/XMLAccountFile.xml");

            //create a list of all nodes called "name"
            XmlNodeList gradeList = doc.GetElementsByTagName("Account" + specificAccount[1].username);
            
            foreach (XmlNode n in gradeList)
            {
                if (n.InnerText == "Class " + currentClass + " Grade" + originalAverage)
                {
                    n.InnerText = "Class " + currentClass + " Grade" + newAverage;
                }
            }

            foreach (XmlNode n in gradeList)
            {
                if (n.InnerText == "Class " + currentClass + " Weight" + originalAverage)
                {
                    n.InnerText = "Class " + currentClass + " Weight" + newAverage;
                }
            }

            //save and close the document 
            doc.Save("Resources/XMLAccountFile.xml");
        }
    }
}
