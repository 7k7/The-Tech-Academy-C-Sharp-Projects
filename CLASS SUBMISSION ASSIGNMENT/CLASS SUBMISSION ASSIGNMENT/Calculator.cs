using System;

namespace CLASS_SUBMISSION_ASSIGNMENT
{
    // Class does math operations on numbers
    internal class Calculator
    {
        // Fields that hold the current product value
        // of the DivideByTwo method math operation
        public int quotient { get; set; }

        // f() is void but displays an integer
        // Divides a number by two
        public void DivideByTwo(int x)
        {
            Console.WriteLine(x);
            this.quotient = x / 2;
        }

        // This f() contains a output parameter
        // It will return the difference to main program 
        // through this parameter
        public void SubtractByTwo(int x, out int difference)
        {
            difference = x - 2;
        }

        // This is a method overload of DivideByTwo()
        // Takes in a word and returns the quotient of
        // the word character amount divided by two
        public void DivideByTwo(string word)
        {
            int result = word.Length / 2;
            Console.WriteLine($"{word}\'s length divided by two = {result}");
        }
    }
}
