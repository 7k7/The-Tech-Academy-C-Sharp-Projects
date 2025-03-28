﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Loops
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Guess a number?");
            int num = Convert.ToInt32(Console.ReadLine());

            bool isGuessed = num == 12;

            do
            {
                switch (num)
                {
                    case 62:
                        Console.WriteLine("You guessed 62. try again.");
                        Console.WriteLine("Guess a number?");
                        num = Convert.ToInt32(Console.ReadLine());
                        break;
                    case 29:
                        Console.WriteLine("You guessed 29. Try again.");
                        Console.WriteLine("Guess a number?");
                        num = Convert.ToInt32(Console.ReadLine());
                        break;
                    case 55:
                        Console.WriteLine("You guessed 55. Try again.");
                        Console.WriteLine("Guess a number?");
                        num = Convert.ToInt32(Console.ReadLine());
                        break;
                    case 12:
                        Console.WriteLine("You guessed 12. That is correct.");
                        isGuessed = true;
                        break;
                    default:
                        Console.WriteLine("You are wrong.");
                        Console.WriteLine("Guess a number?");
                        num = Convert.ToInt32(Console.ReadLine());
                        break;
                }
            }
            while (!isGuessed);
        }
    }
}
