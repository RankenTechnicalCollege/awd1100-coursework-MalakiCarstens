using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CH10
{
    public partial class Form1 : Form
    {
        SuperHero[] heroes =
        {
            new SuperHero(){Name = "None", Likes = "", Dislikes = "", Biography = " ", Image = null, SuperPower = "", Url = ""},
            new SuperHero(){Name = "Magneto", Likes = "LIKES: his mutant family", Dislikes = "DISLIKES: Mankind", Biography = "BIOGRAPHY: Max Eisenhardt was born in the 1920s to a Jewish family;\n his father was a decorated World War I veteran.", Image = Properties.Resources.magneto, SuperPower = "SUPERPOWERS: Manipulation of magnetic fields", Url = "https://en.wikipedia.org/wiki/Magneto_(Marvel_Comics)"},
            new SuperHero(){Name = "Psylocke", Likes = "LIKES: outsmarting others. combat", Dislikes = "DISLIKES: incompetance and underestimation", Biography = "BIOGPRAHY: Psylocke is the name of two connected characters \nappearing in American comic books published by Marvel Comics,\n commonly in association with the X-Men. Both characters are portrayed as mutants,\n a subspecies of humans born with an \"X-gene\"\n that grants superhuman abilities.", Image = Properties.Resources.psylocke, SuperPower = "SUPERPOWERS: Psionics and Telekinesis", Url = "https://en.wikipedia.org/wiki/Psylocke"},
            new SuperHero(){Name = "Magik", Likes = "LIKES: friends. protecting others", Dislikes = "DISLIKES: loss of control", Biography = "BIOGRAPHY: a powerful mutant and sorceress in the Marvel universe,\n primarily known for\n her association with the New Mutants and her ability to\n teleport through Limbo using stepping discs", Image = Properties.Resources.Magik, SuperPower = "SUPERPOWER: Sorcery, Magic manipulation, \nand Teleportation", Url = "https://en.wikipedia.org/wiki/Magik"},
            new SuperHero(){Name = "Rouge", Likes = "LIKES: achieving. honesty loyalty", Dislikes = "DISLIKES:injustice and weakness", Biography = "BIOGRAPHY: Rogue, a prominent member of the X-Men,\n is a mutant with the ability to absorb the powers, memories, \nand physical traits of others through skin contact.", Image = Properties.Resources.rouge, SuperPower = "SUPERPOWER: Life absorption", Url = "https://disney.fandom.com/wiki/Rogue"},
            new SuperHero(){Name = "Wolverine", Likes = "LIKES: food. Japan", Dislikes = "DISLIKES: deadpools antics. injustice.", Biography = "BIOGRAPHY: Wolverine is a superhero from Marvel Comics. \nA mutant with a healing factor and imbued with \nunbreakable Adamantium claws, \nWolverine is the most notably a member of the X-Men", Image = Properties.Resources.hugejackedman, SuperPower = "SUPERPOWER: Adamantium Claws, \nand Powerful Healing", Url = "https://disney.fandom.com/wiki/Wolverine"}
        };
        public Form1()
        {
            InitializeComponent();
            cboHeroes.Items.AddRange(heroes);
            cboHeroes.SelectedIndex = 0;

        }

        private void cboHeroes_SelectedIndexChanged(object sender, EventArgs e)
        {
            int currentIndex = cboHeroes.SelectedIndex;
            if (cboHeroes.SelectedIndex == 0)
            {
                lblHeroName.Text = "Please select a hero.";
            }
            else
            {
                lblHeroName.Text = heroes[currentIndex].Name;
                lblLikes.Text = heroes[currentIndex].Likes;
                lblDislikes.Text = heroes[currentIndex].Dislikes;
                lblSuperPower.Text = heroes[currentIndex].SuperPower;
                lblBiography.Text = heroes[currentIndex].Biography;
                pbHero.Image = heroes[currentIndex].Image;
                lblHeroLink.Text = heroes[currentIndex].Url;
            }
        }
    }
}
