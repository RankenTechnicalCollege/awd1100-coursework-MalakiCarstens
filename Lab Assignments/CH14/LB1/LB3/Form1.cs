using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LB3
{
    public partial class Form1 : Form
    {
        List<ICard> boosterPack = new List<ICard>();
        private int cardIndex = 0;
        private int shinyCardIndex = 0;
        public Form1()
        {
            InitializeComponent();
        }

        private void btnNextCard_Click(object sender, EventArgs e)
        {
            pbCardDisplay.Visible = true;
            if (boosterPack.Count == 0 || cardIndex >= 10)
            {
                boosterPack.Clear();
                cardIndex = 0;
                boosterPack.Add(new NormalCard("Scizor", Properties.Resources.scizor, 1));
                boosterPack.Add(new NormalCard("Golisopod", Properties.Resources.Golisopod, 2));
                boosterPack.Add(new NormalCard("Latias EX", Properties.Resources.Latias_ex, 3));
                boosterPack.Add(new NormalCard("Charazard EX", Properties.Resources.charazard, 4));
                boosterPack.Add(new NormalCard("Hydrapple EX", Properties.Resources.hydrapple_ex, 5));
                boosterPack.Add(new NormalCard("Meowscarada EX", Properties.Resources.meow, 6));
                boosterPack.Add(new NormalCard("Lillie's Full Force", Properties.Resources.lilliefullforce, 7));
                boosterPack.Add(new NormalCard("Umbreon V-Max", Properties.Resources.moonbreon, 8));
                boosterPack.Add(new ShinyCard("Gyarados EX", Properties.Resources.shiny_gyarados_pokemon_trading_card_game, 9, new Font("Arial", 14, FontStyle.Bold), Color.Silver, Color.Gold));
                boosterPack.Add(new ShinyCard("Umbreon EX", Properties.Resources.sunbreon, 10, new Font("Arial", 14, FontStyle.Bold), Color.Silver, Color.Gold));

                boosterPack.Sort();

            }
            if (cardIndex < 10)
            {
                ICard card = boosterPack[cardIndex];
                card.ShowCard(pbCardDisplay, lblPokemonName);
                    cardIndex++;
                if (cardIndex == 10)
                {
                    lblResults.Text = "You have gone through all cards in the booster pack.";
                }
            }
        }
    }
}
