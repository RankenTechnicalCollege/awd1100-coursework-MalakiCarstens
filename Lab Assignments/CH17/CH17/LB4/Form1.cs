using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LB4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnEncode_Click(object sender, EventArgs e)
        {
            try
            {
                DecoderRing decoded = new DecoderRing();
                decoded.Shift = int.Parse(txtShift.Text);
                lblResults.Text = decoded.Encode(txtEncode.Text);
            }
            catch (InvalidCharacterException ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnDecode_Click(object sender, EventArgs e)
        {
            try
            {
                DecoderRing decoded = new DecoderRing();
                decoded.Shift = int.Parse(txtShift.Text);
                lblResults.Text = decoded.Encode(txtDecode.Text);
            }
            catch (InvalidCharacterException ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
