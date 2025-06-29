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
        const double PRICE_SMALL = 9.99;
        const double PRICE_MEDIUM = 10.99;
        const double PRICE_LARGE = 11.99;
        const double TAX_RATE = 0.07;
        int smallQty = 0;
        int mediumQty = 0;
        int largeQty = 0;
        public Form1()
        {
            InitializeComponent();
        }

        private void btnSmall_Click(object sender, EventArgs e)
        {
            smallQty++;
            UpdateInvoice();
              
        }

        private void btnMedium_Click(object sender, EventArgs e)
        {
            mediumQty++;
            UpdateInvoice();
        }

        private void btnLarge_Click(object sender, EventArgs e)
        {
            largeQty++;
            UpdateInvoice();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            ClearOrder();
        }

        private void UpdateInvoice() 
        { 
            double subTotal = (smallQty * PRICE_SMALL) + (mediumQty * PRICE_MEDIUM) + (largeQty * PRICE_LARGE);
            double tax = subTotal * TAX_RATE;
            double total = subTotal + tax;
            if (smallQty > 0) 
            { 
                lblResults.Text = $"{smallQty} Small Shirt(s). {PRICE_SMALL:F2} each.\n";
            }
            if (mediumQty > 0)
            {
                lblResults.Text = $"{mediumQty} Medium Shirt(s). {PRICE_MEDIUM} each.\n";
            }
            if (largeQty > 0) 
            { 
                lblResults.Text = $"{largeQty} Larger Shirt(s). {PRICE_LARGE} each\n";
            }
            lblResultsTotal.Text = $"Subtotal: {subTotal:F2}\n Tax: {tax:F2}\n Total: {total:F2}";

        }

        private void AddShirt(string size)
        {
            if (size == "small")
                smallQty++;
            else if (size == "medium")
                mediumQty++;
            else if (size == "large")
                largeQty++;
        
        }

        private void ClearOrder()
        {
            smallQty = 0;
            mediumQty = 0;
            largeQty = 0;
            lblResults.Text = $"Order Cleared.";
            lblResultsTotal.Text = "";
        }
    }
}
