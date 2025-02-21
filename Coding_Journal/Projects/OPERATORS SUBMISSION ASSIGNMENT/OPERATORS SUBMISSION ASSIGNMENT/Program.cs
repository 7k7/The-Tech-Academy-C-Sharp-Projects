using System;

namespace OPERATORS_SUBMISSION_ASSIGNMENT
{
    public class Program
    {
        static void Main(string[] args)
        {
            // Two Employee instances
            Employee employee1 = new Employee();
            Employee employee2 = new Employee();

            // Assign property values
            employee1.Id = "1";
            employee2.Id = "2";
            employee1.FirstName = "John";
            employee2.FirstName = "Mike";
            employee1.LastName = "Smith";
            employee2.LastName = "Davis";

            // Compare both Employee objects using the overloead operators
            string isEqual = employee1 == employee2
                ? $"True, Employee {employee1.FirstName} and {employee2.FirstName} are equal"
                : $"False, Employee {employee1.FirstName} and {employee2.FirstName} are not equal";
            string isNotEqual = employee1 != employee2
                ? $"True, Employee {employee1.FirstName} and {employee2.FirstName} are not equal"
                : $"False, Employee {employee1.FirstName} and {employee2.FirstName} are equal";

            // Display the results
            Console.WriteLine(isEqual);
            Console.WriteLine(isNotEqual);
        }
    }
}
