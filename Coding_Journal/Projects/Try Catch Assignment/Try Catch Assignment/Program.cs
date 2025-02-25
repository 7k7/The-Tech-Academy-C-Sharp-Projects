using System;

namespace Try_Catch_Assignment
{
    class Program
    {
        static void Main(string[] args)
        {
            // Prompt user for their age
            Console.WriteLine("Hi, please enter your age:");

            // To make age accessible outside try block
            int age = 0;

            // Catch any exceptions from user input
            try
            {
                string userInput = Console.ReadLine(); // user input
                age = int.Parse(userInput); // attempt to parse input

                // Check for a negative age
                if (age <= 0)
                {
                    // Manually throw an exception
                    throw new ArgumentException("Age must be greater than zero.");
                }
                // output age
                Console.WriteLine($"You entered: {age}");

                // display the year the user was born
                DateTime dateTimeBorn = DateTime.Now.AddYears(-age);
                Console.WriteLine($"The year you were born: {dateTimeBorn.Year}");
            }
            catch (FormatException e) // Catch invalid formatted numbers
            {
                Console.WriteLine($"Error: Must enter a number.");
            }
            catch (ArgumentException e) // Catch the manually thrown exception
            {
                Console.WriteLine($"Error: {e.Message}");
            }
            catch (Exception e) // for any errors
            {
                Console.WriteLine("An error ocurred: "+ e.Message);
            }
            finally
            {
                Console.WriteLine("Execution is complete.");
            }
        }
    }
}
