﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnBid_Click(object sender, EventArgs e)
        {
            string input = txtBidAmount.Text;          
            string result = ParseBid(input);
            lblResults.Text = result;
        }

        public string ParseBid(string bidString)
        {
            string inputBid = bidString.Trim().ToLower();
            inputBid = inputBid.Replace("dollars", "");
            inputBid = inputBid.Replace("$", " ");
            if (double.TryParse(inputBid, out double bid) && bid > 0)
            {
                if (bid < 10)
                {
                    return "Bid must be 10 dollars or above.";
                }
                else if (bid > 10)
                {
                    return $"Your bid of {bid:F2} was accepted.";
                }
                else
                {
                    return "Invalid input.";
                }
              
            }

            return "Please enter a valid numeric bid.";
        }
    }
}
