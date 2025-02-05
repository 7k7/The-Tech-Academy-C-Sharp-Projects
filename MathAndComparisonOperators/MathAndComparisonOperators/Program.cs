using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MathAndComparisonOperators
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Add numbers
            //int total = 5 + 10;
            //int otherTotal = 12 + 22;
            //int combined = total + otherTotal;
            //Console.WriteLine("Five plus Ten = " + total.ToString()); 
            //Console.WriteLine(combined);

            //Subtract
            //int difference = 10 - 5;
            //Console.WriteLine("Ten minus Five = " + difference.ToString());

            //Multiplication
            //int product = 10 * 5;
            //Console.WriteLine(product);

            //Division
            //int quotient = 100 / 5;
            //Console.WriteLine(quotient);

            //More precise, accurate quotient-use double
            //Will not work if they are integers like: 100 / 17
            //double quotient = 100.0 / 17.0;
            //Console.WriteLine(quotient.ToString());

            //Modulus operator (%) means the remainder of a division
            //Useful to know if a number is odd or even when divided by 2.
            //odd is 1 and even is 0 
            //int remainder = 10 % 2;//10 is an even number
            //Console.WriteLine(remainder.ToString());

            //COMPARISON OPERATORS
            //They output a boolean
            //bool trueOrFalse = 12 > 5;// 12 is greater than 5 so true
            //Console.WriteLine(trueOrFalse.ToString());

            int roomTemp = 70;
            int currentTemp = 70;
            //Greater than or equal to comparison operator
            //Same would be for less than or equal to operator
            //bool isWarm = currentTemp >= roomTemp;
            //Console.WriteLine(isWarm);

            //Check for equality using the equality operator
            //Double equals checks for equality
            Console.WriteLine("is it room temperature here? " + (roomTemp == currentTemp).ToString());
            //Not equal is !=
            Console.WriteLine("is it not really hot here?" + (currentTemp != 100).ToString());
        }
    }
}
