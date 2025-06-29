using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

// I can only get this to let me enter one number and I can't figure out why, I have spent a very long time working on it.
namespace Lab4
{
    public partial class Form1 : Form
    {
        int[] numbers = new int[20];
        int count = 0;

        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (count >= 20)
            {
                lblResults.Text = "Please enter up to 20 numbers.";
                return;
            }
            if (int.TryParse(txtIntegerInput.Text, out int number))
            {
                numbers[count] = number;
                count++;

                int[] entries = new int[count];
                Array.Copy(numbers, entries, count);
                CalculateStats(out int min, out int max, out double sum, out double avg, entries);
                lblResults.Text = $"Lowest: {min}\n Highest: {max}\n Sum: {sum}\n Average: {avg:F2}";

            }
            else 
            {
                lblResults.Text = "Please enter a valid number.";
            }
        }

        public void CalculateStats(out int min, out int max, out double sum, out double avg, params int[] numbers)
        {
            min = 0;
            max = 0;
            sum = 0.0;
            avg = 0.0;

            min = numbers[0];
            max = numbers[0];
            sum = numbers[0];


            for (int i = 1; i < numbers.Length; i++)
            {
                if (numbers[i] < min)
                {
                    min = numbers[i];
                    if (numbers[i] > max)
                    {
                        max = numbers[i];
                        sum = sum + numbers[i];
                    }
                    avg = sum / numbers.Length;
                }
            }
        }
    }
}
