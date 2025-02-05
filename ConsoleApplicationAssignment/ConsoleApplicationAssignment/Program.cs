using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplicationAssignment
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Receive a number from user input 
            Console.WriteLine("Please enter a number: ");
            string userInput =  Console.ReadLine();

            // try catch block
            try
            {
                int numInput = Int32.Parse(userInput);

                // Multiply user input by 50, then print the result
                int result = numInput * 50;
                Console.WriteLine($"Your input, '{userInput}', times 50 = " + result);

                // Add 25 to user input, then print the result
                result = numInput + 25;
                Console.WriteLine($"Your input, '{userInput}', plus 25 = " + result);

                // Divide input by 12.5 then print result
                double resultAsDouble = Convert.ToDouble(numInput) / 12.5;
                Console.WriteLine($"Your input, '{userInput}', divided by 12.5 = " + resultAsDouble);

                // Check if input is greater than 50 then print true/false result
                bool isGreater = numInput > 50;
                Console.WriteLine($"Is your input, '{userInput}', greater than 50? " + Convert.ToString(isGreater));

                // Print the remainder of the input divided by 7
                int remainder = numInput % 7;
                Console.WriteLine($"Your input, '{userInput}', divided by 7, the remainder = " + remainder);
            }
            catch (FormatException) // Throws error if user input is not a integer
            {
                Console.WriteLine($"Unable to parse '{userInput}'");
            }
        }
    }
}
