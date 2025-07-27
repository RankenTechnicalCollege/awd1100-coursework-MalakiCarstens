using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EX1
{
    public partial class Form1 : Form
    {
        TestStatistics statistics = new TestStatistics();
        public Form1()
        {
            InitializeComponent();
        }

        private void btnEnter_Click(object sender, EventArgs e)
        {
            if (float.TryParse(txtScore.Text, out float score))
            {
                try
                {
                    statistics.AddScore(score);
                    lblResults.Text = $"Number of Scores: {statistics.Count}\n Sum of test scores: {statistics.Sum}\n Average test score: {statistics.Average:F2}\n Lowest test score: {statistics.Min}\n Highest test score: {statistics.Max}";
                }
                catch (ArgumentException ex)
                {
                    lblResults.Text = ex.Message;
                }
            }
            else
            {
                lblResults.Text = "Please enter a valid score.";
            }
        }
    }
}
