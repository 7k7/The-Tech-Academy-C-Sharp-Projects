using System;

namespace DATE_TIME_SUBMISSION_ASSIGNMENT
{
    class Program
    {
        static void Main(string[] args)
        {
            // print current date and time to console
            Console.WriteLine(DateTime.Now);

            // prompt user for a number and store it
            Console.WriteLine("Hello, please enter a number:");
            TimeSpan hours = TimeSpan.FromHours(Convert.ToInt32(Console.ReadLine()));

            // Print to console the exact time it will be in the amount of hours
            // the user entered
            TimeSpan futureTime = DateTime.Now.TimeOfDay.Add(hours);
            Console.WriteLine($"The exact time it will in {hours} hour(s): {futureTime}");
        }
    }
}
