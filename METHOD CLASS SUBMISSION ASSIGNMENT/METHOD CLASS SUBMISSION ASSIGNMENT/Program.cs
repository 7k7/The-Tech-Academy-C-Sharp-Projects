using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace METHOD_CLASS_SUBMISSION_ASSIGNMENT
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Instance of Caculator
            Calculator calc = new Calculator();

            // Call Calculate() and pass two numbers
            // Specify the parameters by name
            calc.Calculate(num1: 50, num2: 10);
        }
    }
}
