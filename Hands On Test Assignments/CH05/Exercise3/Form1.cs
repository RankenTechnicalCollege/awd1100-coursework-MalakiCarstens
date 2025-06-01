using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Exercise3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            if (double.TryParse(txtLength.Text, out double length) && double.TryParse(txtWidth.Text, out double width))
            {
                double area = length * width;
                lblArea.Text = $"Lawn Area {area} square feet";
                double weeklyFee;
                if (area >= 600)
                {
                    weeklyFee = 50;
                    lblWeeklyFee.Text = $"Your fee is 50";
                }
                else if (area >= 400)
                {
                    weeklyFee = 35;
                    lblWeeklyFee.Text = $"Your fee is 35";
                }
                else
                {
                    weeklyFee = 25;
                    lblWeeklyFee.Text = $"Your fee is 25";
                }
                double totalSeasonFee = weeklyFee * 20;
                lblTotal.Text = $"Weekly Fee $ {weeklyFee} total for 20 weeks $ {totalSeasonFee}";
            }
            else
            {
                lblTotal.Text = $"Please enter a valid input.";
            }
        }
    }
}