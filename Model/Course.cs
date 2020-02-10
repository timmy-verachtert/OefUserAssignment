using System;
using System.Collections.Generic;

namespace Model
{
    public class Course
    {
        public int CourseID { get; set; }
        public string Title { get; set; }
        public string Credits { get; set; }
        public List<Enrollement> Enrollements { get; set; }
    }
}
