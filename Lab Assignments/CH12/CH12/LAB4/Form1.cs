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
        List<Game> gameList = new List<Game>();
        public Form1()
        {
            InitializeComponent();
            gameList.Add(new Game("Player Unkown's Battle Grounds", "Bluehole", 35f));
            gameList.Add(new Game("League of Legends", "Riot Games", 0f));
            gameList.Add(new Game("Call of Duty: Black Ops III", "Activision", 60f));
            gameList.Add(new Game("Battlefield 4", "Electronic Arts (EA)", 20f));
            gameList.Add(new Game("Super Mario Odyssey", "Nintendo", 60f));
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            int gameIndex = SearchForGame(txtGameInput.Text);
            ShowGameInfo(gameIndex);
        }
        private int SearchForGame(string searchGame)
        {
            searchGame = searchGame.ToLower();
            for (int i = 0; i < gameList.Count; i++)
            {
                if (gameList[i].GetName().ToLower().Contains(searchGame) || gameList[i].GetPublisher().ToLower().Contains(searchGame))
                {
                    return i;
                }
            }
            return -1;
        }
        private void ShowGameInfo(int gameIndex)
        {
            if (gameIndex >= 0 || gameIndex < gameList.Count)
            {
                Game foundGame = gameList[gameIndex];
                lblResults.Text = $"Game: {foundGame.GetName()}\n Publisher: {foundGame.GetPublisher()}\n Price: {foundGame.GetPrice():F2}";
            }
            else
            {
                lblResults.Text = "Game not found.";
            }
        }
    }
}
