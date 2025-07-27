using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LB3
{
    public partial class Form1 : Form
    {  
        BankForm bankForm = new BankForm();
        public Form1()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            try
            {
                string userName = txtUsername.Text;
                string password = txtPassword.Text;
                Account foundList = bankForm.Login(userName, password);
                lblResults.Text = $"Welcome {foundList.FirstName}.";
            }
            catch (NoUsernamePasswordException ex)
            {
                MessageBox.Show(ex.Message);
            }
            catch (IncorrectPasswordException ex)
            {
                MessageBox.Show(ex.Message);
            }
            catch (AccountDisabledException ex)
            {
                MessageBox.Show(ex.Message);
            }

        }
    }
}
