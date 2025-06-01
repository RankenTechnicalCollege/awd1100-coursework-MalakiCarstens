﻿using System;
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

        private void button1_Click(object sender, EventArgs e)
        {
            if (double.TryParse(txtWindInput.Text, out double wind))
            {
             
                    if (wind >= 157)
                    lblCategory.Text = $"Category 5";
            }
            else if (wind >= 130)
            {
                lblCategory.Text = $"Category 4";
            }
            else if (wind >= 111)
            {
                lblCategory.Text = $"Category 3";
            }
            else if (wind >= 96)
            {
                lblCategory.Text = $"Category 2";
            }
            else if (wind >= 74)
            {
                lblCategory.Text = $"Category 1";
            }

            else
            {
                lblCategory.Text = $"Not a hurricane.";
            }
        }

        
    }
}
