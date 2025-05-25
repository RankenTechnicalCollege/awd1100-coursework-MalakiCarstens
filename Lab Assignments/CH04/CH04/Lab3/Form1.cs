using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab3
{
    public partial class Form1 : Form
    {   const double PERCENT_RAISE = 1.04;
        public Form1()
        {
            InitializeComponent();
        }

        private void btnResult_Click(object sender, EventArgs e)
        {
            string name1 = nameInput1.Text;
            string name2 = nameInput2.Text;
            string name3 = nameInput3.Text;

            double salary1 = Convert.ToDouble(txtSalary1.Text);
            double salary2 = Convert.ToDouble(txtSalary2.Text);
            double salary3 = Convert.ToDouble(txtSalary3.Text);


            double emp1_1 = salary1;
            double emp1_2 = emp1_1 * PERCENT_RAISE;
            double emp1_3 =  emp1_2 * PERCENT_RAISE;
            txtNameValue1.Text = name1;
            txtSalary1_1.Text = $"{emp1_1:C}";
            txtSalary1_2.Text = $"{emp1_2:C}";
            txtSalary1_3.Text = $"{emp1_3:C}";



            double emp2_1 = salary2;
            double emp2_2 = emp2_1 * PERCENT_RAISE;
            double emp2_3 = emp2_2 * PERCENT_RAISE;
            txtNameValue2.Text = name2;
            txtSalary2_1.Text = $"{emp2_1:C}";
            txtSalary2_2.Text = $"{emp2_2:C}";
            txtSalary2_3.Text = $"{emp2_3:C}";



            double emp3_1 = salary2;
            double emp3_2 = emp2_1 * PERCENT_RAISE;
            double emp3_3 = emp2_2 * PERCENT_RAISE;
            txtNameValue3.Text = name3;
            txtSalary3_1.Text = $"{emp3_1:C}";
            txtSalary3_2.Text = $"{emp3_2:C}";
            txtSalary3_3.Text = $"{emp3_3:C}";




        }
    }
}
