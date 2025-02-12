using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Branching_Submission_Assignment
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Welcome message print
            Console.WriteLine("Welcome to Package Express. Please follow the instructions below");

            // Request user to input package weight
            Console.WriteLine("Please enter the package weight:");
            int weight = Convert.ToInt32(Console.ReadLine());

            // Request for width input
            Console.WriteLine("Please enter the package width:");
            int width = Convert.ToInt32(Console.ReadLine());

            // Request for height input
            Console.WriteLine("Please enter the package height:");
            int height = Convert.ToInt32(Console.ReadLine());

            // Request for length input
            Console.WriteLine("Please enter the package length:");
            int length = Convert.ToInt32(Console.ReadLine()); 

            // Evaluate user input 
            if (weight > 50)
            {
                Console.WriteLine("Package too heavy to be shipped via Package Express." +
                    " Have a good day.");
                return;
            }

            // If the dimensions(WxHxL) total is more than 50
            // it will print this message
            if (width + height + length > 50)
            {
                Console.WriteLine("Package too big to be shipped via Package Express.");
                return;
            }

            int quote = ((height * width * length) * weight) / 100;
            Console.WriteLine($"Your estimate total for shipping this package is: ${quote}.00"
                + "\nThank you!");
        }
    }
}
