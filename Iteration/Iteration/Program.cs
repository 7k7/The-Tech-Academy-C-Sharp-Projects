using System;
using System.Collections.Generic;

namespace Iteration
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //int[] testScores = { 98, 99, 85, 70, 82, 34, 91, 90, 94 };

            // Iterate over that integer array
            // Log to console, the passing grade (>85) items

            // Three conditions in for loop parenthesis
            // First condition, is the starting value
            // 2nd, for how long. Boolean logic
            // 3rd, what to do after each iteration
            //for (int i = 0; i < testScores.Length; i++)
            //{
            //    // greater than 85 is passing score
            //    if (testScores[i] > 85)
            //    {
            //        Console.WriteLine("Passing test score " + testScores[i]);
            //    }
            //}

            // Now with a String array //

            // String array
            //string[] names = { "Jesse", "Erik", "Daniel", "Adam" };


            // Prints only the matching indices to "Jesse"
            //for (int i = 0; i < names.Length; i++)
            //{
            //    if (names[i] == "Jesse")
            //    {
            //        Console.WriteLine(names[i]);
            //    }
            //}

            // Print all to console
            //for (int i = 0; i < names.Length; i++)
            //{
            //    Console.WriteLine(names[i]);
            //}

            // Iteration with Lists
            // Have more builtin functions; more useful than arrays
            // iterating is better than array

            // crate int list
            // List is a classs and you must instantiate it as an object 
            // like this: 
            //List<int> testScores = new List<int>();
            //// Add items
            //testScores.Add(98);
            //testScores.Add(99);
            //testScores.Add(81);
            //testScores.Add(72);
            //testScores.Add(70);

            // iterate over this list and log to console passing scores only
            //foreach (int score in testScores)
            //{
            //    if (score > 85) // score is a var respresenting the current index in testSscores List
            //    {
            //        Console.WriteLine($"Passing test score: {score}");
            //    }
            //}

            // Now with a list of strings
            // another way of instantiating a List 
            // by directing adding in the values
            // name List vars in plural so as to use the singular version in the foreach loop
            //List<string> names = new List<string>() { "Jesse", "Erik", "Adam", "Daniel" };

            //// loops through each
            //foreach (string name in names)
            //{
            //    //if (name == "Jesse")
            //    //{
            //    //    Console.WriteLine(name);
            //    //}

            //    // print all names to the console
            //    Console.WriteLine(name);
            //}

            // Creating a List out of another List
            // by using foreach to make it based on conditions

            List<int> testScores = new List<int>() { 98, 99, 12, 74, 23, 99 };
            // this List will be added to by foreach loop
            List<int> passingScores = new List<int>();

            // iterate
            foreach (int score in testScores)
            {
                if (score > 85)
                {
                    passingScores.Add(score);
                    Console.WriteLine($"Added score: {score} ");
                }
            }

            Console.WriteLine($"There were: {passingScores.Count} passing scores");


            Console.ReadLine();
        }
    }
}
