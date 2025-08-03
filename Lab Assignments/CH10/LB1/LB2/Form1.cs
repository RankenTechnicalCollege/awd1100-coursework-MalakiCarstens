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
        Industry[] selectedIndustries;

        Job[] itJobs =
        {
     new Job("Junior Software Engineer", new LinkLabel.Link() {LinkData="https://jobs.boeing.com/employment/united-states-region-missouri-engineering-jobs/185/11125/6252001-4398678/3?utm_source=google.com&utm_medium=paid_search&utm_campaign=STL%202025&gad_source=1&gad_campaignid=22311051961&gclid=CjwKCAjwkbzEBhAVEiwA4V-yqoxr-ToASnAppyzHWP-bK5KvwZ8OsuoQLa_kjUcPSc2odc1t6w64phoCF9YQAvD_BwE"}),
     new Job("Junior Web Developer", new LinkLabel.Link(){LinkData="https://www.linkedin.com/jobs/entry-level-web-developer-jobs-greater-st.-louis?position=1&pageNum=0"}),
     new Job("Quality Assurance Specialist", new LinkLabel.Link() {LinkData="https://www.linkedin.com/jobs/entry-level-quality-assurance-jobs-greater-st.-louis?position=1&pageNum=0" })

 };
        Job[] autoJobs =
        {
     new Job("Automotive Mechanic", new LinkLabel.Link(){LinkData="https://www.indeed.com/q-automotive-mechanic-l-fenton,-mo-jobs.html?vjk=bd347e2e02cceee9"}),
     new Job("Automotive Technician", new LinkLabel.Link() {LinkData="https://www.indeed.com/q-auto-mechanic-jobs.html?gclsrc=aw.ds&aceid=&gad_source=1&gad_campaignid=15513873562&gclid=CjwKCAjwkbzEBhAVEiwA4V-yqnx3E2bW9Scu6Cx1GVLK4VhZoHA1SNawr16z_aapsMnZcpRq6kJi9RoCKwsQAvD_BwE&vjk=d72d228af0116964" })

 };
        Job[] hvacJobs =
        {
     new Job("Hvac Installer", new LinkLabel.Link() {LinkData="https://www.indeed.com/q-hvac-installer-l-st.-louis,-mo-jobs.html?vjk=79e03b4af1536ee4"})
 };
        public Form1()
        {
            InitializeComponent();
            lstIndustries.Items.AddRange(new Industry[]
  {
      new Industry("Information Technology", itJobs),
      new Industry("Automotive", autoJobs),
      new Industry("HVAC", hvacJobs)

  });

        }

        private void lstIndustries_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            selectedIndustries = new Industry[lstIndustries.SelectedItems.Count];

            for (int i = 0; i < lstIndustries.SelectedItems.Count; i++)
            {
                selectedIndustries[i] = (Industry)lstIndustries.SelectedItems[i];
            }
        }
        private void btnSearch_Click(object sender, EventArgs e)
        {
            frmSearchResults jobList = new frmSearchResults(selectedIndustries);
            jobList.ShowDialog();
        }
    }
}
