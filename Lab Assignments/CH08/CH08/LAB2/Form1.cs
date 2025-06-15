using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LAB2
{
    public partial class btnCalculate : Form
    {
        public btnCalculate()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string[] nights = { "1-2", "3-4", "5,7", "8 or up" };
            int[] cost = { 200, 180, 160, 145 };
            int rate = 0;

            if (int.TryParse(txtNight.Text, out int daysStayed))
            {
                for (int i = 0; i < nights.Length; i++)
                {
                    if (nights[i] == "1-2" && daysStayed <= 2 && daysStayed >= 1)
                    {
                        rate = cost[i];
                        lblResults.Text = $"Cost: {cost[i]}";
                    }
                    else if (nights[i] == "3-4" && daysStayed <= 4 && daysStayed >= 3)
                    {
                        rate = cost[i];
                        lblResults.Text = $"Cost: {cost[i]}";
                    }
                    else if (nights[i] == "5-7" && daysStayed <= 7 && daysStayed >= 5)
                    {
                        rate = cost[i];
                        lblResults.Text = $"Cost: {cost[i]}";
                    }
                    else if (nights[i] == "8 or up" && daysStayed >= 8)
                    {
                        rate = cost[i];
                        lblResults.Text = $"Cost: {cost[i]}";
                    }
                }
                int total = daysStayed * rate;
                lblNightlyResults.Text = $"Nightly Cost {rate:C}";
                lblResults.Text = $"Total cost of stay {total:C}";
            }
            else 
            {
                lblResults.Text = $"Error no valid number(s) entered.";
            }
        }
    }
}
