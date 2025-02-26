# Overloading and Chaining Constructors

**Overview**
Constructor is a method that is called to instantiate a class.
Constructors can be overloaded.
---
## 🔹 Overloaded Constructors
They share the same name but different parameters.

👨‍💻 **Code Example:**
```csharp
// This leads to duplicate code! //
public class User
{
    public string username;
    public string location;

    public User(string username)
    {
        this.username = username;
        location = "Online";
    }

    public User(string username, string location)
    {
        this.username = username;
        this.location = location.
    }
}
```

📌 **Key Takeaways:**
- Overloaded constructors share same method name but different parameters
- Useful to allow different ways to instantiate a class
- Problem is it duplicates code as the same code is in both constructors
- Use chaining constructors instead

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
## 🔹 Chaining Constructors
Chaining constructors allows you to overload operators
without duplicating code.

👨‍💻 **Code Example:**
```csharp
// chain constructors //
public class User
{
    public string username;
    public string location;

    public User(string username) : this(username, "Online")
    {

    }

    public User(string username, string location)
    {
        this.username = username;
        this.location = location.
    }
}
```

📌 **Key Takeaways:**
- `: this()` keyword is used to reference another constructor.
- It passes its parameters by reference another constructor that takes them
- No code duplication
- Useful for providing default values for when they are not provided

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
## 🔹 Real-World Use: Chaining Constructors
Purpose: if user doesn't provide a username, 
The constructor provides a username default value
If user does provide username but not location,
the second constructor provide a default parameter value for it

👨‍💻 **Code Example:**
```csharp
public class User
{
    public string username;
    public string location;

    public User() : this("User1")
    {

    }

    public User(string username) : this(username, "Online")
    {

    }

    public User(string username, string location)
    {
        this.username = username;
        this.location = location.
    }
}
```

📌 **Key Takeaways:**
- Chainging constructors provides default values if some values are not provided

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
