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

namespace LB4
{
    public partial class Form1 : Form
    {
        List<Account> accounts = new List<Account>();
        Account currentUser = null;
        public Form1()
        {
            InitializeComponent();
            accounts.Add(new Account("6214", "5678", 500));
            accounts.Add(new Gold("7123", "2950", 5400));
            accounts.Add(new Silver("8563", "0932", 4090));
            accounts.Add(new Account("0164", "5523", 20));
            accounts.Add(new Gold("8012", "3272", 10000000000));
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string accountNum = txtAccount.Text;
            string pin = txtPin.Text;
            foreach (Account account in accounts)
            {
                if (account._accountNum == txtAccount.Text && account.GetPin == txtPin.Text)
                {
                    currentUser = account;
                    lblEntry.Text = $"Welcome!\n Your balance is {account.GetBalance():C}\n Your Account Type is {account.GetType().Name}";
                    return;
                }
                else
                {
                    lblEntry.Text = "Invalid Entry. Please try again.";
                }
            }
        }

        private void btnDeposit_Click(object sender, EventArgs e)
        {
            if (double.TryParse(txtDeposit.Text, out double deposit))
            {
                currentUser.Deposit(deposit);
            }
            else
            {
                lblEntry.Text = "Invalid Deposit.";
            }
        }

        private void btnWithdraw_Click(object sender, EventArgs e)
        {
            if (double.TryParse(txtWidthdraw.Text, out double widthdraw))
            {
                currentUser.Withdraw(widthdraw);
            }
            else
            {
                lblEntry.Text = "Invalid Withdrawal";
            }
           
        }

        private void btnPrint_Click(object sender, EventArgs e)
        {
            if (currentUser is Gold)
            {
                string results = "***You qualify for Gold!***\n" + string.Join("\n", currentUser.Transactions);
                MessageBox.Show(results, "Bank Statement");
            }
            else if (currentUser is Silver)
            {
                string results = string.Join("\n", currentUser.Transactions);
                MessageBox.Show(results, "Bank Statement");
            }
            else
            {
                lblEntry.Text = "Bronze";
            }
            
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            currentUser = null;
            lblEntry.Text = string.Empty;
        }
    }
}
