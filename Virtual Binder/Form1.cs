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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            //opening Login Screen right away
            UserControl1 ls = new UserControl1();
            this.Controls.Add(ls);
            ls.Location = new Point((this.Width - ls.Width) / 2, (this.Height - ls.Height) / 2);
        }
    }
}
