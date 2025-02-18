using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace METHOD_CLASS_SUBMISSION_ASSIGNMENT
{
    // This class performs certain math operations
    internal class Calculator
    {
        // This method takes in two integers as parameters.
        // Adds the first and second then display the second number
        public void Calculate(int num1, int num2)
        {
            int result = num1 + num2;
            Console.WriteLine($"This is the second integer: {num2}");
        }
    }
}
