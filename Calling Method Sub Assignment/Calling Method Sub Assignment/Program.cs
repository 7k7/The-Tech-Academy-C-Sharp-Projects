using System;

namespace Calling_Method_Sub_Assignment
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Ask user what number they want to do some math operations on
            Console.WriteLine("What number would you like" +
                "to perform some math operations on?");

            try
            {
                // Take and store integer from user input
                int userInput = Convert.ToInt32(Console.ReadLine());

                // Instantiate MathOperations to call its methods
                MathOperations mathOps = new MathOperations();

                // Pass user input in each of the three methods in that class
                int method1 = mathOps.Double(userInput);
                int method2 = mathOps.DivideByTwo(userInput);
                int method3Result = mathOps.EvenOrOdd(userInput);
                string method3 = method3Result == 0
                    ? $"The remainder of {userInput} divided by 2 = {method3Result}. Therefore, even"
                    : $"The remainder of {userInput} divided by 2 = {method3Result}. Therefore, odd";

                // Log to console the results for the user to see
                Console.WriteLine($"Double {userInput} is {method1}");
                Console.WriteLine($"{userInput} divided by 2 = {method2}");
                Console.WriteLine(method3);
            }
            catch (FormatException e)
            {
                Console.WriteLine("Please enter an interger.");
                return;
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                return;
            }
        }
    }
}
