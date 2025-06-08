using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab5
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string inputPhrase = txtPhraseInput.Text;
            int vowelCount = 0;

            for (int i = 0; i < inputPhrase.Length; i++)
            {
                char c = inputPhrase[i];

                switch (char.ToLower(c))
                {
                    case 'a':
                    case 'e':
                    case 'i':
                    case 'o':
                    case 'u':
                        vowelCount++;
                        break;
                }
            }
            lblResults.Text = $"Vowel count: {vowelCount}";
        }
    }
}
