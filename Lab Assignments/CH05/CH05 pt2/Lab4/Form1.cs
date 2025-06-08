using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab4
{
    public partial class Form1 : Form
    {
        double danielleSales = 0;
        double edwardSales = 0;
        double francisSales = 0;

        public Form1()
        {
            InitializeComponent();
        }

        private void AddSale(string name)
        {
            double amount;

            if (double.TryParse(txtBox.Text, out amount) && amount >= 0)
            {
                if (name == "Danielle")
                    danielleSales += amount;
                else if (name == "Edward")
                    edwardSales += amount;
                else if (name == "Francis")
                    francisSales += amount;

                lblResults.Text = $"Added ${amount:F2} to {name}'s sales.";
            }
            else
            {
                lblResults.Text = $"Please enter a valid positive number.";
            }
        }



        private void btnDanielle_Click(object sender, EventArgs e)
        {
            AddSale("Danielle");
        }
        private void btnEdward_Click(object sender, EventArgs e)
        {
            AddSale("Edward");
        }
        private void btnFrancis_Click_1(object sender, EventArgs e)
        {
            AddSale("Francis");
        }


        private void btnSummary_Click(object sender, EventArgs e)
        {
            double total = danielleSales + edwardSales + francisSales;
            string topSalesperson = "Danielle";
            double top = danielleSales;

            if (edwardSales > top)
            {
                topSalesperson = "Edward";
                top = edwardSales;
            }

            if (francisSales > top)
            {
                topSalesperson = "Francis";
                top = francisSales;
            }

            lblResults.Text =
                $"Danielle: ${danielleSales:F2}\n" +
                $"Edward:   ${edwardSales:F2}\n" +
                $"Francis:  ${francisSales:F2}\n" +
                $"Total:    ${total:F2}\n\n" +
                $"Top Salesperson: {topSalesperson} with ${top:F2}";
        }

    }
}