# File I/O

**Overview**
Read from files and write to files. Useful for:
storing data, logging, configuration files, reports, and more.

---
## 🔹 File I/O definition
File input = Reading data from a file
File output = Writing data to a file
Uses System.IO namespace:

👨‍💻 **Code Example:**
```csharp
using System;
using System.IO; // required for file I/O
```

📌 **Key Takeaways:**
- File I/O has to do with reading data from a file and writing data to a file
- Requires the namespace `System.IO`    

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
## 🔹 Writing to a File
Using `File.WriteAllText()` = creates file if not exist or overrites it even it exist

👨‍💻 **Code Example:**
```csharp
using System;
using System.IO;

class Program
{
    static void Main()
    {
        string filePath = "example.txt";
        string content = "Hello, this is a test file.";

        // Write content to file (overwrites if file exists)
        File.WriteAllText(filePath, content);

        Console.WriteLine("File written successfully.");
    }
}
```

📌 **Key Takeaways:**
- `File.WriteAllText` creates the file with data
- Overites existing files with matching name

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
## 🔹 Appending to a File
`File.AppendAllText()` appends data without erasing existing content

👨‍💻 **Code Example:**
```csharp
string filePath = "example.txt";
string newContent = "\nAppending this text.";

File.AppendAllText(filePath, newContent);

Console.WriteLine("Text appended successfully.");
```

📌 **Key Takeaways:**
- Only appends data to the file, does not overrite exisiting data

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
## 🔹 Logging to Files
Logging means putting an entry to a file or database regarding program actions.
Like errors or method calls.

👨‍💻 **Code Example:**
```csharp
// Write some text to a file
string text = "Here is some text.";// data
// use @ to not use escape character for the backslashes
File.WriteAllText(@"C:\Users\kevinmontano\log.txt", text); // text file with path and data to insert
// folder must exist. This won't create the folder if it doesn't exist.

// This reads that text file we created
string text = File.ReadAllText(@"C:\Users\kevinmontano\log.txt");

// appending method to a file for logging
public class Dealer
{
    public string Name { get; set; }
    public Deck Deck { get; set; }
    public int Balance { get; set; }

    public void Deal(List<Card> Hand)
    {
        Hand.Add(Deck.Cards.First());
        // store card dealt 
        string card = string.Format(Deck.Cards.First().ToString() + "\n");
        Console.WriteLine(card);
        // logging to file each card being dealt in game
        // This appends to the file
        // `using` makes sure memory is freed up after it is done
        using (StreamWriter file = new StreamWriter(@"C:\Users\kevinmontano\log.txt", true))
        {
            file.WriteLine(card);
        }
        Deck.Cards.RemoveAt(0);
    }
}
```

📌 **Key Takeaways:**
- Logging means appending a message to the end of a file
- `File.ReadAllText()` extract the text of a file; specify path
- `StreamWriter` class used for writing multiple lines or large files
- `using` statement automatically closes the file after writing; frees up resources
- Use `@` so you don't have to apply escape characters for the backslahes

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