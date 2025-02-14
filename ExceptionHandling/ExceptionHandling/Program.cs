using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExceptionHandling
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("Pick a number.");
                int numberOne = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Pick a second number.");
                int numberTwo = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("Dividing the two...");
                int numberThree = numberOne / numberTwo;
                Console.WriteLine(numberOne + " divided by " + numberTwo + " equals " + numberThree);

                Console.ReadLine();
            }
            catch (FormatException ex) // ex is var name of FormatException
            {
                // ex.Message is the default exception message 
                //Console.WriteLine(ex.Message);
                // Custom message
                Console.WriteLine("Please type a whole number.");
                return; // exit to previous out of program
            }
            catch (DivideByZeroException ex)// though not used here, its useful for logs 
            {
                Console.WriteLine("Please don't divide by zero.");
            }
            catch (Exception ex) // General exception for any other error
            {
                Console.WriteLine(ex.Message);// This ex.Message is great because it will 
                // print whatever the error is.
            }
            finally // will run even if try block has no exceptions
            { // This finally block is usually used for a database log
                // logging that something happened or an exception
                Console.ReadLine();
            }
            }
            
    }
}
