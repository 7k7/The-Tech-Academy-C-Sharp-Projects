# Exception

**Overview**
An event that occurs during the execution of a program
tha disrupts the normal flow

---
## 🔹 Exception Handling with try catch blocks
Done using try catch blocks or if statements
Start with specific exceptions to general exceptions

👨‍💻 **Code Example:**
```csharp
// From TwentyOne Program.cs
try
{
    game.Play();
}
catch (ArgumentException)
{
    Console.WriteLine("Something you entered was incorrect.");
    Console.ReadLine();
    return;
}
catch (Exception)
{
    Console.WriteLine("An error occurred. Please contact your System Administrator.");
    Console.ReadLine();
    return;
}
```

📌 **Key Takeaways:**
- Exception handling allows a program to catch and handle an exception without breaking program
- `try` block contains the code to catch exceptions from
- `catch` block or blocks are the exception handling code

🔄 **Active Recall Questions:**
1. What are the important questions to ask about this topic?
2. How does this topic relate to others?

🔗 **Related Hands-On Project:**
- 📂  View Full Implementation in Projects Folder
C:\Users\kevinmontano\GitHub\The-Tech-Academy-C-Sharp-Projects\Coding_Journal\Projects\Try Catch Assignment\Try Catch Assignment\

✅ **Checklist:**
- [ ] I understand the core concept.
- [ ] I have practiced writing C# code related to this topic.
- [ ] I can explain this topic without notes.

---
## 🔹 Manually throw exceptions using if statements
Manually throw exceptions to catch any invalid logic.
It is usually because there is no formal specifc exception for it.

👨‍💻 **Code Example:**
```csharp
 class Program
    {
        static void Main(string[] args)
        {
            // Prompt user for their age
            Console.WriteLine("Hi, please enter your age:");

            // To make age accessible outside try block
            int age = 0;

            // Catch any exceptions from user input
            try
            {
                string userInput = Console.ReadLine(); // user input
                age = int.Parse(userInput); // attempt to parse input

                // Check for a negative age
                if (age <= 0)
                {
                    // Manually throw an exception
                    throw new ArgumentException("Age must be greater than zero.");
                }
                // output age
                Console.WriteLine($"You entered: {age}");

                // display the year the user was born
                DateTime dateTimeBorn = DateTime.Now.AddYears(-age);
                Console.WriteLine($"The year you were born: {dateTimeBorn.Year}");
            }
            catch (FormatException e) // Catch invalid formatted numbers
            {
                Console.WriteLine($"Error: Must enter a number.");
            }
            catch (ArgumentException e) // Catch the manually thrown exception
            {
                Console.WriteLine($"Error: {e.Message}");
            }
            catch (Exception e) // for any errors
            {
                Console.WriteLine("An error ocurred: "+ e.Message);
            }
            finally
            {
                Console.WriteLine("Execution is complete.");
            }
        }
    }
```

📌 **Key Takeaways:**
- Manually throw exceptions for invalid logic
- Use if statements to check for edge cases

🔄 **Active Recall Questions:**
1. What are the important questions to ask about this topic?
2. How does this topic relate to others?

🔗 **Related Hands-On Project:**
- 📂  View Full Implementation in Projects Folder

✅ **Checklist:**
- [ ] I understand the core concept.
- [ ] I have practiced writing C# code related to this topic.
- [ ] I can explain this topic without notes.

---