using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DAL
{
    public class Student
    {
        public int Id { get; set; }
        [MaxLength(40)]
        public string FirstName { get; set; }
        [MaxLength(40)]
        public string LastName { get; set; }
        [NotMapped]
        public string Fullname 
        {
            get
            {
                return FirstName + " " + LastName;
            }
        }
        public DateTime EnrollmentDate { get; set; }
        List<Enrollment> Enrollments { get; set; }
    }
}
