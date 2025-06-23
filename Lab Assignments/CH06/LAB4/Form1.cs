using System;
using System.CodeDom;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LAB4
{
    public partial class Form1 : Form
    {
        const int HEIGHT = 9;
        const double PRICE_PER_SQFT = 6.0;
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            lblResults.Text = string.Empty;

            if (int.TryParse(txtLength.Text, out int length) && int.TryParse(txtWidth.Text, out int width))
            {
                int areaTotal = CalculateTotalArea(length, width);
                double totalCost = CalculatePaintEstimate(areaTotal);

                lblResults.Text = $"Total Area: {areaTotal} sq ft\n" + $"Estimate Cost: ${totalCost:F2}";
            }
            else 
            {
                lblResults.Text = $"Please enter valid numbers.";
            }
        }

        private int CalculateTotalArea(int length, int width)
        {
            return (length * HEIGHT * 2) + (width * HEIGHT * 2);
        }

        private double CalculatePaintEstimate(int areaTotal) 
        { 
            return areaTotal * PRICE_PER_SQFT;
        }
    }
}
