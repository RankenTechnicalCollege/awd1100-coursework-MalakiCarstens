using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab6
{
    public partial class Form1 : Form
    {
        List<Room> rooms = new List<Room>();

        public Form1()
        {
            InitializeComponent();
            //rooms.Add(new Room("Living Room", 15, 20));
            //rooms.Add(new Room("Bedroom", 12, 14));
            //rooms.Add(new Room("Kitchen", 10, 12));
            //rooms.Add(new Room("Bathroom", 8, 10));
            //rooms.Add(new Room("Office", 10, 10));
            //rooms.Add(new Room("Garage", 18, 20));
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            string name = txtName.Text;
            if (rooms.Count >= 20)
            {
                lblResults.Text = "Maximum entries reached";
                return;
            }
            if (!int.TryParse(txtWidth.Text, out int width) || width <= 0)
            {
                lblResults.Text = "Enter a valid width";
                return;
            }
            if (!int.TryParse(txtLength.Text, out int length) || length <= 0)
            {
                lblResults.Text = "Enter a valid length";
                return;
            }
            Room addRoom = new Room(name, width, length);
            rooms.Add(addRoom);
            int totalBoxes = GetTotalBoxes();
            string result = "";
            result += $"Rooms: {rooms.Count}/20\n";
            result += $"Total Boxes Needed: {totalBoxes}\n\n";

            foreach (Room room in rooms)
            {
                result += room.ToString() + "\n" ;
            }

            lblResults.Text = result;  
        }

        
        private int GetTotalBoxes()
        {
            int total = 0;
            foreach (Room room in rooms)
            {
                total += room.boxes;
            }
            return total;
           
        }

    }
}
