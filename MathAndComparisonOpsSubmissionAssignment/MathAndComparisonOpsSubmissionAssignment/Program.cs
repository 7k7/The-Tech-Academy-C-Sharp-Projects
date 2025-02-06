using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MathAndComparisonOpsSubmissionAssignment
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Print message to console
            Console.WriteLine("Anonymous Income Comparision Program");

            // Print 'Person 1' to console then gather user input for this person
            Console.WriteLine("Person 1");
            Console.WriteLine("Preson 1, what is your hourly rate?");
            string person1HourRate = Console.ReadLine();
            Console.WriteLine("Person 1, how many hours have you worked?");
            string person1HoursWorked = Console.ReadLine();

            // Print 'Person 2' to console then gather user input for this person
            Console.WriteLine("Person 2");
            Console.WriteLine("Preson 2, what is your hourly rate?");
            string person2HourRate = Console.ReadLine();
            Console.WriteLine("Person 2, how many hours have you worked?");
            string person2HoursWorked = Console.ReadLine();

            // This will catch if the user input is invalid
            // aka not a number that can successfully convert to a double
            try 
            {
                // Print message then display exact salary for 'Person 1'
                Console.WriteLine("Annual salary of Person 1:");
                // Converts string to decimal for exact salary amount
                // Then multiplies both decimal numbers to get salary
                decimal salaryP1 = Decimal.Parse(person1HourRate) * Decimal.Parse(person1HoursWorked);
                Console.WriteLine($"${salaryP1.ToString()}");

                // Print message then display exact salary for 'Person 2'
                Console.WriteLine("Annual salary of Person 2:");
                // Converts string to decimal for exact salary amount
                // Then multiplies both decimal numbers to get salary
                decimal salaryP2 = Decimal.Parse(person2HourRate) * Decimal.Parse(person2HoursWorked);
                Console.WriteLine($"${salaryP2.ToString()}");

                // Print message then compare both people's salary and output result
                Console.WriteLine("Does Person 1 make more money than Person 2?");
                // If Person 1 makes more money, it will be true, if not, it will be false
                bool compareSalaries = salaryP1 > salaryP2;
                Console.WriteLine(compareSalaries.ToString());
            }
            catch (FormatException e) // User input is invalid throw message
            {
                Console.WriteLine("Unable to parse: " + e.Message);
            }
        }
    }
}
