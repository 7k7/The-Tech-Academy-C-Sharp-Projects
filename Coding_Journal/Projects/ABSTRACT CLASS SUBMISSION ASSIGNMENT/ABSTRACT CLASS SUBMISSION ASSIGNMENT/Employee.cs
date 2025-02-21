using System;

namespace ABSTRACT_CLASS_SUBMISSION_ASSIGNMENT
{   // Inherited class from the base class Person
    public class Employee : Person
    {
        public override void SayName()
        {
            Console.WriteLine($"Your name is {this.firstName}" +
                $" {this.lastName}");
        }
    }
}
