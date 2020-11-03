using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DAL
{
    public class Course
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int CourseCode { get; set; }
        [Required]
        [MaxLength(40)]
        public string Title { get; set; }

        List<Enrollment> Enrollments { get; set; }
    }
}
