using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string[] firstNames = { "Markel", "Luiza", "Bryony", "Giraldo", "Lowri" };
            string[] lastNames = { "Diggory", "Gunnar", "Hester", "Addy", "Hari" };
            string[] phoneNumber = { "555-8390", "555-4618", "555-4440", "555-16897", "555-7763"};

            string input = txtInput.Text.ToLower();
            bool found = false;
            for (int i = 0; i < firstNames.Length; i++) 
            {
                if (firstNames[i].ToLower().Contains(input) || lastNames[i].ToLower().Contains(input))   
                {
                    lblResults.Text = $"First Name: {firstNames[i]}\n Last Name: {lastNames[i]}\n Phone Number: {phoneNumber[i]}";
                    found = true;
                    break;
                }
            }
            if (!found) 
            {
                lblResults.Text = $"No first name, last name, or phone number have been found. Please try again.";
            }
        }
    }
}
