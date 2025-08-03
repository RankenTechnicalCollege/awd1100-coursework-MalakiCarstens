using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LB4
{
    public class Student
    {
        public string FirstName {  get; set; }
        public string LastName { get; set; }
        public string Course { get; set; }
        public string Grade { get; set; }
        public decimal Gpa { get; set; }

        public Student(string firstName, string lastName, string course, string grade, decimal gpa)
        {
            FirstName = firstName;
            LastName = lastName;
            Course = course;
            Grade = grade;
            Gpa = gpa;
        }
        public override string ToString()
        {
            return  $"Name:{FirstName} {LastName} \n Course:{Course} \n Grade:{Grade} \n GPA: {Gpa}";
            
        }
    }
}
