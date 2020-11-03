using System;
using DAL;

namespace Client
{
    class Program
    {
        static void Main(string[] args)
        {
            using (SchoolContext context = new SchoolContext())
            {
                context.Database.EnsureCreated();
                SchoolInitializer.Seed(context);
            }

            using (SchoolContext context = new SchoolContext())
            {
                foreach(var student in context.Students)
                {
                    Console.WriteLine($"{student.FirstName} {student.LastName}");
                }
            }
        }
    }
}
