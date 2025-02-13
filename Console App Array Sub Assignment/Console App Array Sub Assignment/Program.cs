using System;
using System.Collections.Generic;

namespace Console_App_Array_Sub_Assignment
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // One-dimensional Array of strings. User selects an index 
            // to display it 

            // of array of a groceries list will be used
            string[] groceries = { "banannas", "milk", "cheese", "salad" };

            // Prompt user to input an integer
            Console.WriteLine("You have four items in your groceries list.");
            Console.WriteLine("Please type 0, 1, 2, or 3 to view an item.");

            // Output index value based on the user input
            int userSelectedIndex = Convert.ToInt32(Console.ReadLine());

            // Message will display depending on whether the chosen index exists
            string printGroceriesMessage = userSelectedIndex >= 0 && userSelectedIndex < groceries.Length
                ? $"You have selected: {groceries[userSelectedIndex]}"
                : $"This index, '{userSelectedIndex}', does not exist."; 
            Console.WriteLine(printGroceriesMessage);

            // One-dimensional Array of strings. User selects an index 
            // to display it 

            // Array of registers at a grocery store
            int[] registers = { 2, 5, 7, 1 };

            // Ask user to input an integer 
            Console.WriteLine("There are four registers open to help you checkout.");
            Console.WriteLine("Please type either 0, 1, 2, or 3 to select an open register.");

            // Prints to console the index value chosen by the user
            userSelectedIndex = Convert.ToInt32(Console.ReadLine());
            string message = userSelectedIndex >= 0 && userSelectedIndex < registers.Length
                ? $"You may proceed to register: {registers[userSelectedIndex]}"
                : $"This index, '{userSelectedIndex}'. does not exist.";
            Console.WriteLine(message);

            // Now the same for a list of strings //

            // A List this time of ways to carry your groceries
            List<string> options = new List<string>();
            // Add items
            options.Add("plastic bag");
            options.Add("reusable bag");
            options.Add("your own bag");
            options.Add("none");

            // Prompt user to input an integer
            Console.WriteLine("Now choose either 0, 1, 2, or 3 to select one option to carry your groceries:");

            // Store input for later eval
            userSelectedIndex = Convert.ToInt32(Console.ReadLine());

            // Based on the index chosen by user
            // One of two messages will print
            message = userSelectedIndex >= 0 && userSelectedIndex < options.Count
                ? $"You have selected: {options[userSelectedIndex]}"
                : $"This index, '{userSelectedIndex}', does not exist.";
            // print message
            Console.WriteLine(message);

            Console.ReadLine();

        }
    }
}
