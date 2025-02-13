using System;
using System.Collections.Generic;


class Program
{
    static void Main()
    {
        // Arrays 
        // hold a group of variables
        // Must define data type the array will hold
        // integer array called numArray
        // Must instantiate array 
        // Must put in the amount of vars it will hold
        //int[] numArray = new int[5];

        //// Add items to it
        //// It is zero-based index, meaning it starts with 0 
        //// and counts it as '1'
        //numArray[0] = 5;
        //numArray[1] = 2;
        //numArray[2] = 10;
        //numArray[3] = 200;
        //numArray[4] = 5000;

        //// easier way to put nums in array
        //// cleaner, easier to read and write
        //// can add as many items as needed
        //// once lenfth is set, it cannot be increased.
        //int[] numArray1 = new int[] { 5, 2, 10, 200, 5000, 600, 2300 };
        //Console.WriteLine(numArray1[3]); // shoudl be 200

        //// faster way:
        //int[] numArray2 = { 5, 2, 10, 200, 5000, 600, 2300 };

        //// change value but can't change size of array
        //numArray2[5] = 650;
        //// output only one array item
        //Console.WriteLine(numArray2[3]); // 200
        //Console.WriteLine(numArray2[5]); // 650



        // Lists
        // much more adaptable than arrays
        // It is called generic because a List can hold any data type like array
        // It is from System.Collections.Generic library
        List<int> intList = new List<int>();
        // Add to List
        intList.Add(4);
        intList.Add(10);
        // Remove a specified value
        intList.Remove(10); 

        Console.WriteLine(intList[0]);

        // String List
        List<string> stringList = new List<string>();
        stringList.Add("Helo");
        stringList.Add("Kevin");
        stringList.Remove("Kevin");

        Console.WriteLine(stringList[0]);

        // Use array when you have a fixed quantity to group that won't change
        // Or when storing a very large quantity 
        // FOr anything else, ues list. 
        Console.ReadLine();
    }
}
