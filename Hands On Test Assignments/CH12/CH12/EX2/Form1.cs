using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EX2
{
    public partial class Form1 : Form
    {
        List<Computer> computers = new List<Computer>
{
        new Computer("My-Desktop", "127.0.0.1", new int[] { 20, 21, 23 }),
        new Computer("google-public-dns-a", "8.8.8.8", new int[] { 25, 53, 80, 443 }),
        new Computer("ranken.edu", "47.44.246.80", new int[] { 123, 389, 443 })
};

        public Form1()
        {
            InitializeComponent();
        }

        private void btnScan_Click(object sender, EventArgs e)
        {
            string input = txtIpInput.Text;
            int index = ScanIpAddress(input);
            ShowComputer(index);
        }
        public int ScanIpAddress(string ipAddress)
        {
            for (int i = 0; i < computers.Count; i++)
            {
                if (computers[i].IpAddress == ipAddress)
                return i;
            }
            return -1;
        }
        public void ShowComputer(int index)
        {
            if (index >= 0 )
            {
                Computer compName = computers[index];
                string service = string.Join(",", compName.Services);
                lblResults.Text = $"{compName.Name}\n {compName.IpAddress}\n Services:\n {service}";
            }
            else
            {
                lblResults.Text = $"Request Timed Out\nServices: NONE";
            }
        }
    }
}
