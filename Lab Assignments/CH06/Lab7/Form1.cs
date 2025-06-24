using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab7
{
    public partial class Form1 : Form
    {
        string[] accountNumbers = { "6251", "7128", "1374", "7289" };
        string[] pins = { "67182", "81782", "89182", "90948" };
        decimal[] balances = { 1000000m, 200000m, 400000m, 140000m };
        int loggedInIndex = -1;
        public Form1()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string account = txtAccountNum.Text;
            string pin = txtPinNum.Text;
            Login(account, pin);
        }

        private void btnDeposit_Click(object sender, EventArgs e)
        {
            if (decimal.TryParse(txtDeposit.Text, out decimal amount) && amount > 0)
            {
                MakeDeposit(amount);
            }
            else
            {
                lblResults.Text = $" Error please try again.";
            }
        }

        private void btnWithdrawal_Click(object sender, EventArgs e)
        {
            if (decimal.TryParse(txtWithdrawal.Text, out decimal amount) && amount > 0)
            {
                MakeWithdrawal(amount);
            }
            else
            {
                lblResults.Text = $" Error please try again.";
            }
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            Logout();
        }


    private void Login(string accountNum, string pin)
        {
            for (int i = 0; i < accountNumbers.Length; i++)
            {
                if (accountNumbers[i] == accountNum && pins[i] == pin)
                {
                    loggedInIndex = i;
                    lblResults.Text = $"Welcome to Weyland bank. Your balance is {balances[i]:F2}";
                    return;
                }
            }

            Logout();
            lblResults.Text = $"Invalid entry please try again.";
        }

        private void Logout()
        {
            loggedInIndex = -1;
            lblResults.Text = "";
        }

        private void MakeWithdrawal(decimal withdrawalAmount) 
        {
            if (loggedInIndex != -1)
            {
                if (withdrawalAmount <= balances[loggedInIndex])
                {
                    balances[loggedInIndex] = balances[loggedInIndex] - withdrawalAmount;
                    lblResults.Text = $"Your new balance is {balances[loggedInIndex]:F2}";
                }
                else
                {
                    lblResults.Text = $"Insufficient money to make withdrawal.";
                }
            }
        }

        private void MakeDeposit(decimal depositAmount)
        {
            if (loggedInIndex != -1)
            {
                balances[loggedInIndex] = depositAmount + balances[loggedInIndex];
                lblResults.Text = $"Your new balance is {balances[loggedInIndex]:F2}";
            }

            else 
            {
                lblResults.Text = $"You must be logged in to make deposits/withdrawals.";        
            }
        }

    }
}
