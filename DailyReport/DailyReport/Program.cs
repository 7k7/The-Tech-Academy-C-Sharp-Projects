using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DailyReport
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //The start of the program begins with printing this
            Console.WriteLine("The Tech Academy.");

            //Another print to the console
            Console.WriteLine("Student Daily Report.");

            //Display questions then
            //gather user input and assign to their corresponding variables
            Console.WriteLine("What is your name?");
            string name = Console.ReadLine();
            Console.WriteLine("What course are you on?");
            string course = Console.ReadLine();
            Console.WriteLine("What page number?");
            //Cast the string input to an int of 32-bit in size
            int pageNumber = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Do you need help with anything? Please) answer \"true\" or \"false\".");
            //Cast the string input to a boolean 
            bool isHelp = Convert.ToBoolean(Console.ReadLine());
            Console.WriteLine("Were there any positive experiences you'd like to share? Please give specifics.");
            string positiveExperience = Console.ReadLine();
            Console.WriteLine("Is there any other feedback you'd like to provide? Please be specific.");
            string feedback = Console.ReadLine();
            Console.WriteLine("How many hours did you study today?");
            //Chose ushort because it consumes the least amount of memory allocation
            //since only 0 - 24 values are expected.
            //Casting to uInt16 from the string user input
            ushort hoursStudiedToday = Convert.ToUInt16(Console.ReadLine());

            //Final text output before ending the program
            Console.WriteLine("Thank you for your answers. An Instructor will respond to this shortly. Have a great day!");
        }
    }
}
