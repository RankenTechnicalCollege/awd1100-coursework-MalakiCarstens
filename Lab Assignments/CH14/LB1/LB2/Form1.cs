using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LB2
{
    public partial class Form1 : Form
    {
        Photo photo = null;
        public Form1()
        {
            InitializeComponent();
            txtWidth.Focus();
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            if (!float.TryParse(txtWidth.Text, out float width) || !float.TryParse(txtHeight.Text, out float height))
            {
                lblResults.Text = "Please enter a valid width and/or height.";
                return;
            }
            if (rdbMatted.Checked)
            {
                Color color = Color.BLACK;
                if (rdbRed.Checked)

                    color = Color.RED;

                else if (rdbGreen.Checked)

                    color = Color.GREEN;

                else if (rdbBlue.Checked)

                    color = Color.BLUE;
                else if (rdbWhite.Checked)

                    color = Color.WHITE;

                photo = new MattedPhoto(width, height, color);
            }
            else if (rdbFramed.Checked)
            {
                Material material = Material.PINE;
                if (rdbOak.Checked)
                    material = Material.OAK;
                else if (rdbSteel.Checked)
                    material = Material.STEEL;
                else if (rdbSilver.Checked)
                    material = Material.SILVER;
                else if (rdbGold.Checked)
                    material = Material.GOLD;

                Style style = Style.SIMPLE;
                if (rdbModern.Checked)
                    style = Style.MODERN;
                else if (rdbAntique.Checked)
                    style = Style.ANTIQUE;
                else if (rdbVintage.Checked)
                    style = Style.VINTAGE;
                else if (rdbEclectic.Checked)
                    style = Style.ECLECTIC;

                photo = new FramedPhoto(width, height, material, style);
            }
            else if (rdbUnframed.Checked)
            {
                photo = new Photo(width, height);
            }
            lblResults.Text = photo.ToString();
            lblCost.Text = $"Cost: {photo.Price:C}";
        }
    }
}
