using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LAB3
{
    public partial class Form1 : Form
    {


        public Form1()
        {
            InitializeComponent();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            string[] games = { "Player Unknown's Battlegrounds (PUBG)", "Marvel Rivals", "Call of Duty: Black Ops III", "Battlefield 4", "Super Mario Odyssey" };
            string[] publisher = { "Bluehole", "NetEase Games", "Activision", "Electronic Arts (EA)", "Nintendo" };
            int[] price = { 35, 0, 60, 20, 60 };
            bool tof = false;


            string input = txtInputBox.Text.ToLower();
            for (int i = 0; i < games.Length; i++) 
            {
                if (games[i].ToLower().Contains(input) || publisher[i].ToLower().Contains(input))
                {
                    lblResults.Text = $"Game Name: {games[i]} \n Publisher: {publisher[i]} \n Price: {price[i]:C}";
                    tof = true;
                    break;
                }
              
            }
            if (!tof)
            {
                lblResults.Text = $"Sorry no games or publishers with that name have been found in our system.";

            }
        }
    }
}
