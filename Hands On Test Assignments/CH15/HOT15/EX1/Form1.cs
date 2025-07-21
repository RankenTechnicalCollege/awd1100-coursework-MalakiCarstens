using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EX1
{
    public partial class Form1 : Form
    {
        public ILoan createLoan;
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCreateLoan_Click(object sender, EventArgs e)
        {
            string inputName = txtName.Text.ToLower();
            if (!double.TryParse(txtAmount.Text, out double balance) || balance <= 0 )
            {
                lblError.Text = "Error please try again.";
                return;
            }
            if (chkShortTerm.Checked )
            {
                createLoan = new ShortTermLoan(inputName, "Short Term", balance);
            }
            else if (chkLongTerm.Checked )
            {
                createLoan = new LongTermLoan(inputName, "Long Term", balance);
            }
            else
            {
                lblError.Text = "Please select loan type.";
                return;
            }
            lblNameField.Text = $"{createLoan.Name}";
            lblLoanPrice.Text = $"{createLoan.Type} loan of {createLoan.Balance:C}";
        }

        private void btnMakePayment_Click(object sender, EventArgs e)
        {
            if (createLoan == null)
            {
                lblError.Text = "You must have a loan to make a payment.";
                return;
            }

            lblError.Text = "";



            createLoan.MakePayment();

          if(createLoan.Balance <= 0)
            {
                lblResults.Text = "Your loan has successfully been paid off.";
                lblResults.Text = "";
                return;

            }

          lblResults.Text = $"After the last payment the loan is down to {createLoan.Balance:C}.";

            createLoan.ApplyInterest();

            lblAccumulation.Text = $"After the last interest accumulation your loan is now {createLoan.Balance:C}.";
         



        }

    }
}
