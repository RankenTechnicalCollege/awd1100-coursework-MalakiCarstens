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

namespace LB3
{
    public partial class Form1 : Form
    {
        Champion[] champions = new Champion[20];
        int championIndex = 0;
        public Form1()
        {
            InitializeComponent();
            champions[championIndex++] = new Champion("Ruckus", ChampionType.FRONT_LINE, new Ability("Miniguns"), new Ability("Missile Launcher"), new Ability("Emitter"), new Ability("Advance"), new Ability("Hexa Fire"));
            champions[championIndex++] = new Champion("Makoa", ChampionType.FRONT_LINE, new Ability("Cannon"), new Ability("Dredge Anchor"), new Ability("Shell Shield"), new Ability("Shell Spin"), new Ability("Ancient Rage"));
            champions[championIndex++] = new Champion("Drogoz", ChampionType.DAMAGE, new Ability("Rocket Launcher"), new Ability("Fire Spit"), new Ability("Salvo"), new Ability("Thrust"), new Ability("Dragon Punch"));
            champions[championIndex++] = new Champion("Tyra", ChampionType.DAMAGE, new Ability("Auto Rifle"), new Ability("Nade Launcher"), new Ability("Fire Bomb"), new Ability("Hunter's Mark"), new Ability("Crossfire"));
            champions[championIndex++] = new Champion("Grover", ChampionType.SUPPORT, new Ability("Throwing Axe"), new Ability("Crippling Throw"), new Ability("Blossom"), new Ability("Vine"), new Ability("Whirlwind"));
            champions[championIndex++] = new Champion("Evie", ChampionType.FLANK, new Ability("Ice Staff"), new Ability("Ice Block"), new Ability("Blink"), new Ability("Soar"), new Ability("Ice Storm"));
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            Champion foundChampion = null; 
            string name = txtSearchBox.Text.ToLower();
            for (int i = 0; i < champions.Length; i++)
            {
                if (champions[i] != null && champions[i].Name.ToLower().Contains(name))
                {
                    foundChampion = champions[i];
                    break;
                }
            }
            if (foundChampion != null)
            {
                lblResults.Text = $"{foundChampion.Name}\n{foundChampion.Type}\n" +
                  $"Ability 1 (Left Mouse): {foundChampion.LeftMouse.Name}\n" +
                  $"Ability 2 (Right Mouse): {foundChampion.RightMouse.Name}\n" +
                  $"Ability 3 (Q): {foundChampion.Q.Name}\n" +
                  $"Ability 4 (F): {foundChampion.F.Name}\n" +
                  $"Ultimate Ability (E): {foundChampion.E.Name}";
            }
            else
            {
                lblResults.Text = "Champion Not Found.";
            }
        }
    }
}
