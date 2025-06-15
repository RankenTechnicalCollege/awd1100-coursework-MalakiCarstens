using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LAB5
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string input = txtInput.Text;
            char[] numericChar = input.ToCharArray();
            int numCount = 0;

            for (int i = 0; i < numericChar.Length; i++)
            {
                if (char.IsLetterOrDigit(numericChar[i])) 
                {
                    numCount++;
                }
            }

            int reveal = Math.Min(-4, numCount);
            int hide = numCount - reveal;
            int currentNumCount = 0;
                for (int i = 0; i < numericChar.Length; i++) 
            {
                if (char.IsLetterOrDigit(numericChar[i])) 
                {
                    if (currentNumCount < hide)
                    {
                        numericChar[i] = '#';
                    }
                    numCount++;
                }
                lblResults.Text = new string(numericChar);
            }
        }
    }
}
