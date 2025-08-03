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

namespace LB2
{
    public partial class frmSearchResults : Form
    {
        private Industry[] _industries;

        public frmSearchResults(Industry[] industries)
        {
            InitializeComponent();
            _industries = industries;
            this.Load += frmSearchResults_Load;
        }

        private void frmSearchResults_Load(object sender, EventArgs e)
        {
            int ylocation = 10;
            foreach (Industry industryItem in _industries)
            {
                foreach (Job jobItem in industryItem.Jobs)
                {
                    
                    LinkLabel label = new LinkLabel
                    {
                        Text = jobItem.JobTitle,
                  
                        Location = new Point(10, ylocation),
                        AutoSize = true
                    };
                  
                    label.Links.Add(jobItem.Link);
                    label.LinkClicked += Label_LinkClicked;
                    ylocation += 20;
                  
                    this.Controls.Add(label);
                }
            }

        }

        private void Label_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start(e.Link.LinkData.ToString());
        }
    }
}

