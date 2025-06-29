using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (int.TryParse(txt1.Text, out int n1) && int.TryParse(txt2.Text, out int n2) && int.TryParse(txt3.Text, out int n3) && int.TryParse(txt4.Text, out int n4))
            {
                Reverse4(ref n1, ref n2, ref n3, ref n4);
                lblResults.Text = $"Your numbers reversed are {n1}, {n2},{n3}, {n4}";
            }
            else
            {
                lblResults.Text = $"Please enter only numbers.";
            }
        }

        public void Reverse4(ref int num1, ref int num2, ref int num3, ref int num4)
        {
            int entry1 = num1;
            int entry2 = num2;
            int entry3 = num3;
            int entry4 = num4;

            num1 = num4;
            num2 = num3;
            num3 = num2;
            num4 = num1;
        }
    }
}
