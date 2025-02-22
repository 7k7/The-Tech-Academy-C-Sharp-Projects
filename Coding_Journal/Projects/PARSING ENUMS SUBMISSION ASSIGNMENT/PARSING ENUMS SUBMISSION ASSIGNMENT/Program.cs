using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PARSING_ENUMS_SUBMISSION_ASSIGNMENT
{
    public class Program
    {
        static void Main(string[] args)
        {
            try
            {
                // Prompt user to enter current day
                Console.WriteLine("Please enter the current day: ");

                // user input is parsed to a variable of the enum type
                string userInput = Console.ReadLine();

                // Enum.Parse<T> method converts a string into an enumerator of an enum
                DayOfWeek currentDay = (DayOfWeek)Enum.Parse(typeof(DaysOfTheWeek), userInput);
            } catch (ArgumentException e)
            {
                Console.WriteLine($"Please enter an actual day of the week: {e}");
            }
            catch (OverflowException e)
            {
                Console.WriteLine(e.Message);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }

            // Using the Enum.TryParse<T>() 
            // Does not throw any exception, can make matching string to enum case-insensitive
            // and returns a boolean value whether it was able to match a string to an enum
            Console.WriteLine("using the TryParse method");

            // Prompt user to enter current day
            Console.WriteLine("Please enter the current day: ");

            // user input is parsed to a variable of the enum type
            string input = Console.ReadLine();

            // Check whether user input is a valid actual day
            // The Enum.TryParse method trys to match the input string to an enum
            // true sets it case-insensitive, so Monday == monDaY
            // If True, assign the userinput it in Today var of type DaysOfWeek
            if (Enum.TryParse<DaysOfTheWeek>(input, true, out DaysOfTheWeek today))
            {
                Console.WriteLine($"It is a valid day: {today}");
            }
            else
            {
                Console.WriteLine($"Please enter an actual day. Not this: {input}");
            }
        }
    }
}
