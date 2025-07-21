using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CH14
{
    public partial class Form1 : Form
    {
        Letter sentLetter;
        List<Letter> letters = new List<Letter>();
        public Form1()
        {
            InitializeComponent();
        }

        private void btnSend_Click(object sender, EventArgs e)
        {
            lblError.Text = "";

           string recipientName = txtRecipient.Text.ToLower();
            if ( recipientName == null ) {
                lblError.Text = "Please fill out all fields.";
                return;
            }
            if (!DateTime.TryParse(txtSent.Text, out DateTime sentDate))
            {
                lblError.Text = "Please enter valid date.";
                return;
            }
            if (!string.IsNullOrEmpty(txtTracking.Text))
            {
                string tracking = txtTracking.Text;
                sentLetter = new CertifiedLetter(recipientName, sentDate, tracking);
            }
            else
            {
                sentLetter = new Letter(recipientName, sentDate);
            }
            if (letters.Count >= 20)
            {
                lblError.Text = "Max number of letters sent.";
                return;
            }

            letters.Insert(0, sentLetter);

            string result = "";
            foreach (Letter letter in letters)
            {
                result += letter.ToString() + "\n";
            }

            lblResults.Text = result;
        }
    }
}
