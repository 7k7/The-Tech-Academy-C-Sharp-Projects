# Data Types

**Overview**
A data type is a classification that tells the compiler:
1. What kind of data a variable can store 'string name'
2. How much memory it needs.
3. How it is stored in memory
4. How it behaves when assigned to another variable.

All data types are categorized into
1. Value types -> store actual values in the stack.
2. Refernce types -> store memory references in the heap.

---
## 🔹 Value Data Type
Value types store data directly in memory.
So when you assign the value of another variable, a copy of that value is made for it.
Both variable and actual data are stored directly in the stack.
They are faster than reference types because they are stored in the stack:

👨‍💻 **Code Example:**
```csharp
// code eg //
using System;

class Program
{
    static void Main()
    {
        int a = 10;  // Value stored in 'a'
        int b = a;   // 'b' gets a COPY of 'a'

        Console.WriteLine($"Before changing b: a = {a}, b = {b}");

        b = 20;  // Changing 'b' does NOT affect 'a'

        Console.WriteLine($"After changing b: a = {a}, b = {b}");
    }
}

// output
Before changing b: a = 10, b = 10
After changing b: a = 10, b = 20

```

📌 **Key Takeaways:**
- Value types store data both var and data on the stack memory
- Assigning the value of a value type var into another var, creates a copy of it just for that var
- value types cannot be `null` like references types can. non-nullable data type
- faster and more efficient than ref types because they are stored in the stack.

🔄 **Active Recall Questions:**
1. How does value types store data to memory?
2. What behavior occurs when assigning the same value of one var to another?
3. What makes them more fast and efficient than reference types?

🔗 **Related Hands-On Project:**
- 📂  View Full Implementation in Projects Folder

✅ **Checklist:**
- [ ] I understand the core concept.
- [ ] I have practiced writing C# code related to this topic.
- [ ] I can explain this topic without notes.

---

## 🔹 Reference Types
Reference types store memory address(refernce), the variable itself, in the stack.
The actual object data is stored in the heap.
So by assigning the reference type of a var to another, it just passes the address.
Heap is slower but more flexible than stack memory:

👨‍💻 **Code Example:**
```csharp

// code eg //
using System;

class Person
{
    public string Name;
}

class Program
{
    static void Main()
    {
        Person person1 = new Person(); // Creates an object in heap
        person1.Name = "Alice";

        Person person2 = person1; // 'person2' now points to the SAME memory as 'person1'

        Console.WriteLine($"Before changing person2: person1.Name = {person1.Name}, person2.Name = {person2.Name}");

        person2.Name = "Bob"; // Changing 'person2' also changes 'person1'

        Console.WriteLine($"After changing person2: person1.Name = {person1.Name}, person2.Name = {person2.Name}");
    }
}

// outp[ut

Before changing person2: person1.Name = Alice, person2.Name = Alice
After changing person2: person1.Name = Bob, person2.Name = Bob

```

📌 **Key Takeaways:**
- Refernce data types store the variable as a memory address in the stack.
- the memory address points to the actual object which is stored in the heap.
- Assigning a reference value of one var to another just copies the same reference
- They are slower but more fleicble than value types
- Basically, all c# classes.

🔄 **Active Recall Questions:**
1. How is data stored in reference types?
2. what is a memory address?
3. what happens when the value of one var is assigned to another?
4. How efficient are they in terms of memory?
4. are all C# classes ref types?

🔗 **Related Hands-On Project:**
- 📂  View Full Implementation in Projects Folder

✅ **Checklist:**
- [ ] I understand the core concept.
- [ ] I have practiced writing C# code related to this topic.
- [ ] I can explain this topic without notes.

---

## 🔹 String data type
String data type is a reference type though it behaves like a value type
becasuse strings are immutable.
because when changing or assigning the string value of a var to another, 
it creates a new string value:

👨‍💻 **Code Example:**
```csharp
string str1 = "Hello";
string str2 = str1;

Console.WriteLine($"Before changing str2: str1 = {str1}, str2 = {str2}");

str2 = "World"; // This creates a NEW string in memory

Console.WriteLine($"After changing str2: str1 = {str1}, str2 = {str2}");
// output
Before changing str2: str1 = Hello, str2 = Hello
After changing str2: str1 = Hello, str2 = World

```

📌 **Key Takeaways:**
- String data types store data like reference types
- But since they are immutable, each reassignment creates a new string value in the heap

🔄 **Active Recall Questions:**
1. What type is a string data type?
2. What makes them unique?
3. What happens when its value is assigned to another variable?
2. What does the string builder class compare to the string data type?

🔗 **Related Hands-On Project:**
- 📂  View Full Implementation in Projects Folder

✅ **Checklist:**
- [ ] I understand the core concept.
- [ ] I have practiced writing C# code related to this topic.
- [ ] I can explain this topic without notes.

---