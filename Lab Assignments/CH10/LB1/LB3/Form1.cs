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
        public Form1()
        {
            InitializeComponent();
        }
        private void AnyTextBox_Click(object sender, EventArgs e)
        {
            
            TextBox t = (TextBox)sender;
            t.BackColor = Color.Yellow;
        }

        private void AnyTextBoxFocus(object sender, EventArgs e)
        {
            TextBox t = (TextBox)(sender);
            t.BackColor = Color.LightBlue;
        }

        private void AnyTextBoxLeave(object sender, EventArgs e)
        {
            TextBox t = (TextBox)sender;
            t.BackColor = Color.LightGray;
        }

        private void AnyTextBox_KeyDown(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.Up:
                    txtOne.Focus();
                    break;
                case Keys.Right:
                    txtThree.Focus();
                    break;
                case Keys.Down:
                    txtFive.Focus();
                    break;
                case Keys.Left:
                    txtSeven.Focus();
                    break;

            }
        }
    }
}
