using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace STRUCT_ASSIGNMENT
{
    public class Program
    {
        static void Main(string[] args)
        {
            // Declare a number of type struct
            Number number;

            // assign a value to its property Amount
            number.Amount = 1.00m;

            // print, must convert to string to print
            Console.WriteLine(number.ToString());
        }
    }
}
