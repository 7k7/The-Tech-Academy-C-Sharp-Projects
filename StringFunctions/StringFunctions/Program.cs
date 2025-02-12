using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringFunctions
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Escape sequences inside of strings
            string name = "Jesse";
            string fileName = "C:\\Users\\Jesse";
            //can use the @ sign to denote that all is patr of string value
            // no escape sequescns 
            string fileNameAtSign = @"C:\Users\Jesse";
            string quote = "The man said\\, \"Hello World!\", Jesse. \n Hello nw line. \n \t new tab.";

            Console.WriteLine(quote + "\n" + fileName + "\n" + fileNameAtSign);

            // call functions on string var with a string value
            // these funciotns useful to parse files and look for a character or letter
            bool trueOrFalse = name.Contains("s");
            // reassign variable
            trueOrFalse = name.EndsWith("s");
            Console.WriteLine(trueOrFalse);

            // sting length
            int length = name.Length;

            Console.WriteLine(length);

            // Upper caes
            name = name.ToUpper();
            Console.WriteLine(name);

            //all lower case
            name = name.ToLower();
            Console.WriteLine(name);

            // String vars are immutable
            // Means once created, string is allocated to memory
            // once var value is changed, it just generates a new 
            // string and allocates it to memory
            // For small programs, it is not that important
            string userName = "Jesse";
            userName = "Joe"; // var is ressigned

            Console.WriteLine(userName);

            // It will affect you when changing more that a couple of times
            // Like continually add more data to the string var over and over
            // you are not adding but creating a new string each time
            // program slows down
            // String builder is a C# class is the solution
            // It is a dynamic object=it is expandable or shrink wihout performance loss
            // Example:
            StringBuilder sb = new StringBuilder();

            sb.Append("My name is Jesse");

            Console.WriteLine(sb);

            Console.ReadLine();
        }
    }
}
