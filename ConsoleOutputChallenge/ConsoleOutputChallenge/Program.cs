using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleOutputChallenge
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // ASk for test score to evaluate 
            Console.WriteLine("What was your test score?");
            int testScore = Int32.Parse(Console.ReadLine());

            if (testScore > 50)
            {
                Console.WriteLine("You passed!");
            }
            else if (testScore <= 50)
            {
                Console.WriteLine("You did not pass.");
            }
        }
    }
}
