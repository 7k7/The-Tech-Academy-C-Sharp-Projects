# Structs

**Overview**
In C#, `structures` are used to make a variable that holds related data
of different data types. 

---
## 🔹 Structs
They are objects made to store related data with not much behavior defined.
They represent records of data.:

👨‍💻 **Code Example:**
```csharp
// Code eg //
struct <name>
{
    public <type> <varName>;
}

// usage eg //
struct Employee
{
    public int id;
    public string firstName;
    public string lastName;
    public string ssn;
}

// Create an instance of a struct object
Employee emp1;

// Assign values to its properties
emp1.id = 123;
emp1.firstName = "kevin";
emp1.lastname = "Montano";
emp1.ssn = "109-09-9338";
```

📌 **Key Takeaways:**
- It is a class that is a value type
- Cannot inherit from a struct
- cannot be `null`
- Some built-in C# value types, like ints, booleans, enums, and datetime are all structs
- instantiate a struct object like an int or value type.

🔄 **Active Recall Questions:**
1. Is a struct a class?
2. What is it: value or ref type?
3. CAn other calsses inherit from it?
4. Can it be null?
5. Examples of some C# calue types?
6. What is the relationship with value types?
7. How to create an object of type struct in code?

🔗 **Related Hands-On Project:**
- 📂  View Full Implementation in Projects Folder
C:\Users\user\Documents\GitHub\The-Tech-Academy-C-Sharp-Projects\Coding_Journal\Projects\STRUCT ASSIGNMENT\STRUCT ASSIGNMENT\

✅ **Checklist:**
- [ ] I understand the core concept.
- [ ] I have practiced writing C# code related to this topic.
- [ ] I can explain this topic without notes.

---