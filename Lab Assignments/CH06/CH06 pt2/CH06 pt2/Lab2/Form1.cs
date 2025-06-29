using System;
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

        private void btnSort_Click(object sender, EventArgs e)
        {
            string input = txtEntry.Text;
            if (!string.IsNullOrWhiteSpace(input))
            {
                string[] enteredWords = input.Split();
                SortWords(enteredWords);
                lblResults.Text = $"{string.Join(" ", enteredWords )}";
              

            }
        }

        public void SortWords(string[] unsortedWords)
        {
            Array.Sort(unsortedWords);
        }
    }
}
