using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LB4
{
    public partial class Form1 : Form
    {
        Student[] students = new Student[3];
        public Form1()
        {
            InitializeComponent();
            students[0] = new Student("David", "Jane", "AWD 1000", "B", 2.9m);
            students[1] = new Student("Alex", "Scott", "AWD 1100", "A", 3.8m);
            students[2] = new Student("Aaron", "Bale", "AWD 1100", "D", 1.3m);

        }

        private void btnFirstNameSearch_Click(object sender, EventArgs e)
        {
            string firstName = txtFirstName.Text;
            
            foreach (Student studentFirstName in students)
            {
                if (studentFirstName.FirstName == txtFirstName.Text)
                {
                    lblStudentInfo.Text = studentFirstName.ToString();
                    return;
                }
            }
        }

        private void btnLastNameSearch_Click(object sender, EventArgs e)
        {
            string lastName = txtLastName.Text;

            foreach (Student studentLastName in students)
            {
                if (studentLastName.LastName == txtLastName.Text)
                {
                    lblStudentInfo.Text = studentLastName.ToString();
                    return;
                }
            }
        }
        private void txtFirstName_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnFirstNameSearch.PerformClick();
            }
        }
        private void txtLastName_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnLastNameSearch.PerformClick();
            }
        }
    }
}
