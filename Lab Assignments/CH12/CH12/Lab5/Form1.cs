using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab5
{
    public partial class form : Form
    {
        Job currentJob = null;
        public form()
        {
            InitializeComponent();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            string description = txtDescription.Text.ToLower();
            if (!float.TryParse(txtHoursToComplete.Text, out float hours) || hours < 0)
            {
                lblResults.Text = "Please enter a valid number.";
                return;
            }
            if (!float.TryParse(txtHourlyRate.Text, out float rate) || hours < 0)
            {
                lblResults.Text = "Please enter a valid rate.";
                return;
            }
            if (currentJob == null)
            {
                currentJob = new Job(description, hours, rate);
                return;
            }
            else
            {
                currentJob.Description = description;
                currentJob.HoursToComplete = hours;
                currentJob.HourlyFee = rate;
                currentJob.CalculateTotalFee();
            }
            lblResults.Text = $"{currentJob.Description}\n\n {currentJob.HoursToComplete:F2}\n\n {currentJob.HourlyFee:F2}\n\n {currentJob.TotalFee:F2}";
            }
        }
     
    }
