using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VariablesAndDataTypes
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // This is a simple program
            //Console.WriteLine("What is your name?");
            //string yourName = Console.ReadLine();
            //Console.WriteLine("Your name is: " + yourName);
            //Console.ReadLine();

            //Console.WriteLine("What is your favorite number?");
            //string favoriteNumber = Console.ReadLine();
            //Console.WriteLine("Your favorite number is: " + favoriteNumber);
            //Console.ReadLine();

            //Console.WriteLine("What is your favorite number?");
            //string favNumber = Console.ReadLine(); //ReadLine() only accepts String data type
            //int favNum = Convert.ToInt32(favNumber);
            //int total = favNum + 5;
            //Console.WriteLine("Your favorite number plus 5 is: " + total);
            //Console.ReadLine();

            bool isStudying = true; // True or False boolean values

            byte hoursWorked = 42; //small number 0 - 255
            sbyte currentTemperature = -23; //negative numbers

            //char is one unicode character which takes up 16-bit of memory
            char randomLetter = 'A';
            char questionMark = '\u2103';

            Console.WriteLine(questionMark);
            Console.ReadLine();

            decimal moneyInBank = 100.5m;// huge decimal for money for fianncial trans
            double heightInCentimeters = 190.0090;//deciamls up to 15 or 16 digits
            float secondsLeft = 2.62f;//up 7 digits decimal

            //smaller than int
            short temperatureOnMars = -431;

            string myName = "Kevin";//text

            //Castings
            int currentAge = 30;
            string yearsOld = currentAge.ToString();

            bool isRaining = true;
            string rainingStatus = Convert.ToString(isRaining);
            Console.WriteLine(rainingStatus);
            Console.ReadLine();
        }
    }
}