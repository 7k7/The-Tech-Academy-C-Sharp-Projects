using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MAIN_METHOD_SUBMISSION_ASSIGNMENT
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Instantiate MathOperations, Call TripleValue
            // Passing in an integer then diplay rsult
            MathOperations mathOps1 = new MathOperations();
            int result1 = mathOps1.Calculation(10);
            Console.WriteLine($"10 * 3 = {result1}");

            // Another instance of MathOperations
            // Call Calculation() passing a decimal
            // Log result to console
            MathOperations mathOps2 = new MathOperations();
            int result2 = mathOps2.Calculation(10.00m);
            Console.WriteLine("10.00 divided by 2.00 = {0}", result2);

            // Another instance of MathOperations
            // Call to Calculation() passing in an integer
            // Then display to screen the result
            MathOperations mathOps3 = new MathOperations();
            int result3 = mathOps3.Calculation("100");
            Console.WriteLine("100 + 100 = {0}", result3);
        }
    }
}
