using System;
using System.Collections.Generic;
using System.Text;

namespace Model
{
    public class Student
    {
        public int StudentID { get; set; }
        public string LastName { get; set; }
        public string FirstMidName { get; set; }
        public string EnrollementDate { get; set; }
        public List<Enrollement> Enrollements { get; set; }
    }
}
