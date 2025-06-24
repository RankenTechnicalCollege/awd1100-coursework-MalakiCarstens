using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab3
{
    public partial class Form1 : Form
    {
        string[] vowels = { "a", "e", "i", "o", "u" };
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //string[] vowels = { "a", "e", "i", "o", "u" };
            string input = txtInput.Text;
            int vowelCount = CountVowels(input);
            lblResults.Text = $"Your Phrase has {vowelCount} vowels.";
            ;
        }
        private int CountVowels(string phrase) 
        {
            int count = 0;
            string lowerPhrase = phrase.ToLower();
            for (int i = 0; i < lowerPhrase.Length; i++) 
            { 
                string currentChar = lowerPhrase[i].ToString();
                for (int j = 0; j < vowels.Length; j++) 
                {
                    if (currentChar == vowels[j]) 
                    {
                        count++; 
                        break;
                    }
                }

            }
            return count;
 
        }
    }
}
