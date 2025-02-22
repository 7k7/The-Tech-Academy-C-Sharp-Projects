using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Parameters_Assignment
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Instance of Emplyee with string as the generic parameter
            Employee<string> employee = new Employee<string>();

            // Assign a list of strings to its property
            employee.things = new List<string>()
            {
                "Hello, ", "World!"
            };

            // Employee instance with int type as generic parameter
            Employee<int> employee2 = new Employee<int>();

            // Assign list of integers to its things prop
            employee2.things = new List<int>()
            {
                1, 2, 3
            };

            // These loops iterates through each Employees' Things List<>
            // and prints to Console
            foreach (string thing in employee.things)
            {
                Console.WriteLine(thing);
            }
            foreach (int thing in employee2.things)
            {
                Console.WriteLine(thing);
            }
        }
    }
}
