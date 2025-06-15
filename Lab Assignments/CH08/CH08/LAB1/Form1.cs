using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LAB1
{
    public partial class Form1 : Form
    {

        string[] zipCodes = new string[]
        {
            "63101", "63103", "63105", "63109", "63113", "63118", "63130", "63133", "63136", "63137"
        };

        int[] deliveryFee = new int[]
        {
            20, 12, 25, 15, 10, 23, 18, 20, 17, 12
        };
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            bool found = false;
            string zip = txtZipCodes.Text;
            for (int i = 0; i < zipCodes.Length; i++)
            {
                if (zip == zipCodes[i])
                {
                    lblResults.Text = $"Delivery Charge {deliveryFee[i]:F2}";
                    found = true;
                    break;
                }
                if (!found)
                {
                    lblResults.Text = $"Sorry your zip code is not somewhere we deliver.";
                }
            }
        }
    }
}
