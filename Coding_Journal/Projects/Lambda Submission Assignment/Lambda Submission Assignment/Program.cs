using System;
using System.Collections.Generic;
using System.Linq;

namespace Lambda_Submission_Assignment
{
    public class Program
    {
        static void Main(string[] args)
        {
            // List of 10 Employees data 
            List<Employee> employees = new List<Employee>
            {
                new Employee(1, "Joe", "Smith"),
                new Employee(2, "Joe", "Smith"),
                new Employee(3, "Anna", "Smith"),
                new Employee(4, "James", "Smith"),
                new Employee(5, "Jack", "Smith"),
                new Employee(6, "Sarah", "Smith"),
                new Employee(7, "John", "Smith"),
                new Employee(8, "Ethan", "Smith"),
                new Employee(9, "Michael", "Smith"),
                new Employee(10, "Kate", "Smith")
            };

            // using a foreach loop to create a new list of all employess
            // with the first name 'Joe'
            List<Employee> allJoes = new List<Employee>();
            foreach (Employee employee in employees)
            {
                if (employee.FirstName == "Joe")
                {
                    allJoes.Add(employee);
                }
            }

            // Same result as the above foreach
            // But using this lambda expression
            List<Employee> joesOnly = employees.Where(employee => employee.FirstName == "Joe").ToList();

            // Lets print them out
            Console.WriteLine("Employees named Joe:");
            foreach (Employee employee in joesOnly)
            {
                Console.WriteLine(employee.ToString());
            }

            // A list of all employees with an Id number greater than 5
            // Where() filters the original employees list
            List<Employee> greaterThan5 = employees.Where(employee => employee.Id > 5).ToList();

            // Print employees greater than 5 as well
            Console.WriteLine("Employess with an Id greater than 5");
            foreach (Employee employee in greaterThan5)
            {
                Console.WriteLine(employee.ToString());
            }
        }
    }
}
