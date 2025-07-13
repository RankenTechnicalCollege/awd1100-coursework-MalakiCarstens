using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hotel_Conferences
{
    public partial class Form1 : Form
    {
        Conferences[] conferences = new Conferences[20];
        int conferenceCount = 0;
        int totalAttendees = 0;
        public Form1()
        {
            InitializeComponent();
            conferences[0] = new Conferences
            {
                GroupName = "Game Con",
                StartingDate = new DateTime(2025, 08, 29),
                Attendees = 200,
                Room = Room.ROOM_301
            };
            conferences[1] = new Conferences
            {
                GroupName = "Leaders of Tomorrow",
                StartingDate = new DateTime(2025, 04, 10),
                Attendees = 70,
                Room = Room.ROOM_101
            };
            conferences[2] = new Conferences
            {
                GroupName = "Rock Fest (Not Bands)",
                StartingDate = new DateTime(2025, 10, 16),
                Attendees = 176,
                Room = Room.ROOM_202
            };
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            string groupName = txtGroupName.Text;
            if (conferenceCount >= 20)
            {
                lblResults.Text = "Conference rooms are all booked.";
                return;
            }
            if (!DateTime.TryParse(txtStartingDate.Text, out DateTime startDate))
            {
                lblResults.Text = "Invalid Date.";
                return;
            }
            if (!int.TryParse(txtAttendees.Text, out int attendees))
            {
                lblResults.Text = "Invalid.";
                return;
            }
            
            Room room;

            switch (txtRoom.Text)
            {
                case "101":room = Room.ROOM_101; break;
                case "102": room = Room.ROOM_102; break;
                case "201": room = Room.ROOM_201; break;
                case "202": room = Room.ROOM_202; break;
                case "301": room = Room.ROOM_301; break;
                case "302": room = Room.ROOM_302; break;

                default: lblResults.Text = "No room(s) found.";
                return;
            };
            Conferences conference = new Conferences
            {
                GroupName = txtGroupName.Text,
                StartingDate = startDate,
                Attendees = attendees,
                Room = room
            };



            conferences[conferenceCount] = conference;
            conferenceCount++;

            totalAttendees += attendees;
            lblResults.Text = $"Conferences: {conferenceCount}/20\n Total Attendees: {totalAttendees}";
            lblResults2.Text += conference.Display();
            txtGroupName.Clear();
            txtStartingDate.Clear();
            txtAttendees.Clear();
            txtRoom.Clear();
            txtGroupName.Focus();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            if (!DateTime.TryParse(txtBegin.Text, out DateTime begin) || !DateTime.TryParse(txtEnd.Text, out DateTime end))
            {
                lblResults2.Text = "Invalid Entry.";
                return;
            } 
            bool found = false;

            lblResults2.Text = "";

            foreach (Conferences conference in conferences)
            {
                if (conference != null && conference.StartingDate.Date >= begin.Date && conference.StartingDate.Date <= end.Date)
                {
                    lblResults2.Text += conference.Display();
                    found = true;
                }
            }
            if (!found)
            {
                lblResults2.Text = "No Conference(s) found.";
            }
        }
    }
}
