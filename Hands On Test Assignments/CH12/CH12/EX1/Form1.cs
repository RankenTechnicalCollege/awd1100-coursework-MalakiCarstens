using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EX1
{
    public partial class Form1 : Form
    {
        string[] hash = new string[] { "e10adc3949ba59abbe56e057f20f883e", "25f9e794323b453885f5181f1b624d0b", "d8578edf8458ce06fbc5bb76a58c5ca4", "96e79218965eb72c92a549dd5a330112", "5f4dcc3b5aa765d61d8327deb882cf99", "6eea9b7ef19179a06954edd0f6c05ceb", "c8837b23ff8aaa8a2dde915473ce0991", "c822c1b63853ed273b89687ac505f9fa", "161ebd7d45089b3446ee4e0d86dbcf92", "4ece57a61323b52ccffdbef021956754" };
        string[] passwords = new string[] { "123456", "123456789", "qwerty", "111111", "password", "qwertyuiop", "123321", "google", "P@ssw0rd", "Tr0ub4dor&3" };
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCrack_Click(object sender, EventArgs e)
        {
            string input = txtHashInput.Text.ToLower();
            string result = CrackPassword(input);
            if (result != null )
            {
                lblResults.Text = $"{result}";
            }
            else
            {
                lblResults.Text = "FAIL";
            }
        }
        public string CrackPassword(string inputHash)
        {
            for (int i = 0; i < hash.Length; i++)
            {
                if (hash[i] == inputHash)
                {
                    return passwords[i];
                }
            }
            return null; 
        }
    }
}
