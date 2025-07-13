using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LB1
{
    public partial class Form1 : Form
    {
        Order anOrder;
        double grandTotal = 0;
        public Form1()
        {
            InitializeComponent();
        }

        private void DisplaySundae()
        {
            rtbOutput.Text += "Sundae - ";

            int toppingCount = anOrder.Sundae.ToppingCount;

            if (toppingCount == 0)
            {
                rtbOutput.Text += anOrder.Sundae.GetTopping(0) + " - ";
            }
            else
            {
                for (int i = 0; i < toppingCount; i++)
                {
                    rtbOutput.Text += anOrder.Sundae.GetTopping(0) + " - ";
                }
            }
            rtbOutput.Text += anOrder.Sundae.Price.ToString("C") + "\n";
        }

        private void DisplaySoda()
        {
            rtbOutput.Text += "Soda - ";

            rtbOutput.Text += anOrder.Soda.Flavor + " - ";

            rtbOutput.Text += anOrder.Soda.Price.ToString("C") + "\n";
        }
        private void button1_Click(object sender, EventArgs e)
        {

            string userName = txtUserName.Text;

            if ((chkSundae.Checked || chkSoda.Checked) && !String.IsNullOrEmpty(userName))
            {
                bool isValid = true;
                lblNameOfFoodError.Visible = false;

                anOrder = new Order(userName, chkSundae.Checked, chkSoda.Checked);

                if (chkSundae.Checked)
                {

                    if (chkSprinkles.Checked && chkNuts.Checked && chkSyrup.Checked)
                    {
                        lblToppingError.Visible = true;
                        isValid = false;
                    }
                    else
                    {
                        lblToppingError.Visible = false;
                        if (chkSprinkles.Checked) anOrder.Sundae.AddTopping(SundaeTopping.SPRINKLES);
                        if (chkNuts.Checked) anOrder.Sundae.AddTopping(SundaeTopping.NUTS);
                        if (chkSyrup.Checked) anOrder.Sundae.AddTopping(SundaeTopping.CHOCOLATE_SYRUP);
                    }
                }
                if (chkSoda.Checked)
                {

                    if (chkLime.Checked && chkPeach.Checked || chkLime.Checked && chkMango.Checked)
                    {
                        lblMixinError.Visible = true;
                        isValid = false;
                    }
                    else
                    {
                        lblNameOfFoodError.Visible = false;

                        if (chkLime.Checked) anOrder.Soda.AddFlavor(SodaFlavor.LIME);
                        if (chkPeach.Checked) anOrder.Soda.AddFlavor(SodaFlavor.PEACH);
                        if (chkMango.Checked) anOrder.Soda.AddFlavor(SodaFlavor.MANGO);
                    }
                }
                if (isValid)
                {


                    grandTotal += anOrder.Price;
                    lblTotalPrice.Text = grandTotal.ToString("C");

                    rtbOutput.Text += anOrder.Name;
                    rtbOutput.Text += "\n----------------";
                    if (anOrder.Soda.Equals(null))
                    {
                        if (anOrder.Soda == null)
                        {
                            DisplaySundae();
                            rtbOutput.Text += "\n";
                        }
                        else if (anOrder.Sundae == null)
                        {
                            DisplaySoda();
                            rtbOutput.Text += "\n";
                        }
                        else
                        {
                            DisplaySundae();
                            DisplaySoda();
                            rtbOutput.Text += "\n";
                        }

                    }
                    else if (anOrder.Sundae.Equals(null))
                    {
                        rtbOutput.Text = "SODA";
                    }
                    else
                    {
                        rtbOutput.Text += "BOTH";
                    }
                }
                else
                {
                    lblNameOfFoodError.Visible = true;
                }

            }
        }

        private void chkSundae_CheckedChanged(object sender, EventArgs e)
        {
            if (chkSundae.Checked)
            {
                grpSundaeToppings.Visible = true;
            }
            else
            {
                grpSundaeToppings.Visible = false;
            }
        }

        private void chkSoda_CheckedChanged(object sender, EventArgs e)
        {
            grpDrinkMixins.Visible = chkSoda.Checked ? true : false;
        }
    }
}
