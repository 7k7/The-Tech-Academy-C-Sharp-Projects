# Generics

**Overview**
The words' definition is "belonging to a group of things but not specific".
It is a feature in C# to create generic classes or functions.
The more generic you can design your classes and functions, the more reusability it has.

---
## 🔹 Generic Classes and Methods
List class is a generic class. 
List<T> `T` represents the data type passed in upon object creation. 
Usable for any kind of data type.:

👨‍💻 **Code Example:**
```csharp
// Code eg //
// The list class
List<T>

// usage //

// genric class
public class Player<T> 
{
    // genenric method
  public List<T> Hand { get; set; }
}

public Program
{
    static void Main(string[] args)
    {
        Player<Card> player = new Player<Card>();
        player.Hand = new List<Card>();
    }
}
```

📌 **Key Takeaways:**
- A Generic class takes any data type and is passed throughout all its methods
- It is define by `<T>`, which means whatever data type this ibject is instantiated with
- Rememember to instantiate a List<> property of a class before using it.
- You can build a program which compiles it then running it, just to see if it has no errors.
- This allows this code to be reused and adapatble as you futher enhance your program

🔄 **Active Recall Questions:**
1. What type of data type does a genric class take?
2. How to define a generic class and method?
3. Are you List<> properties instantiated before calling them?
4. How to avoid running a program but just compile it and check for errors?
5. How do generic classes improve your code abstraction aspect?

🔗 **Related Hands-On Project:**
- 📂  View Full Implementation in Projects Folder
C:\Users\user\Documents\GitHub\The-Tech-Academy-C-Sharp-Projects\Coding_Journal\Projects\Parameters Assignment\Parameters Assignment\

✅ **Checklist:**
- [ ] I understand the core concept.
- [ ] I have practiced writing C# code related to this topic.
- [ ] I can explain this topic without notes.

---