using System;
using System.Collections.Generic;
using System.Text;

namespace DAL
{
    public class SchoolInitializer
    {
        public static void Seed(SchoolContext context)
        {
            var students = new List<Student>
            {
            new Student{FirstName="Carson",LastName="Alexander",EnrollmentDate=DateTime.Parse("2005-09-01")},
            new Student{FirstName="Meredith",LastName="Alonso",EnrollmentDate=DateTime.Parse("2002-09-01")},
            new Student{FirstName="Arturo",LastName="Anand",EnrollmentDate=DateTime.Parse("2003-09-01")},
            new Student{FirstName="Gytis",LastName="Barzdukas",EnrollmentDate=DateTime.Parse("2002-09-01")},
            new Student{FirstName="Yan",LastName="Li",EnrollmentDate=DateTime.Parse("2002-09-01")},
            new Student{FirstName="Peggy",LastName="Justice",EnrollmentDate=DateTime.Parse("2001-09-01")},
            new Student{FirstName="Laura",LastName="Norman",EnrollmentDate=DateTime.Parse("2003-09-01")},
            new Student{FirstName="Nino",LastName="Olivetto",EnrollmentDate=DateTime.Parse("2005-09-01")}
            };
            students.ForEach(s => context.Students.Add(s));
            context.SaveChanges();

            var courses = new List<Course>
            {
            new Course{CourseCode=1050,Title="Chemistry"},
            new Course{CourseCode=4022,Title="Microeconomics"},
            new Course{CourseCode=4041,Title="Macroeconomics"},
            new Course{CourseCode=1045,Title="Calculus"},
            new Course{CourseCode=3141,Title="Trigonometry"},
            new Course{CourseCode=2021,Title="Composition"},
            new Course{CourseCode=2042,Title="Literature"}
            };
            courses.ForEach(s => context.Courses.Add(s));
            context.SaveChanges();

            var enrollments = new List<Enrollment>
            {
            new Enrollment{StudentID=1,CourseCode=1050,Grade=GradesEnum.A},
            new Enrollment{StudentID=1,CourseCode=4022,Grade=GradesEnum.C},
            new Enrollment{StudentID=1,CourseCode=4041,Grade=GradesEnum.B},
            new Enrollment{StudentID=2,CourseCode=1045,Grade=GradesEnum.B},
            new Enrollment{StudentID=2,CourseCode=3141,Grade=GradesEnum.F},
            new Enrollment{StudentID=2,CourseCode=2021,Grade=GradesEnum.F},
            new Enrollment{StudentID=3,CourseCode=1050},
            new Enrollment{StudentID=4,CourseCode=1050},
            new Enrollment{StudentID=4,CourseCode=4022,Grade=GradesEnum.F},
            new Enrollment{StudentID=5,CourseCode=4041,Grade=GradesEnum.C},
            new Enrollment{StudentID=6,CourseCode=1045},
            new Enrollment{StudentID=7,CourseCode=3141,Grade=GradesEnum.A}
            };
            enrollments.ForEach(s => context.Enrollments.Add(s));
            context.SaveChanges();
        }
    }
}
