using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CH10
{
    public partial class Form1 : Form
    {
        List<Occasion> occasions = new List<Occasion>();
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            occasions.Add(new Occasion("birthday", new List<Style>
            {
                new Style("birthday1", 3.99m, Properties.Resources.birthday),
                new Style("birthday2", 5.99m, Properties.Resources.birthday2)
            }
            ));
            occasions.Add(new Occasion("valentine's", new List<Style>
            {
                new Style("valentine1", 1.75m, Properties.Resources.valentinecard),
                new Style("valentine2", 2.25m, Properties.Resources.valentinecard2)
            }));
            occasions.Add(new Occasion("happy holidays", new List<Style>
            {
                new Style("happy holidays1", 4.84m, Properties.Resources.holidayshiny),
                new Style("happy holidays2", 2.34m, Properties.Resources.HolidayFoilCards)
            }));

            cboOccasion.Items.AddRange(occasions.ToArray());
        }

        private void cboOccasion_SelectedIndexChanged(object sender, EventArgs e)
        {
            cboStyle.Items.Clear();
            Occasion selection = (Occasion)cboOccasion.SelectedItem;
            cboStyle.Items.AddRange(selection.Styles.ToArray());
        }

        private void cboStyle_SelectedIndexChanged(object sender, EventArgs e)
        {
            Style selection = (Style)cboStyle.SelectedItem;
            lblResults.Text = selection.ToString();
            pbImage.Image = selection.Image;
        }

        private void rtbMessage_TextChanged(object sender, EventArgs e)
        {
            lblMessage.Text = rtbMessage.Text;
        }
        private void UpdateTotal()
        {
            Order order = new Order
            {
                selectedOccasion = (Occasion)cboOccasion.SelectedItem,
                selectedStyle = (Style)cboStyle.SelectedItem,
                AddEnvelope = chkEnvelope.Checked,
                AddStamp = chkStamp.Checked,
                AddMessage = chkMessage.Checked
            };
            decimal total = order.CalculateTotal();
            lblResults.Text = total.ToString("C");
        }

        private void chkEnvelope_CheckedChanged(object sender, EventArgs e)
        {
            UpdateTotal();
        }

        private void chkStamp_CheckedChanged(object sender, EventArgs e)
        {
            UpdateTotal();
        }

        private void chkMessage_CheckedChanged(object sender, EventArgs e)
        {
            UpdateTotal();
        }

        private void Field_Enter(object sender, EventArgs e)
        {
            if (sender is Control c)
            {
                c.BackColor = Color.LightGreen;
            }
        }
        private void Field_Leave(object sender, EventArgs e)
        {
            if (sender is Control c)
            {
                c.BackColor = Color.White;
            }
        }
        
    }
}
