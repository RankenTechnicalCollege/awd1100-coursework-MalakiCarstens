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
        const double KM_PER_MILE = 1.6;
        public Form1()
        {
            InitializeComponent();
        }

        private void btnConvertKm_Click(object sender, EventArgs e)
        {
            double miles = Convert.ToDouble(txtInput.Text);
            double kilometers = KM_PER_MILE * miles;
            lblResults.Text = $"{miles} miles is {kilometers} in kilometers.";
        }

        private void btnConvertMiles_Click(object sender, EventArgs e)
        {
            double kilometers = Convert.ToDouble(txtInput2.Text);
            double miles = kilometers / KM_PER_MILE;
            lblResults.Text = $"{kilometers} kilometers is {miles} in miles";
        }
    }
}
