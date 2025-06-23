using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnOpen_Click(object sender, EventArgs e)
        {
            //string[] fortunes = { "Birthdays are like friends. The more you have the better.", "Your smile is a treasure to all who know you.", "You never hesitate to tackle the most difficult problems.", "The most obvious solution is not always the best.", "If you want the rainbow, you will have to tolerate the rain.", "The early bird gets the worm, but the second mouse gets the cheese.", "From listening comes wisdom and from speaking repentance.", "A smile is your personal welcome mat." };
            GenerateFortune();
                
        }
        private void GenerateFortune()
        {
            string[] fortunes = { "Birthdays are like friends. The more you have the better.", "Your smile is a treasure to all who know you.", "You never hesitate to tackle the most difficult problems.", "The most obvious solution is not always the best.", "If you want the rainbow, you will have to tolerate the rain.", "The early bird gets the worm, but the second mouse gets the cheese.", "From listening comes wisdom and from speaking repentance.", "A smile is your personal welcome mat." };
            Random rand = new Random();
            int fortune1 = rand.Next(fortunes.Length);
            int fortune2 = rand.Next(fortunes.Length);

            while (fortune1 == fortune2) 
            {
                fortune1 = rand.Next(fortunes.Length);
            }
            lblResults.Text = string.Format("{0}\n{1}", fortunes[fortune1], fortunes[fortune2]);
        }
    }
}
