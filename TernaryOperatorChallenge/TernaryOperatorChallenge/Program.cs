using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TernaryOperatorChallenge
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // ask user input for age
            Console.WriteLine("How old are you?");
            int age = Int32.Parse(Console.ReadLine());

            // user ternary operator to evalute user's age 
            string isOldEnough = age >= 21 ? "You may vote." : "You are not old enough to vote.";
            Console.WriteLine(isOldEnough);
        }
    }
}
