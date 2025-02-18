using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MAIN_METHOD_SUBMISSION_ASSIGNMENT
{
    // This class is used to perform certain math operations
    internal class MathOperations
    {
        // This method takes in an integer
        // Triples it and returns it
        public int Calculation(int x)
        {
            return x * 3;
        }

        // Method Overload
        // This method is named Calculation() as well
        // Just takes in a decimal and divides it by 2
        // Then converts it to an Integer and returns the value
        public int Calculation(decimal x)
        {
            return Convert.ToInt32(x / 2.00m);
        }

        // Another method overload
        // This f() takes in a string(number), converts it to int
        // and adds 100 to it then returns it as an integer
        public int Calculation(string number)
        {
            return Convert.ToInt32(number) + 100;
        }
    }
}
