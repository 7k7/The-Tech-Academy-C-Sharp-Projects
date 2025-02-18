using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace METHODS_AND_OBJECTS_SUBMISSION_ASSIGNMENT
{
    // Represents a person
    public class Person
    {
        // Two properties of data type string
        // FirstName and LastName
        public string FirstName { get; set; }
        public string LastName { get; set; }

        // This method prints full name to console
        public void SayName()
        {
            Console.WriteLine($"Name: {this.FirstName} {this.LastName}");
        }
    }
}
