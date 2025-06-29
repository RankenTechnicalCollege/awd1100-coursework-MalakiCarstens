using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EX2
{
    public partial class Form1 : Form
    {
        const double SHIRT_COST = 13.75;
        const double TAX_RATE = 0.08;
        public Form1()
        {
            InitializeComponent();
        }


        private void btnOrder_Click(object sender, EventArgs e)
        {
            if (int.TryParse(txtQuantity.Text, out int quantity) && quantity > 0 )
            {
                string code = txtDiscount.Text;
                float discount = CheckDiscountCode(code);
                ShowInvoice(quantity, discount);
            }
            else 
            {
               lblError.Text = $"* Invalid Data";
            }
        }
        private float CheckDiscountCode(string code)
        {
            string[] codes = { "8264", "5679", "6483" };
            float[] discounts = { 0.30f, 0.20f, 0.10f };
            for (int i = 0; i < codes.Length; i++)
            {
                if (code == codes[i])
                {
                    return discounts[i];
                }
            }
            return 0;
        }

        private void ShowInvoice(int quantity, float discountPercent)
        {
            double preTotal = quantity * SHIRT_COST;
            double discountAmount = preTotal * discountPercent;
            double subTotal = preTotal - discountAmount;
            double tax = subTotal * TAX_RATE;
            double grandTotal = subTotal + tax;

            lblResults.Text = $"{quantity} T-Shirts @ {SHIRT_COST}\n\n Subtotal: {subTotal:F2}\n Tax: {tax:F2}\n Total: {grandTotal:F2}";
        }
    }
}
