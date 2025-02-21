# Methods and Parameters in C\#

## Overview

A **method** is a reusable block of code that runs when called. It allows you to break code into smaller, reusable parts and improve readability.

In C#, methods must be declared inside a **class** and can take **parameters** (inputs) and **return values**.

---

## 🔹 Declaring and Calling Methods

A basic method in C#:

👨‍💻 **Code Example:**
```csharp
public class Greeter
{
    // Declaring a method
    public void SayHello()
    {
        Console.WriteLine("Hello, World!");
    }
}

// Calling the method
class Program
{
    static void Main()
    {
        Greeter greeter = new Greeter();
        greeter.SayHello(); // Output: Hello, World!
    }
}
```

📌 **Key Takeaways:**
- `public void SayHello()` → `public` (accessible everywhere), `void` (returns nothing).
- Methods must be inside a **class**.
- You call a method using **an instance** of its class (`greeter.SayHello();`).

🔄 **Active Recall Questions:**
1. What is the difference between a **method** and a **function**?
2. What happens if you don’t specify a **return type** in a method?
3. What is **method overloading**, and why is it useful?
4. What is an **optional parameter**, and how does it work?
5. Can a method have **multiple return values**? If so, how?
---

## 🔹 Methods with Parameters

Methods can **accept input values** (parameters):

👨‍💻 **Code Example:**
```csharp
public class Calculator
{
    // Method with two parameters
    public int Add(int a, int b)
    {
        return a + b;
    }
}

class Program
{
    static void Main()
    {
        Calculator calc = new Calculator();
        int result = calc.Add(5, 3); // result = 8
        Console.WriteLine(result);
    }
}
```

📌 **Key Takeaways:**

- `int Add(int a, int b)` → Takes two `int` values and **returns** their sum.
- `return a + b;` → A method **returns** a value using `return`.

🔄 **Active Recall Questions:**
1. What is the difference between a **method** and a **function**?
2. What happens if you don’t specify a **return type** in a method?
3. What is **method overloading**, and why is it useful?
4. What is an **optional parameter**, and how does it work?
5. Can a method have **multiple return values**? If so, how?
6. small update test
---

## 🔹 Method Overloading (Same Name, Different Parameters)

C# allows **multiple methods with the same name** but different parameters.

👨‍💻 **Code Example:**
```csharp
public class MathOperations
{
    public int Multiply(int a, int b) => a * b;

    public double Multiply(double a, double b) => a * b;
}

class Program
{
    static void Main()
    {
        MathOperations math = new MathOperations();
        Console.WriteLine(math.Multiply(2, 3));    // Calls int version (6)
        Console.WriteLine(math.Multiply(2.5, 3.5)); // Calls double version (8.75)
    }
}
```

📌 **Key Takeaways:**
- Methods with the **same name** but different **parameter types or counts** can exist.
- The correct method is **automatically chosen** based on the arguments.

🔄 **Active Recall Questions:**
1. What is the difference between a **method** and a **function**?
2. What happens if you don’t specify a **return type** in a method?
3. What is **method overloading**, and why is it useful?
4. What is an **optional parameter**, and how does it work?
5. Can a method have **multiple return values**? If so, how?
---

## 🔹 Optional Parameters (Providing Default Values)

You can provide **default values** for parameters:

👨‍💻 **Code Example:**
```csharp
public class Messenger
{
    public void SendMessage(string message = "Hello, Default User!")
    {
        Console.WriteLine(message);
    }
}

class Program
{
    static void Main()
    {
        Messenger messenger = new Messenger();
        messenger.SendMessage(); // Uses default: "Hello, Default User!"
        messenger.SendMessage("Custom Message!"); // Output: "Custom Message!"
    }
}
```

📌 **Key Takeaways:**
- `string message = "Hello, Default User!"` → Default parameter value.
- Calling `SendMessage()` **without arguments** uses the default value.

🔄 **Active Recall Questions:**
1. What is the difference between a **method** and a **function**?
2. What happens if you don’t specify a **return type** in a method?
3. What is **method overloading**, and why is it useful?
4. What is an **optional parameter**, and how does it work?
5. Can a method have **multiple return values**? If so, how?

---

✅ **Checklist:**

✅ **Understanding Methods**

[ ] I can explain what a method is and why it is used.
[ ] I can write a basic method inside a class.
[ ] I understand method parameters and how to use them.
[ ] I know the difference between returning a value and void.

✅ **Method Variations**

[ ] I can create a method with parameters.
[ ] I can implement method overloading.
[ ] I understand how to use optional parameters.

✅ **Practice & Application**

[ ] I have written my own method in a new C# file.
[ ] I have explained methods to someone else or written a short blog post.

---

🔹 **Additional Resources**

📖 **Microsoft Docs:** [Methods (C# Programming Guide)](https://learn.microsoft.com/en-us/dotnet/csharp/programming-guide/classes-and-structs/methods)\
📺 **Video Tutorial:** [C# Methods Explained](https://www.youtube.com/watch?v=ldYcgPKEZC8)

```
```

### **🚀 Why This Format Works**
✅ **Step-by-step approach:** Starts from basics and gradually builds up.  
✅ **Code-focused learning:** Every concept has an example.  
✅ **Active Recall:** Forces you to **think, not just read**.  
✅ **Checklist for Progress:** Tracks what you’ve mastered.  

---

### **📌 Next Steps for You**
1️⃣ **Create `MethodsAndParameters.md`** in your **Concepts** folder.  
2️⃣ **Copy-Paste the above Markdown example.**  
3️⃣ **Start using the checklist & recall questions.**  
4️⃣ **Test the code snippets in Visual Studio.**  
5️⃣ **Try explaining "Methods & Parameters" in your own words.**  
