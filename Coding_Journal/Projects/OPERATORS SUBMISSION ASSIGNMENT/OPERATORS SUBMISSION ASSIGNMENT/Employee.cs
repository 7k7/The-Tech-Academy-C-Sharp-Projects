using System;

namespace OPERATORS_SUBMISSION_ASSIGNMENT
{
    // Employee class with certain properties
    public class Employee
    {
        public string Id { get; set; }
        public string FirstName { get; set; }   
        public string LastName { get; set; }

        // overloaded == and != operators
        public static Boolean operator== (Employee one, Employee two)
        {
            // Checks if the two Employee objects are equal by Id field
            bool isEqual = one.Id == two.Id;
            return isEqual;
        }

        public static Boolean operator!= (Employee one, Employee two)
        {
            // Checks if both Employees's Ids are not equal
            bool isNotEqual = one.Id != two.Id;
            return isNotEqual;
        }
    }
}
