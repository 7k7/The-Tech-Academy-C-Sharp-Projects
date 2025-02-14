using System;
using System.Collections.Generic;

namespace Six_Part_Console_App_Sub_Assignment
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Assignment Part 1 //

            // 1. One-dimensional array of strings
            string[] oneDimArray = { "Hello", "World!" };

            // 2. Ask user to input some text
            Console.WriteLine("Please type in some random text");
            string userText = Console.ReadLine();

            // 3. A loop that iterates through each string in the above array
            // Appends user's text input to the end of each string item of the array
            for (int i = 0; i < oneDimArray.Length; i++)
            {
                oneDimArray[i] += " " + userText;
            }

            // 4. Create 2nd loop to log each string in the array to the console
            // one at a time
            for (int i = 0; i < oneDimArray.Length; i++)
            {
                Console.WriteLine($"Here is a string in the array: {oneDimArray[i]} ");
            }

            // Assignment Part 2 // 

            // 1. An infinite loop 
            // 2. Code is saved and is commented out
            //while (true) // Condition is always; loop executes every time
            //{
            //    Console.WriteLine("This is an infinite loop");
            //}

            // 3. The above nfinite loop fixed

            // This bool and string var is used to control the loop
            // Will continue to execute until the if statement catches
            // an "n" from user input; breaking the loop
            // loop continues as long as the user wants
            while (true)
            {
                Console.WriteLine("this is an finite loop");
                Console.WriteLine("If you would like to continue, type and enter 'n' please." +
                    " Otherwise, press enter:");
                string input = Console.ReadLine();
                if (input == "n")
                {
                    break;
                }
            }

            // Assignment Part 3 // 

            // 1. A for loop which iterates as long as # of iterations 
            // is less than the length of an integer array
            int[] integerArray = { 1, 5, 60, 4 };

            for (int i = 0; i < integerArray.Length; i++)
            {
                Console.WriteLine(integerArray[i]);
            }

            // 3. Another for loop which iterates as long as the # of iterations
            // is less than or equal to the amount entered by the user
            // Ask user for integer input to be used in loop
            Console.WriteLine("Please enter up to how many integers would you like to print?");
            int userAmount = Convert.ToInt32(Console.ReadLine());

            // for loop iterates the amount of times given from the user input
            // Each iteration prints an integer starting from 1 
            // and increasing only by one
            for (int i = 1; i <= userAmount; i++)
            {
                Console.WriteLine(i);
            }

            // Assignment Part 4 //

            // 1. A List of unique string, items
            List<string> uniqueList = new List<string>()
            {
                "one", "two", "three"
            };

            // 2. Ask user for text input to use it to search in the above list
            Console.WriteLine("Please enter text you would like to search in this List:");
            string text = Console.ReadLine();

            // 3. Foreach loop iterates over the uniqueList and logs to the console
            // if a list item matches the user's text input
            // 
            foreach (string item in uniqueList)
            {
                if (text == item)
                { 
                    Console.WriteLine("The index of this list item: " + uniqueList.IndexOf(item));
                    // 5. Strop the loop from executing after finding a match
                    break;
                }
            }
            // 4. Displays message relaying to user that their input text 
            // does not exist in the uniqueList
            if (!uniqueList.Contains(text))
            {
                Console.WriteLine($"Your input, '{text}', is not in the list.");
            }

            // Assignment Part 5 // 

            // 1. List<string> with two identical string items
            // Then ask user input, then search for the list for a match
            List<string> stringsList = new List<string>()
            {
                "one", "two", "two", "three"
            };

            Console.WriteLine("Enter text input you would like to search in this list: ");
            string userTextInput = Console.ReadLine();

            // 2. This foreach loop iterates through the stringsList,
            // logs to console the indices of items matching the user selected text
            foreach (string item in stringsList)
            {
                // 3. Relay message to user via console if user selected text
                // is not in the list then break loop
                if (!stringsList.Contains(userTextInput))
                {
                    Console.WriteLine($"Your input, '{userTextInput}', does not exist in the list.");
                    break;
                }
                // If the user input matches the current string item in the list
                // It will ouput its index in the stringsList
                // NOTE: the item "two" is doubled in the list.
                if (userTextInput == item)
                {
                    Console.WriteLine($"Match found on index: {stringsList.IndexOf(item)}");
                }
            }

            // Assignment Part 6 //

            // 1. List<string> with four identical string items in it
            List<string> listWithFourIdenticalItems = new List<string>()
            {
                "one", "two", "two", "two", "two", "three"
            };

            // 2. Foreach loop evaluates each item in list
            // displays the string item and whether or not it hsa already appeared in the list
            Console.WriteLine("The following will reveal which string items are duplicates:");
            // Will create another string list to keep track of string items that
            // have already appeared in the list.
            List<string> currentList = new List<string>();

            // Foreach loop
            foreach (string item in listWithFourIdenticalItems)
            {
                // Display one or two messages contingent on the condition
                string message = currentList.Contains(item)
                    ? $"{item} - this item is a duplicate"
                    : $"{item} - this item is unique";
                Console.WriteLine(message);

                // Adds current item to currentList
                currentList.Add(item);
            }
        }
    }
}
