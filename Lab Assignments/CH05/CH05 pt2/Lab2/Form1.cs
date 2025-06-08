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
         int testScoreCount = 0;
         int scoreTotal = 0;
         int minScore = int.MaxValue;
         int maxScore = int.MinValue;
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string input = txtScore.Text;

            if (int.TryParse(input, out int score))
            {


                if (score == 999)
                {

                    lblResults.Text = $"Entries stopped.";
                    return;

                }

                if (score >= 0 && score <= 100) {
                    scoreTotal += score;
                    testScoreCount++;
                    if (score < minScore) minScore = score;
                    if (score > maxScore) maxScore = score;

                    double average = (double)scoreTotal / testScoreCount;


                    lblResults.Text = $"Number of scores: {testScoreCount}\n" +
                                      $"Sum of test scores: {scoreTotal}\n" +
                                      $"Average test score: {average:F2} \n" +
                                      $"Lowest test score: {minScore} \n" +
                                      $"Highest test score: {maxScore}";
                    
                }
                else
                {
                    Console.WriteLine($"Please enter a number 0-100");
                }

                
            }
            else
            {
                Console.WriteLine($"Please enter a valid number.");
            }

        }
    }
}
