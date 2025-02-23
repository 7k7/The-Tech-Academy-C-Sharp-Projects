
namespace Lambda_Submission_Assignment
{
    // Employee class
    public class Employee
    { 
        // Constructor to initilize Employee properties
        public Employee(int id, string firstName, string lastName)
        {
            Id = id;
            FirstName = firstName;
            LastName = lastName;
        }

        // Public getters 
        public int Id { get; }
        public string FirstName { get; }
        public string LastName { get; }

        // Override ToString() to apply a better format
        public override string ToString()
        {
            return $"Id #{Id}: {FirstName} {LastName}";
        }
    }
}
