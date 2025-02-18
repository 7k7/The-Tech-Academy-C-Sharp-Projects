using System;

namespace METHOD_SUBMISSION_ASSIGNMENT
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Instantiate Calculator 
            Calculator calculator = new Calculator();

            // Prompt user for two numbers one at a time
            // Print a message that the 2nd # is optional
            Console.WriteLine("Please enter a number: ");
            int inputNum1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Please the second number. " +
                "(Or press Enter to use the default value 1): ");
            string inputNum2 = Console.ReadLine();

            // Hold the return value of the f() call
            int result;

            // Check if user provided a second number 
            if (string.IsNullOrWhiteSpace(inputNum2))
            {
                // Only the first number is passed if True
                result = calculator.Add(inputNum1);
            }
            else
            {
                // but if there is a second number
                // pass both to Add()
                int num2 = Convert.ToInt32(inputNum2);
                result = calculator.Add(inputNum1, num2);
            }
            // print the result 
            Console.WriteLine("The sum: {0}", result);
            
            Console.ReadLine();
        }
    }
}
