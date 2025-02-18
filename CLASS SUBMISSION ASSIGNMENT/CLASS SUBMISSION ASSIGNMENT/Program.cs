using System;

namespace CLASS_SUBMISSION_ASSIGNMENT
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Calculator instance
            Calculator calculator = new Calculator();

            // Prompt user for a number and store it
            Console.WriteLine("Please enter a number: ");
            int userInput = Convert.ToInt32(Console.ReadLine());

            // Call DivideByTwo on that #
            calculator.DivideByTwo(userInput);

            // Display the output to console
            Console.WriteLine($"{userInput} divided by 2 = {calculator.quotient}");

            // Demonstration of the SubtractByTwo() 
            // Display the output parameter 'difference'
            calculator.SubtractByTwo(userInput, out int difference);
            Console.WriteLine($"{userInput} minus 2 = {difference}");

            // Prompt user to enter a word to divide its length by two 
            Console.WriteLine("Please enter a word to divide its length by two");
            string word = Console.ReadLine();

            // Call overloaded method DivideByTwo() and pass in word
            calculator.DivideByTwo(word);
        }
    }
}
