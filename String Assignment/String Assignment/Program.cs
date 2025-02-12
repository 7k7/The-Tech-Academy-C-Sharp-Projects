using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace String_Assignment
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Concatenate 3 strings //

            // Ask user for first, middle and last name input to concatenate then output
            Console.WriteLine("What is your first name?");
            string firstName = Console.ReadLine();
            Console.WriteLine("What is your middle name?");
            string middleName = Console.ReadLine();
            Console.WriteLine("What is your last name?");
            string lastName = Console.ReadLine();

            string fullName = firstName + " " + middleName + " " + lastName;
            Console.WriteLine($"Your full name is: {fullName}");
            // Converts a string to uppercase //

            // Lets output that full name in all uppercase letters
            Console.WriteLine($"Your full name in all caps: {fullName.ToUpper()} ");

            // Creates a Stringbuilder and builds a paragraph text, one sentence at a time. //

            // Loops iterates each time for a sentence a user will input in the console
            // Stringbuilder var will hold the paragraph of text
            // isDone is the conditional used to keep the loop iterating until user is done
            StringBuilder stringBuilder = new StringBuilder();
            bool isDone = false;

            // Output messgae to user
            Console.WriteLine("Lets build a paragraph.");

            do
            {
                // Adds the sentence given by user to the stringbuilder
                Console.WriteLine("Ok, please enter one sentence:");
                stringBuilder.Append(Console.ReadLine());

                // ASk user if done to stop the loop and appending
                Console.WriteLine("Are you finished with your paragraph? True or False");
                isDone = Convert.ToBoolean(Console.ReadLine().ToLower());
            }
            while (!isDone);

            Console.WriteLine($"Here is your paragraph:\n{stringBuilder}");

            Console.ReadLine();
        }
    }
}
