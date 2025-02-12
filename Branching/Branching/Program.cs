using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Branching
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("What is your fav number?");

            int favNum = Convert.ToInt32(Console.ReadLine());

            string result = favNum == 12 ? "we have same fav num!" : "not cool.";
            Console.WriteLine(result);
            
            //int roomtemperature = 70;

            //Console.WriteLine("Hi, what is your name?");
            //string name = Console.ReadLine();

            //Console.WriteLine("Hi, " + name + ", what is the temp where you are?");
            //int currentTemperature = Convert.ToInt32(Console.ReadLine());

            //if (currentTemperature == roomtemperature)
            //{
            //    Console.WriteLine("It is exactly room temperature");
            //}
            //else if (currentTemperature > roomtemperature)
            //{
            //    Console.WriteLine("it is warmer than room temp.");
            //}
            //else if (roomtemperature > currentTemperature)
            //{
            //    Console.WriteLine("it is colder than room temp");
            //}
            //else
            //{
            //    Console.WriteLine("something went wrong.");
            //}

            //int curTemp = 70;
            //int roomTemp = 70;

            //string comparisonResult = curTemp == roomTemp ? "It is room temp." : "It is not room temp.";

            //Console.WriteLine(comparisonResult);
            //if (curTemp == roomTemp)
            //{
            //    Console.WriteLine("It is room temp.");
            //}
            //else if (curTemp > roomTemp)
            //{
            //    Console.WriteLine("it is warmer than room temp.");
            //}
            //else if (roomTemp > curTemp)
            //{
            //    Console.WriteLine("Room temp is warmer than current temp.");
            //}
            //else
            //{
            //    Console.WriteLine("not rooom temp.");
            //}
        }
    }
}
