using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LAB4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            string[] movie = { "Super Mario Movie", "A Minecraft Movie", "Good Burger", "Spider-man into the Spiderverse", "The Matrix" };
            string[] director = { "Aaron Horvath and Michael Jelenic", "Jared Hess", "Brian Robbins", "Peter Ramesey and Bob Persichetti", "Lana Wachowski and Lilly Wachowski" };
            string[] description = { "Mario and Luigi are transported through a mysterious pipe to a magical new world. But when the siblings are separated, an epic adventure begins.", " In the film, four misfits are pulled through a portal into a cubic world, and must embark on a quest back to the real world with the help of an expert crafter named Steve.", "The story follows Dexter Reed, a high school student who takes a job at a fast-food restaurant called Good Burger to pay off the damages he made to his teacher's car as he and Ed, his dimwitted co-worker, stumble upon an evil plot by a rival fast-food restaurant.", "Bitten by a radioactive spider in the subway, Brooklyn teenager Miles Morales suddenly develops mysterious powers that transform him into the one and only Spider-Man.", "Neo is contacted by Trinity, a stranger who leads him into an underworld where he meets Morpheus. They fight a brutal battle for their lives against a cadre of viciously intelligent secret agents." };

            string input = txtInputBox.Text;
            bool tof = false;

            for (int i = 0; i < movie.Length; i++) 
            {
                if (movie[i].Contains(input) || director[i].Contains(input)) 
                {
                    lblResults.Text = $"Movie: {movie[i]}\n Director: {director[i]}\n Description: {description[i]}";
                    tof = true ;
                    break;
                }
                if (!tof) 
                {
                    lblResults.Text = $"Neither movie nor director were found in our system please try again.";
                    break;
                }
            }
        }
    }
}
