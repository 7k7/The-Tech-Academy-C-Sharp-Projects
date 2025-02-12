using System;

namespace Boolean_Logic_Submission_Assignment
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Application questions for the applicant

            // Variables to ues later for comparisons
            int age = 0;
            int tickets = 0;
            bool isDui = true;

            // Request user input a valid number
            Console.WriteLine("What is your age?");
            string userInputAge = Console.ReadLine();
            // Request a true or false answer to the question.
            Console.WriteLine("true or false: Have you ever had a DUI?");
            // makes sure it is lower cased to avoid boolean casting issues
            string userDui = Console.ReadLine().ToLower();
            // Request a number of speeding tickets from user
            Console.WriteLine("How many speeding tickets do you have");
            string userTickets = Console.ReadLine();

            try // will catch any invalid user input;
            {
                age = Int32.Parse(userInputAge);
                isDui = Boolean.Parse(userDui);
                tickets = Int32.Parse(userTickets);

                // Check and compare user data against the following qualification rules for car insurance
                bool isQualified = (age > 15 && isDui is false && tickets <= 3);
                Console.WriteLine("According to the qualification rules, do we deem you qualified for car insurance?");
                Console.WriteLine(isQualified.ToString());
            }
            catch (FormatException e) 
            { 
                Console.WriteLine($"Your input is invalid: " + e.Message);
            }
        }
    }
}
