using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Exercise2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnGrade_Click(object sender, EventArgs e)
        {
            if (double.TryParse(txtGradeInput.Text, out double gpa))
            {
                if (gpa < 0.0 || gpa > 4.0)
                {
                    lblResults.Text = $"Entry must be between 0.0 and 4.0";
                }
                else 
                {
                    if (gpa > 3.0)
                    {
                        lblResults.Text = $"Your letter grade is an A";
                    }
                    else if (gpa > 2.0)
                    {
                        lblResults.Text = $"Your letter grade is a B";
                    }
                    else if (gpa > 1.0)
                    {
                        lblResults.Text = $"Your letter grade is a C";
                    }
                    else if (gpa > 0.0)
                    {
                        lblResults.Text = $"Your letter grade is a D";
                    }
                    else
                    {
                        lblResults.Text = $" Your letter grade is an F";
                    }
                }
            }
        }
    }
}
