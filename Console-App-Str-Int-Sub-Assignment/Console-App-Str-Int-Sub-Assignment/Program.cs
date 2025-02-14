using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Console_App_Str_Int_Sub_Assignment
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // 1. Divide user input # by a list of integers then log result to console

            // List<int>
            List<int> intList = new List<int>()
            {
                1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12,
            };

            // Try/Catch/Finally blocks
            // For exception handling
            try
            {
                // Log for entering the try block
                Console.WriteLine("The program has now begun executing code in the try block.");

                // Ask user for a number to divide each number in the list by
                Console.WriteLine("Please enter a number to divide by:");
                int userNum = Convert.ToInt32(Console.ReadLine());

                // foreach loop iterates through the intList
                // dividing each number by the userNum
                // then logs the result to console
                foreach (int item in intList)
                {
                    Console.WriteLine($"{item} divided by {userNum} = {item / userNum}");
                }

                // Try block has been successful message
                Console.WriteLine("The program has emerged from he try/catch block successfully!");

            } // This catches invalid input format
            catch (FormatException ex)
            {
                Console.WriteLine("Please enter a whole number.");
                return; 
            } // This catches zeros from user input
            catch (DivideByZeroException ex)
            {
                Console.WriteLine("Cannot divide by zero");
                return;
            } // This catches any other exception and handles it by outputing the message
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return;
            } // Whether exception or none, this block will help keep the console open
            finally
            {
                Console.ReadLine();
            }


        }
    }
}
