using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Joonas_Praktika3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        Form form1 = new JO_YL1();
        Form form2 = new JO_YL2();
        //Form form3 = new JO_YL3();
        //Form form4 = new JO_YL4();
        //Form form5 = new JO_YL5();
        //Form form6 = new JO_YL6();

        private void JO_YL1_Click(object sender, EventArgs e)
        {
            if (form1.Visible == false) form1 = new JO_YL1();
            form1.Visible = true;
            form1.Activate();
        }

        private void JO_Btn_Yl2_Click(object sender, EventArgs e)
        {
            if (form2.Visible == false) form2 = new JO_YL2();
            form2.Visible = true;
            form2.Activate();
        }
    }
}
