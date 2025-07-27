using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LB1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            try 
            {
                float weight = float.Parse(txtWeight.Text);
                if (weight < 70 || weight > 300)
                {
                    throw new InvalidWeightException("Invalid Weight");
                }
                float height = float.Parse(txtHeight.Text);
                if (height < 60 || height > 84)
                {
                    throw new InvalidHeightException("Invalid Height");
                }
                Bmi result = BmiCalculator.CalcBmi(weight, height);
                lblResults.Text = $"Bmi: {result.bmi:F2} \n Category: {result.weightCategory}";
                
            } 
            catch (FormatException ex)
            {
                lblResults.Text = "Weight and Height must be valid, please try again.";
            }
            catch (InvalidWeightException ex)
            {
                MessageBox.Show(ex.Message);
            }
            catch(InvalidHeightException ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

    }
}
