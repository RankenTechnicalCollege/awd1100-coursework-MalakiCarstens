using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LAB6
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string woodType = GetWood();
            int drawerNum = GetDrawers();

            if (drawerNum == -1) return;
            double totalCost = CalculateTotalCost(woodType, drawerNum);
            lblResults.Text = $"Wood: {woodType}\n Drawers: {drawerNum}\n TotalCost: {totalCost:F2}";
        }

        private string GetWood()
        {
            string input = txtWoodType.Text.ToLower();
            if (input == "m")
                return "mahogany";
            else if (input == "o")
                return "oak";
            else if (input == "p")
                return "pine";
            else return "other";
        }

        private int GetDrawers()
        {
            if (int.TryParse(txtDrawerNum.Text, out int drawers) && drawers >= 0)
            {
                return drawers;
            }
            else
            {
                lblResults.Text = $"Error please try again.";
                return -1;
            }
        }

        private double CalculateWoodCost(string woodType)
        {
            if (woodType == "pine")
                return 100.0;
            else if (woodType == "oak")
                    return 140.0;
            else { return 180.0; }
            }

        private double CalculateDrawerCost(int drawerNum)
        {
            return drawerNum * 30.0;
        }

        private double CalculateTotalCost(string woodType, int drawerNum)
        {
            double woodCost = CalculateWoodCost(woodType);
            double drawerCost = CalculateDrawerCost(drawerNum);
            return woodCost + drawerCost;
        }
       }
    }
