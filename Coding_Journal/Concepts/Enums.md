# Enums

**Overview**
Enum is short for enumeratel; which means to establish the number of something.
It is a data type consisting of a set of named values called elements, members,
enumeral, or enumerators of the type. 
These enumerators are identifiers that behave as constants.
Constant values never change.

🔗 **Related Hands-On Project:**
- 📂  View Full Implementation in Projects Folder
C:\Users\user\Documents\GitHub\The-Tech-Academy-C-Sharp-Projects\Coding_Journal\Projects\PARSING ENUMS SUBMISSION ASSIGNMENT\PARSING ENUMS SUBMISSION ASSIGNMENT\

---
## 🔹 Enum Syntax
enum is a special class that represents a group of constants.
Playing cards suits are the enumarated type 
and the types of suits are the enumerators.:

👨‍💻 **Code Example:**
```csharp
// eg //
enum Color
{
    Red,
    Blue,
    White
}

// usage //
// create an enum of the days of the week
public enum DaysOfTheWeek
{
    Monday,
    Tuesday,
    Wednesday, 
    Thursday,
    Friday,
    Saturday,
    Sunday
}
// use in program
public Program 
{
    public static void Main(string[] args)
    {
        // Instantiating an enum
        DaysOfTheWeek day = DaysOfTheWeek.Monday;
    }
}

```

📌 **Key Takeaways:**
- Defined by the `enum` keyword
- The name of the enum class is also used as the data type
- Created similar to a class
- Create an enum as its own class unless it is related to another class.
- Enums are a group of constants
- Enumertors are are constant values
- A data that is of type enum is one of a group of constants (an enum)
- Enums limit the possible values you can receive from a user.
- It protects program from user input errors

🔄 **Active Recall Questions:**
1. What keyword defines an enum?
2. What defines the type of an enum?
3. They are similar as creating what?
4. General best practice for creating enums.
5. What is an enum?
6. What makes up an ennum and what are they?
7. What makes enums useful for your progranm? When to use them?

🔗 **Related Hands-On Project:**
- 📂  View Full Implementation in Projects Folder

✅ **Checklist:**
- [ ] I understand the core concept.
- [ ] I have practiced writing C# code related to this topic.
- [ ] I can explain this topic without notes.

---

## 🔹 Casting the underlying value of an Enumerator
Can directly cast an enumerator to int to get its underlying value (int)

👨‍💻 **Code Example:**
```csharp
// code eg //
int value = (int)<enumName>.<enumerator>;
```

📌 **Key Takeaways:**
- Each enumerator are a asssigned an underlying value of type int using a zero-based
  index system.
- Can assign each enumerator a specific underlying value of type int

🔄 **Active Recall Questions:**
1. What are underlying values?
2. Can enumerators be assigned values? if so, what type?

🔗 **Related Hands-On Project:**
- 📂  View Full Implementation in Projects Folder
C:\Users\user\Documents\GitHub\The-Tech-Academy-C-Sharp-Projects\Coding_Journal\Projects\TwentyOne\TwentyOne\Deck.cs

✅ **Checklist:**
- [ ] I understand the core concept.
- [ ] I have practiced writing C# code related to this topic.
- [ ] I can explain this topic without notes.

---