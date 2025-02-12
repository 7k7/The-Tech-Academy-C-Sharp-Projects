using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Console_App_Sub_Assignment
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // This showcases the use while loop to do a boolean comparison

            // Ask question for user input
            Console.WriteLine("Does ternary mean composed of: 1, 2, or 3 parts?");
            int response = Convert.ToInt32(Console.ReadLine());

            // This bool var is used to break the while loop once the user
            // gets the right answer
            bool isRight = false;

            while (!isRight)
            {   
                switch (response) // there are only 3 possible answers
                {
                    case 1: // each case is one of the three possible answers
                        Console.WriteLine("It is not 1.");
                        // Allow user to try again
                        Console.WriteLine("Choose another number.");
                        response = Convert.ToInt32(Console.ReadLine());
                        break; // each break restarts the while loop till isRight is True
                    case 2:
                        Console.WriteLine("2 is not the right answer.");
                        // Allow user to try again
                        Console.WriteLine("Choose another number.");
                        response = Convert.ToInt32(Console.ReadLine());
                        break;
                    case 3: // this is the right answer
                        Console.WriteLine("3 is the correct answer.");
                        isRight = true; // While loop will not execute because expression is True
                        break;
                    default:
                        Console.WriteLine("Must only choose 1, 2, or 3 please.");
                        // Allow user to try again
                        Console.WriteLine("Choose another number.");
                        response = Convert.ToInt32(Console.ReadLine());
                        break;
                }
            }

            // This showcases the use do while loop to do a boolean comparison

            // Ask question for user input
            Console.WriteLine("(do while) Does ternary mean composed of: 1, 2, or 3 parts?");
            int answer = Convert.ToInt32(Console.ReadLine());

            // This bool var is used to break the while loop once the user
            // gets the right answer
            isRight = answer == 3;

            do
            {
                switch (answer)
                {
                    case 1: // each case is one of the three possible answers
                        Console.WriteLine("It is not 1.");
                        // Allow user to try again
                        Console.WriteLine("Choose another number.");
                        answer = Convert.ToInt32(Console.ReadLine());
                        break; // each break restarts the while loop till isRight is True
                    case 2:
                        Console.WriteLine("2 is not the right answer.");
                        // Allow user to try again
                        Console.WriteLine("Choose another number.");
                        answer = Convert.ToInt32(Console.ReadLine());
                        break;
                    case 3: // this is the right answer
                        Console.WriteLine("3 is the correct answer.");
                        answer = 3; // While loop will not execute because expression is True
                        break;
                    default:
                        Console.WriteLine("Must only choose 1, 2, or 3 please.");
                        // Allow user to try again
                        Console.WriteLine("Choose another number.");
                        answer = Convert.ToInt32(Console.ReadLine());
                        break;
                }
            }
            while (!isRight);
        }
    }
}
