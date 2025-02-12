using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OperatorChallenge
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Ask question for user input then evaluate 
            Console.WriteLine("Do you have a valid driver's license? True or False");
            bool isValid = Boolean.Parse(Console.ReadLine());

            if (!isValid)
            {
                // Check if can register user
                Console.WriteLine("What state are you from");
                string state = Console.ReadLine().ToLower();

                if (state != "oregon") 
                {
                    Console.WriteLine($"You should get your license from your state in {state}");
                }
                else if (state == "oregon")
                {
                    Console.WriteLine("Let us get you your driver's license.");
                }
            }
            else if (isValid)
            {
                Console.WriteLine("Welcome back to Oregon!");
            }
        }
    }
}
