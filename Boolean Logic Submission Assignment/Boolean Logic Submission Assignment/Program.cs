using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Boolean_Logic_Submission_Assignment
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Application questions for the applicant

            // Request user input; must be a number only.
            Console.WriteLine("What is your age?");
            string userInputAge = Console.ReadLine();
            int age = 0;

            try // will catch any invalid user input; must be a number
            {
                age = Int32.Parse(userInputAge);
            }
            catch (FormatException) 
            { 
                Console.WriteLine($"Your input, '{userInputAge}', is not a valid number for your age.");
            }
 
            // Request a true or false answer to the question.
            Console.WriteLine("true or false: Have you ever had a DUI?");
            string userDui = Console.ReadLine().ToLower();// makes sure it is lower cased to avoid boolean casting issues
            bool isDui = true;

            // Check user input is valid. 
            try
            {
                if (userDui is string) // make sure it is a string value
                {
                    // Makes sure it is a boolean value
                    if (Boolean.Parse(userDui) is Boolean)
                    { isDui = Boolean.Parse(userDui); }
                }
            }
            catch (FormatException)
            {
                Console.WriteLine($"Your input, '{userDui}', is not a valid response.");
                return;
            }

            // Request a number of speeding tickets from user
            Console.WriteLine("How many speeding tickets do you have");
            string userTickets = Console.ReadLine();
            int tickets = 0;

            // Check user input is a valid value/number
            try
            {
                if (userTickets is string)
                {
                    if (Int32.Parse(userTickets) is int)
                    {
                        tickets = Int32.Parse(userTickets);
                    }
                    else 
                    {
                        Console.WriteLine($"Your input, '{userTickets}', is not an integer.");
                        return;
                    }
                }
            }
            catch (FormatException e)
            {
                Console.WriteLine($"User input is invalid: '{userTickets}'... " + e.Message);
            }

            // Check and compare user data against the following qualification rules for car insurance
            bool isQualified = (age > 15 && isDui is false && tickets <= 3);
            Console.WriteLine("According to the qualification rules, do we deem you qualified for car insurance?");
            Console.WriteLine(isQualified.ToString());
        }
    }
}
