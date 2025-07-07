using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab2
{
    public partial class Form1 : Form
    {
        List<InventoryItem> stock = new List<InventoryItem>();
        const int maxStock = 20;
        private string accessKey = "1234";
        public Form1()
        {
            InitializeComponent();
            stock.Add(new InventoryItem("Television", 54321, 120.00m, 240.00m, 2));
            stock.Add(new InventoryItem("Microphone", 54331, 50.00m, 600.00m, 12));
            stock.Add(new InventoryItem("Keyboard", 54341, 90.98m, 545.88m, 6));
            stock.Add(new InventoryItem("Mouse", 54351, 39.90m, 798.00m, 20));
            stock.Add(new InventoryItem("Gaming Chair", 54351, 249.99m, 999.96m, 4));
        }

        private void btnSearch1_Click(object sender, EventArgs e)
        {
            string name = txtSearchName.Text.ToLower();
            InventoryItem item = null;
            foreach (InventoryItem it in stock)
            {
                if (it.getItemName().ToLower().Contains(name))
                {
                    item = it; 
                    break;
                }
                else
                {
                    lblResults.Text = "Item not found.";
                }
            }
        }

        private void btnSearch2_Click(object sender, EventArgs e)
        {
            if (int.TryParse(txtSearchUPC.Text, out int upc))
            {
                InventoryItem item = null;
                foreach (InventoryItem it in stock)
                {
                    if (it.getUpc() == upc)
                    {
                        item = it;
                        break;
                    }
                    else
                    {
                        lblResults.Text = "UPC not found.";
                    }
                }
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (txtAccessKeyInput3.Text != accessKey)
            {
                lblResults.Text = "Invalid Access Key.";
            }

            string name = txtNewPriceInput.Text;
            if (!decimal.TryParse(txtNewPriceInput.Text, out decimal updatedPrice))
            {
               
                InventoryItem item = null;
                foreach (InventoryItem it in stock)
                {
                    if (it.getItemName().ToLower().Contains(name))
                    {
                        item = it; 
                        break;
                    }
                    else
                    {
                        lblResults.Text = "Item not found.";
                    }
                }
            } 
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (txtAccessKeyInput3.Text != accessKey)
            {
                lblResults.Text = "Invalid Access Key.";
            }
            if (int.TryParse(txtVerifyUpcInput.Text, out int upc))
            {
                int index = -1;
                for (int i = 0; i < stock.Count; i++)
                {
                    if (stock[i].getUpc() == upc)
                    {
                        index = i; 
                        break;
                    }

                
                }
                if (index != -1)
                {
                    stock.RemoveAt(index);
                    lblResults.Text = "Item was deleted.";
                }
                else
                {
                    lblResults.Text = "Invalid UPC";
                }
            }
            
            
        }

        private void btnAddItem_Click(object sender, EventArgs e)
        {
            if (stock.Count >= 20)
            {
                lblResults.Text = "Error inventory limit has been reached.";
                return;
            }
            if (txtAccessKeyInput3.Text != accessKey)
            {
                lblResults.Text = "Invalid Access Key.";
            }
            if (int.TryParse(txtUPCInput.Text, out int upc) && decimal.TryParse(txtStorePrice.Text, out decimal price) && decimal.TryParse(txtCostInput.Text, out decimal cost) && int.TryParse(txtUnitInput.Text, out int units))
            {
                string name = txtNameInput.Text;
                stock.Add(new InventoryItem(name, upc, price, cost, units));
                lblResults.Text = "Item(s) added successfully.";

                
            }
            else
            {
                lblResults.Text = "Invalid input.";
            }
        }
    }
}
