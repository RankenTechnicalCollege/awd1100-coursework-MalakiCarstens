using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EX2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnArithmetic_Click(object sender, EventArgs e)
        {
            try 
            {
                int instance1 = 62;
                int instance2 = 0;
                int total = instance1 / instance2;
            }
            catch (ArithmeticException ex) 
            {
                MessageBox.Show("Invalid can not divide by zero.");
            }
        }

        private void btnFormat_Click(object sender, EventArgs e)
        {
            try
            {
                string input = "Mary had a little lamb.";
                double rhyme = double.Parse(input);
            }
            catch (FormatException ex)
            {
                MessageBox.Show("Invalid please enter a valid input.");
            }
        }

        private void btnInvalid_Click(object sender, EventArgs e)
        {
            try
            {
                object number = "0, 1, 2, 3, 4, 5";
                double value = (double) number;
            }
            catch (InvalidCastException ex)
            {
                MessageBox.Show("Invalid can not convert string to double.");
            }
        }

        private void btnNull_Click(object sender, EventArgs e)
        {
            try
            {
                string student1 = null;
                int studentId = student1.Length;
            }
            catch (NullReferenceException ex)
            {
                MessageBox.Show("Invalid input is set to null.");
            }
        }
    }
}
