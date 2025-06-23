using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnAdmit_Click(object sender, EventArgs e)
        {
            if (float.TryParse(txtGpa.Text, out float gpa) && int.TryParse(txtAdmission.Text, out int testScore))
            {
                bool isAccepted = IsStudentAccepted(gpa, testScore);
                if (isAccepted) 
                {
                    lblResults.Text = $"Accepted";
                }
                else
                {
                    lblResults.Text = $"Rejected";
                }
            }
            else 
            {
                lblResults.Text = $"Please enter valid numbers.";
            }
        }
        private bool IsStudentAccepted(float gpa, int testScore) 
        {
            return (gpa >= 3.0 && testScore >= 60 || gpa < 3.0 && testScore >= 80);
        }
          
    }
}
