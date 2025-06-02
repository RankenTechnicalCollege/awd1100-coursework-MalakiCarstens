using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab3
{
    public partial class Form1 : Form
    {
        Random rand = new Random();
        int round = 0;
        int playerScore = 0;
        int computerScore = 0;
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            PlayRound(1);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            PlayRound(2);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            PlayRound(3);
        }

        private void PlayRound(int playerChoice)
        {
            if (round > 3)
            {
                lblResult.Text = $"Game Over";
            }
            int computerChoice = rand.Next(1, 4);
            {
                lblResult.Text = $"Computer chose {computerChoice}";
            }
            if (playerChoice == computerChoice)
            {
                lblResult.Text = $"It's a tie!";
            }
            else if ((playerChoice == 1 && computerChoice == 3) || (playerChoice == 2 && computerChoice == 1) || (playerChoice == 3 && computerChoice == 2))
            {
                lblResult.Text = $"You won this round!";
                playerScore++;
            }
            else
            {
                lblResult.Text = $"Computer wins this round!";
                computerScore++;
            }
            round++;
            lblScore.Text = $"Player: {playerScore} | Computer: {computerScore}";
            if (round == 3) 
            {
                if (playerScore > computerScore)
                {
                    lblFinalScore.Text = $"Player won the game!";
                }
                else if (playerScore < computerScore)
                {
                    lblFinalScore.Text = $"Computer won the game.";
                }
                else 
                {
                    lblFinalScore.Text = $"Tie!";
                }
            }
        }
    }
}
