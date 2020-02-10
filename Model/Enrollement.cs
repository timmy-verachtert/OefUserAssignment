using System;
using System.Collections.Generic;
using System.Text;

namespace Model
{
    public class Enrollement
    {
        public int EnrollementID { get; set; }
        public int CourseID { get; set; }
        public int StudentID { get; set; }
        public double Grade { get; set; }
        public List<Course> Course { get; set; }
        public List<Student> Student { get; set; }
    }
}
