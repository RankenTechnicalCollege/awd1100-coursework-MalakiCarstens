using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LB2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnValidate_Click(object sender, EventArgs e)
        {
            try
            {
                short itemNumber = short.Parse(txtItemNum.Text);
                if (itemNumber < 100 || itemNumber > 999)
                {
                    throw new InvalidItemNumberException("Invalid Item Number");
                }
                byte quantity = byte.Parse(txtQuantity.Text);
                if (quantity < 1 || quantity > 12)
                {
                    throw new InvalidQuantityException("Invalid Item Quantity");
                }
                byte delivery = byte.Parse(txtEstimate.Text); 
                if (delivery < 1 || delivery > 30)
                {
                    throw new InvalidDeliveryDaysException("Invalid Delivery Day");
                }
                lblResults.Text = "Order is valid";
            }
            catch (InvalidItemNumberException ex)
            {
                MessageBox.Show(ex.Message);
            }
            catch (InvalidQuantityException ex)
            {
                MessageBox.Show(ex.Message);
            }
            catch (InvalidDeliveryDaysException ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
