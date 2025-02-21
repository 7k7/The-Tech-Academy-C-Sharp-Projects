using System;

namespace POLYMORPHISM_SUBMISSION_ASSIGNMENT
{
    // This class implements an interace
    public class Employee : IQuittable
    {
        public void Quit()
        {
            Console.WriteLine("Well boss... I quit.");
        }
    }
}
