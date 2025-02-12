using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConditionalStatementsChallenge
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Ask user to input age
            int age = Int32.Parse(Console.ReadLine());
            Console.WriteLine($"You are '{age}' year(s) old.");

            // If still underage, this will print
            if (age < 18)
            {
                Console.WriteLine("You are still underage.");
            }
            else if (age >= 18 && age < 40)
            {
                Console.WriteLine("You are a young adult.");
            }

            else if (age >= 40 && age < 60)
            {
                Console.WriteLine("You're getting there.");
            }
            else if (age >= 60)
            {
                Console.WriteLine("You're probably retired now.");
            }
        }
    }
}
