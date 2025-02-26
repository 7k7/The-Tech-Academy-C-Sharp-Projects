# Namespaces

**Overview**
Organized related code in containers. 
To avoid naming conflicts.

---
## 🔹 Declare a Namspace
a namespace is a container of related classes, interfaces, and functions.
It organizes code and avoid naming conflicts.

👨‍💻 **Code Example:**
```csharp
namespace MyApp.Utilities
{
    class Helper
    {
        public static void SayHello()
        {
            Console.WriteLine("Hello from Helper class!");
        }
    }
}
```

📌 **Key Takeaways:**
- Organize related code in containers
- Avoids naming conflicts
- keyword `namespace <name>` declares a namespace 

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
## 🔹 Import a Namespace
`Using` keyword allows us to use class outside our current namespace.

👨‍💻 **Code Example:**
```csharp
using MyApp.Utilities; // Import the namespace

class Program
{
    static void Main()
    {
        Helper.SayHello(); // Call the method
    }
}
```

📌 **Key Takeaways:**
- `using` allows code in one namespace to access other code in another namespace

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
## 🔹 Fully Qualified Namespace without `using`
Can access a class of different namespace
If you declare full path of that namspace

👨‍💻 **Code Example:**
```csharp
class Program
{
    static void Main()
    {
        MyApp.Utilities.Helper.SayHello(); // Fully qualified name
    }
}
```

📌 **Key Takeaways:**
- Use full namespace of a method or class to access it
- No need for `using`
- Good for avoiding confusion if classes are named alike in both namespaces

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
## 🔹 Nested Namespaces
Use sub namespaces to organize your code.

👨‍💻 **Code Example:**
```csharp
namespace Company
{
    namespace Sales
    {
        class Report
        {
            public static void Show()
            {
                Console.WriteLine("Sales Report");
            }
        }
    }
}
```

📌 **Key Takeaways:**
- Create nested namespaces to store code
- Better organization of code;
- same-name classes cannot be used in a single namespace

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