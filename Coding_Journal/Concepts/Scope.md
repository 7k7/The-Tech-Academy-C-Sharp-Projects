# Scope

**Overview**
Scope is the access to functions, variables, and objects.

---
## 🔹 Types of Variables Scope
Vars have scope which can limited.
Four main types of scope in C#
1. Local scope = vars declared inside a method or block ({})
2. Class-level (Field) Scope = vars declared inside a class but outside methods
3. Static Scope = vars declared as static, shared accorss all instances
4. Global Scope = C# doesn't have true global vars but can use `static` vars
to achvieve similar behavior.

📌 **Key Takeaways:**
- Scope defines where a variable can be accessed in your code.
- Scope determines which parts of a program can see or modify a variable.

🔄 **Active Recall Questions:**
1. What does scope define regarding variables in your code?
2. What does "scope determines access" mean?

🔗 **Related Hands-On Project:**
- 📂  View Full Implementation in Projects Folder

✅ **Checklist:**
- [ ] I understand the core concept.
- [ ] I have practiced writing C# code related to this topic.
- [ ] I can explain this topic without notes.

---
## 🔹 Local Scope
It is declared inside a method or block of code.
Only existing inside that method or block
Which means it cannot be accessed outside the method.

👨‍💻 **Code Example:**
```csharp
Using System;

class Program
{
    static void Main()
    {
        int x = 10; // local var inside Main()
        Console.WriteLine(x); // Accessible here inside Main()
    }

    // Console.WriteLine(x); would cause error
}
```

📌 **Key Takeaways:**
- vars declared inside methods or block can only be access within it
- Destoryed after methods finishes execution; memory efficient!
- Best practice: Keep vars as local as possible to avoid unintended modifications

🔄 **Active Recall Questions:**
1. How to declare a local var?
2. Where can it be accessed?
3. How do they relate to memory efficiency?
4. Why is it a best practice to keep vars local as possible?

🔗 **Related Hands-On Project:**
- 📂  View Full Implementation in Projects Folder

✅ **Checklist:**
- [ ] I understand the core concept.
- [ ] I have practiced writing C# code related to this topic.
- [ ] I can explain this topic without notes.

---
## 🔹 Class-level (Field) Scope
Vars declared inside a class but outside methods are called `fields`
Accessible by all methods inside that class
Persists in memory as long as the object exists

👨‍💻 **Code Example:**
```csharp
using System;

class Car
{
    private string brand = "Toyota"; // class-level var

    public void ShowBrand()
    {
        Console.WriteLine($"Car brand: {brand}"); // accessible inside method of this class
    }
}

class Program
{
    static void Main()
    {
        Car myCar = new Car();
        myCar.ShowBrand();
    }
}
```

📌 **Key Takeaways:**
- Declared inside of a class but outside its methods; fields.
- Accessible by all methods inside the same class
- Exists as long as the object exists
- Best practice: Use `private` fields to prevent accidental mods from outside its class

🔄 **Active Recall Questions:**
1. What makes a var have a class-level var scope?
2. What is the scope accessibility?
3. What determines its existence in memory?
4. How to prevent fields from being accessed and modified from out the class?

🔗 **Related Hands-On Project:**
- 📂  View Full Implementation in Projects Folder

✅ **Checklist:**
- [ ] I understand the core concept.
- [ ] I have practiced writing C# code related to this topic.
- [ ] I can explain this topic without notes.

---
## 🔹 Static Scope (Shared Variables)
a `static` var belongs to the class, not to the instance of it
All objects of the class share the same static var
Exists as long as the program runs

👨‍💻 **Code Example:**
```csharp
using System;

class Counter
{
    private static int count = 0 // private static var shared accross all instances

    public static int Count // public read-only property but also shared accross all instances
    {
        get { return count; } // getter for read-only accessiblity 
    }
    public Counter() //Constructor method
    {
        Count++; // INcrements for every new object
    }
}

class Program
{
    static void Main()
    {
        Counter c1 = new Counter();
        Counter c2 = new Counter();

        Console.WriteLine($"Total objects created: {Counter.Count}"); // output: 2
    }
}
```

📌 **Key Takeaways:**
- `static` vars belong to its class not the instances of it
- Accessible and shared by all instances of the same class
- Exists in memory while the program is running
- `public` keyword makes a static or field var accessible from outisde the class
- `private` keyword makes it only accessible inside the class
- Best practice: Use `private` for `static` and field vars and expose it
with a private getter to prevents mods to that field
- Best practice: Always access static vars using the class name
because static vars belong to class; accessing them through instances is misleading.

🔄 **Active Recall Questions:**
1. What does `static` field mean?
2. Accessbility?
3. How longs does it stay in memory?
4. define `public` keyword on a var?
5. What does `private` do?
6. What best practice controls access to a static field?
7. What best practice regarding accessing vars from a classs or instance?

🔗 **Related Hands-On Project:**
- 📂  View Full Implementation in Projects Folder

✅ **Checklist:**
- [ ] I understand the core concept.
- [ ] I have practiced writing C# code related to this topic.
- [ ] I can explain this topic without notes.

---
## 🔹 Global-like Scope using `Static` Class
C# does not have true global scope
`static` vars inside a `static` class simulate a global variable
Exists as long as program is running

👨‍💻 **Code Example:**
```csharp
using System;
{
    static class GlobalData
    {
        public static int SharedValue = 100;
    }
}

class Program
{
    static void Main()
    {
        Console.WriteLine($"Global Value: {GlobalData.SharedValue}"); // Accessible everywhere
    }
}
```

📌 **Key Takeaways:**
- C# avoids global variables to improve encapsulation
- `static` classes with `public static` creates global variables
- Best practice: Keep global-like vars to a minimum to avoid unintended side effects
- Exists as long as program runs

🔄 **Active Recall Questions:**
1. Why does C# avoid global variables?
2. How to simulate global-like vars?
3. Whats a best practice regarding global-like vars?
4. For how long does it exist?

🔗 **Related Hands-On Project:**
- 📂  View Full Implementation in Projects Folder

✅ **Checklist:**
- [ ] I understand the core concept.
- [ ] I have practiced writing C# code related to this topic.
- [ ] I can explain this topic without notes.

---
## 🔹 Best Practice for Variable Scope

📌 **Key Takeaways:**
- Use the smallest possible scope
    - Declare vars inside methods instead of class-level fields when possible
- Use `private` fields in a class
    - Keep class-level fields private and expose them with properties
- Avoid `static` for shared state unless necessary
    - `static` vars can lead to unexpected side effects if modified by multiple instances
- Limit global-like vars
    - Too many global vars makes debuggining harder

🔄 **Active Recall Questions:**
1. What should you aim for in terms of scoping vars?
2. How to best limit scope of fields?
3. What issues are associated `static` fields?
4. What do global-like vars complicate? 

🔗 **Related Hands-On Project:**
- 📂  View Full Implementation in Projects Folder

✅ **Checklist:**
- [ ] I understand the core concept.
- [ ] I have practiced writing C# code related to this topic.
- [ ] I can explain this topic without notes.

---