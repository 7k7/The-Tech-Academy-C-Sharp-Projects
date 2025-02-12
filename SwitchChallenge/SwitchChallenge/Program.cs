using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SwitchChallenge
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Switch block
            Console.WriteLine("What is your score from 1 - 10?");
            int score = Convert.ToInt32(Console.ReadLine());

            // Switch statement
            switch(score)
            {
                case 10:
                    Console.WriteLine("Perfect score!");
                    break;
                case 9:
                    Console.WriteLine("Excellent job!");
                    break;
                case 8:
                    Console.WriteLine("You did great!");
                    break;
                case 7:
                    Console.WriteLine("Good job!");
                    break;
                default:
                    Console.WriteLine("Better luck next time.");
                    break;

            }
        }
    }
}
