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

        private void calculate_Click(object sender, EventArgs e)
        {
            try
            {
                int eggs1 = int.Parse(txtChicken1.Text);
                int eggs2 = int.Parse(txtChicken2.Text);
                int eggs3 = int.Parse(txtChicken3.Text);
                int eggs4 = int.Parse(txtChicken4.Text);

                int totalEggs = eggs1 + eggs2 + eggs3 + eggs4;

                int dozens = totalEggs / 12;
                int leftover = totalEggs % 12;

                lblResult.Text = $"{dozens} dozen and {leftover} eggs. {totalEggs} eggs total";
            }
            catch (FormatException) 
            {
                lblResult.Text = "Please enter valid numbers.";
            }
        }
    }
}
