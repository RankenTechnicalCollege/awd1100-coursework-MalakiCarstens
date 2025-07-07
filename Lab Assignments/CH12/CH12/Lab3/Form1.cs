using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab3
{
    public partial class Form1 : Form
    {
        Account currentUser = null;
        List<Account> bankAccounts = new List<Account>();
        public Form1()
        {
            InitializeComponent();
            bankAccounts.Add(new Account("1234567", "8924", "Sam Green", 1000.00m));
            bankAccounts.Add(new Account("7654321", "7631", "Alex Bumble", 1230.00m));
            bankAccounts.Add(new Account("1357901", "0091", "Enid Rile", 4000.00m));
            bankAccounts.Add(new Account("9940427", "5913", "Eric Derek Meric", 500000000.00m));
            bankAccounts.Add(new Account("1098765", "6512", "Leon Mel", 100000000000.00m));
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
           Login(txtAccountInput.Text, txtPinInput.Text);
        }

        private void btnDeposit_Click(object sender, EventArgs e)
        {
            if (decimal.TryParse(txtDeposit.Text, out decimal amount))
            {
                MakeDeposit(amount);
            }
            else
            {
                lblResults.Text = "Please enter a valid amount.";
            }
        }

        private void btnWithdraw_Click(object sender, EventArgs e)
        {
            if (decimal.TryParse(txtWithdraw.Text, out decimal amount))
            {
                MakeWithdrawal(amount);
            }
            else
            {
                lblResults.Text = "Please enter a valid amount.";
            }

        }
        public void Login(string accountNumber, string pin)
        {
            foreach (Account account in bankAccounts)
            {
                if (account.GetAccountNumber() == accountNumber &&  account.GetPin() == pin)
                {
                    currentUser = account;
                    lblResults.Text = $"Welcome {currentUser.GetName()}!\n Your current balance is {currentUser.GetBalance():F2}";
                    return;
                }
                else
                {
                    lblResults.Text = "Invalid login please try again.";
                }
            }
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            Logout();
        }
       public void Logout()
        {
            currentUser = null;
            lblResults.Text = "Log out successful";
        }
        public void MakeDeposit(decimal amount)
        {
            if (currentUser != null)
            {
                currentUser.Deposit(amount);
                lblResults.Text = $"Deposit successful. Your new balance is {currentUser.GetBalance():F2}";
            }
            else
            {
                lblResults.Text = "Please login.";
            }
        }
        public void MakeWithdrawal(decimal amount)
        {
            if (currentUser != null)
            {
                if (currentUser.Withdraw(amount))
                {
                    lblResults.Text = $"Withdrawal successful. Your new balance is {currentUser.GetBalance():F2}";
                }
                else
                {
                    
                    lblResults.Text = $"Withdrawal successful. Your new balance is {currentUser.GetBalance():F2}";
                }

                
            }
        }
    }
}
