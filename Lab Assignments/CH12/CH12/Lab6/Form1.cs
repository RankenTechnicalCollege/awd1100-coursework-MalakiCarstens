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
            lblResults.Text = $"Room Name: {addRoom.name} needs {addRoom.boxes} Boxes\n" + $"Rooms Count: {rooms.Count}\n" +
                      $"Width: {addRoom.width}\n" +
                      $"Length: {addRoom.length}\n" +
                      $"Area: {addRoom.area}\n";
        }
    }
}
