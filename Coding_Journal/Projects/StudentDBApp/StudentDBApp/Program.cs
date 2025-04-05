using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentDBApp
{
    public class Program
    {
        static void Main(string[] args)
        {
            // Instantiates a Student context to represent a session operations to
            // the Student db
            // in the using statement 
            using (StudentContext context = new StudentContext())
            {
                // Instantiates a Student and populates with data
                // To later perform CRUD ops
                Student student = new Student()
                {
                    StudentName = "Johnny Smith",
                    DateOfBirth = DateTime.Now,
                    Grade = 7
                };
                // Adds Student object to the StudentContext current session
                context.Students.Add(student);
                // Performs and saves all changes of the current DbContext session
                // to the Student DB. Essentially adding the Student to the DB
                context.SaveChanges();
                // Success output message
                Console.WriteLine("The Student is saved the the database!");
                Console.ReadLine();
            }
        }
    }
}
