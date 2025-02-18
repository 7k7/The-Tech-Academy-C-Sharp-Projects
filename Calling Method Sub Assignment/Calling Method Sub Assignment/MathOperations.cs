using System;
using System.Collections.Generic;

namespace Calling_Method_Sub_Assignment
{
    // This class performs certain math operations on user input
    public class MathOperations
    {
        // This first method takes in an integer,
        // doubles it and returns it
        public int Double(int input)
        {
            return input * 2;
        }

        // Second method takes in an integer
        // divides it by 2 then returns it
        public int DivideByTwo(int input)
        {
            return input / 2;
        }

        // Third method takes in an integer
        // divides it by two and returns the result
        // Possible values:
        // If 0, the input was an even int
        // If 1, the input was an odd #
        public int EvenOrOdd(int input)
        {
            return input % 2;
        }
    }
}
