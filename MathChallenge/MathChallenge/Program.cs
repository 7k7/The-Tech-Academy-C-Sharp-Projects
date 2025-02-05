using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MathChallenge
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Add two numbers and display the output in the console.
            int num1 = 10;
            int num2 = 20;
            Console.WriteLine(num1 + num2);

            //Subtract two numbers and display output in the console.
            Console.WriteLine(num1 - num2);

            //Multiply two numbers and display the output in the console.
            Console.WriteLine(num1 * num2);

            //Divide two numbers and display the output in the console.
            Console.WriteLine(num2 / num1);

            //MATH STRING CHALLENGE
            string firstName = "Kevin";
            string lastName = "Montano";
            string fullName = firstName + " " + lastName;
            Console.WriteLine(fullName);
        }
    }
}
