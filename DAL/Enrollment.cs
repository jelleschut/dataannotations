using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace DAL
{
    public class Enrollment
    {
        [Key]
        public int EnrollmentId { get; set; }
        public int CourseCode { get; set; }
        public int StudentID { get; set; }
        public GradesEnum Grade { get; set; }
        public Student Student { get; set; }
        public Course Course { get; set; }
    }
}
