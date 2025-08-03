using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LB5
{
    public partial class Form1 : Form
    {
        List<Student> currentStudents = new List<Student>();
        Course awd1100 = new Course();
        public Form1()
        {
            InitializeComponent();
            currentStudents.Add(new Student(10032, "Johnny", "Silverhand", "Samuraineverfadeaway@gmail.com"));
            currentStudents.Add(new Student(90421, "Charles", "Barkley", "technologyofcharlesbarkley@gmail.com"));
            currentStudents.Add(new Student(11340, "Silvia", "Adaman", "adamaninc@yahoo.com"));
            currentStudents.Add(new Student(45678901, "Lindsey", "Jennings", "reallindseyjennings@gmail.com"));

            awd1100.CourseName = "Programming Fundamentals with C#";
            awd1100.Students = currentStudents;

            foreach (Student s in awd1100.Students)
            {
                rtbResult.Text += s.ToString();
                cboStudents.Items.Add(s.StudentID);
            }
        }
        
        private void btnAddStudent_Click(object sender, EventArgs e)
        {
            currentStudents.Add(new Student(int.Parse(txtId.Text), txtFirstName.Text, txtLastName.Text, txtEmail.Text));
            awd1100.Students = currentStudents;
            rtbResult.Text = "";
            cboStudents.Items.Add(int.Parse(txtId.Text));

            foreach (Student student in awd1100.Students)
            {
                rtbResult.Text += student.ToString();

            }
        
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            int searchId = int.Parse(cboStudents.Text);

            for (int i = 0; i < awd1100.Students.Count; i++)
            {
                if (searchId == awd1100.Students[i].StudentID)
                {
                    awd1100.Students.Remove(awd1100.Students[i]);

                }
            }

            rtbResult.Text = "";
            cboStudents.Items.Clear();

            foreach (Student student1 in awd1100.Students)
            {
                rtbResult.Text += student1.ToString();
                cboStudents.Items.Add(student1.StudentID);
            }
        }
    }
 }

