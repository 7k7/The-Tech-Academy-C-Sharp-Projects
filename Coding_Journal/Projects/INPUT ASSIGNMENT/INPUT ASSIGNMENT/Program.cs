// Ask user for a number
Console.WriteLine("Hello, please enter a number: ");

// take input and log it to a text file
string input = Console.ReadLine();
File.AppendAllText(@"C:\Users\kevinmontano\log.txt", input);

// print that text file to the user
Console.WriteLine(File.ReadAllText(@"C:\Users\kevinmontano\log.txt"));