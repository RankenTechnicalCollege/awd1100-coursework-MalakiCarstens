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
            string input = txtCardNum.Text;
            string mask = MaskNumber(input, '#', 4);
            lblResults.Text = $"Masked: {mask}";
        }

        private string MaskNumber(string unmaskedCC, char replacementChar, int numDigitsToPreserve)
        {
            int totalToPreserve = numDigitsToPreserve;
            int countDigit = 0;

            for (int i = 0; i < unmaskedCC.Length; i++)
            {
                char current = unmaskedCC[i];
                if (Char.IsDigit(current) || Char.IsLetter(current))
                {
                    countDigit++;
                }
            }

            int maskUntil = countDigit - totalToPreserve;
            int letterOrDigitSeen = 0;
            string result = "";

            for (int i = 0; i < unmaskedCC.Length; i++)
            {
                char current = unmaskedCC[i];

                if (Char.IsDigit(current) || Char.IsLetter(current))
                {
                    if (letterOrDigitSeen < maskUntil)
                    {
                        result += replacementChar;
                    }
                    else
                    {
                        result += current;
                    }
                    letterOrDigitSeen++;
                }
                else
                {
                    result += current;
                }

            }
            return result;

        }
    }
}
           
