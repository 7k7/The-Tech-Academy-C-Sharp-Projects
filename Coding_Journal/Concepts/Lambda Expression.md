# Lambda Expression

**Overview**
A lambda expression is a shorter way to write anonymous methods in C#.
Used when you need small F() without defining a full method.

---
## 🔹 What is a Lambda Expression
A temporary function. Cannot be repeatedly called up with a program.
AKA anonymous functions. Anonymous METHODS are longer, less readble, older style b4 lambdas
Does not have to be define and named like methods.
Used for writing local functions that can be passed as arguments 
or returned as values in function calls.

📌 **Key Takeaways:**
- Lambda expressions are shiort F() without full method definitions.
- A temporary f() cannot be repeatedly called upon with a program
- aka anonymous function
- Does not have to be defined as a method
- Useful for writing local f() that can be passed as arguments
or returned values in function calls.

🔄 **Active Recall Questions:**
1. Can lambda expressions be called upon multiple times?
2. also known as?
3. What makes it differnt from a method?
4. What makes them useful?

🔗 **Related Hands-On Project:**
- 📂  View Full Implementation in Projects Folder

✅ **Checklist:**
- [ ] I understand the core concept.
- [ ] I have practiced writing C# code related to this topic.
- [ ] I can explain this topic without notes.

---
## 🔹 Lambda Expression Syntax
Has input parameters side, lambda operator, then function/expression side

👨‍💻 **Code Example:**
```csharp
// code eg //
(parameters) => expression

// A method //
using System;

class Program
{
    static int Square(int x)
    {
        return x * x;
    }

    static void Main()
    {
        Console.WriteLine(Square(5)); // Output: 25
    }
}

// lambda expression equivalent //
using System;

class Program
{
    static void Main()
    {
        Func<int, int> square = x => x * x; // Lambda Expression
        Console.WriteLine(square(5)); // Output: 25
    }
}

```

📌 **Key Takeaways:**
- What is the lambda syntax?
- lambda expresions are shorter and cleaner than methods
- lambda operator `=>` separates input from expression
- the expression part contains the operation part of the method

🔄 **Active Recall Questions:**
1. What makes them better than methods?
2. What separates input from expression in a lambda expression?
3. What is contained in the expression side?

🔗 **Related Hands-On Project:**
- 📂  View Full Implementation in Projects Folder

✅ **Checklist:**
- [ ] I understand the core concept.
- [ ] I have practiced writing C# code related to this topic.
- [ ] I can explain this topic without notes.

---
## 🔹 Using Lambda with Delegates
A delegate holds a refernce to a method.
There are many types.

📌 **Key Takeaways:**
- A delegate provides a refernce to a method or lambda expression.

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
## 🔹 Using Lambda with `Func<>`
This delegate states input parameter type and return type of a lambda expression. 

👨‍💻 **Code Example:**
```csharp
// Using Lambda with `Func<T, T>`
using System;

class Program
{
    static void Main()
    {
        // first param means parameter type; takes an int
        // Second param means return type of expression; returns an int
        // square is the name of the lambda
        Func<int, int> square = x => x * x;
        Console.WriteLine(square(4)); // Output: 16
    }
}
```

📌 **Key Takeaways:**
- `Func<>` used to state the input and returns types

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
## 🔹 Using Lambda with `Action<>`
Is a delegate that returns `void` and states the type it takes in

👨‍💻 **Code Example:**
```csharp
using System;

class Program
{
    static void Main()
    {
        Action<string> greet = name => Console.WriteLine($"Hello, {name}!");
        greet("Alice"); // Output: Hello, Alice!
    }
}
```

📌 **Key Takeaways:**
- `Action<T>` takes in a type but returns `void`

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
## 🔹 Multi-Line Lambda (Using {})
If your lambda has multiple statements, use `{}` and `return` to exit.

👨‍💻 **Code Example:**
```csharp
using System;

class Program
{
    static void Main()
    {
        Func<int, int> cube = x =>
        {
            int result = x * x * x;
            return result;
        };

        Console.WriteLine(cube(3)); // Output: 37
    }
}
```

📌 **Key Takeaways:**
- Multi-Line Lambdas using `{}` to contain multiple lines of code in the expression body.

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
## 🔹 Lambda with LINQ (Real-World Example)
Lambdas are often used with LINQ.
LINQ stands for Language Integrated Query.
Purpose is to filter and transform collections.

👨‍💻 **Code Example:**
```csharp
using System;
using System.LINQ;

class Program
{
    static void Main()
    {
        int[] numbers = { 1, 2, 3, 4, 5, 6 };

        var evenNumbers = numbers.Where(n => n % 2 == 0); // filters opnly even numbers

        Console.WriteLine(string.Join(", ", evenNumbers)); // Output: 2, 4, 6
    }
}
```

📌 **Key Takeaways:**
- LINQ is used filtering and transforming collections.
- lambda expressions are passed in as arguments with the Where() LINQ method

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
## 🔹 Using Lambda with `Count()`
From the LINQ library.
`Count()` counts a List's items and returns amount as an int type

👨‍💻 **Code Example:**
```csharp
// from TwentyOne project
// Count() is used to count the cards in the list of Cards
// whose Face is Ace then output the amount 
Deck deck = new Deck();
int count = deck.Cards.Count(x => x.Face == Face.Ace);
Console.WriteLine(count);
```

📌 **Key Takeaways:**
- `Count()` outputs the amount of items in a list
- `Count()` can be used in conjunction with a lambda expression
to filter what items in the list to count

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
## 🔹 Using Lambda with `Where()`
part of LINQ library.
`Where()` takes in a lambda expression to filter a list 
and returns it as IEnumerable<T>

👨‍💻 **Code Example:**
```csharp
List<Card> newList = deck.Cards.Where(x => x.Face == Face.King).ToList();
foreach (Card card in newList)
{
    Console.WriteLine(card.Face);
}
```

📌 **Key Takeaways:**
- `Where()` filters a list using a lambda expression
- `Where()` returns a new list as a `IEnumberable<T>` type
- Can cast it to list `ToList()` 

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
## 🔹 LINQ methods that deal with numbers
These methods can get the sum, min, or max of a list

👨‍💻 **Code Example:**
```csharp
List<int> numberList = new List<int>() { 1, 2, 3, 535, 342, 23 };
int sum = numberList.Sum(x => x + 5);
// Add some more logic using lambdas:
// int sum = numberList.Sum(x => x + 5);
int max = numberList.Max();
int min = numberList.Min();
Console.WriteLine(sum);
Console.WriteLine(max);
Console.WriteLine(min);
```

📌 **Key Takeaways:**
- `sum()` returns the total of a int list as type int
- `max()` returns the largest int of list as type int
- `min()` returns the smallest int of a lsit as type int
- Can add more logic using lambdas within each

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
## 🔹 Chain LINQ Methods + Lambdas
You can chain multiple LINQ methods.

👨‍💻 **Code Example:**
```csharp
// Chain LINQ methods
// Filter numbers in list then calculate the sum
List<int> numberList = new List<int>() { 1, 2, 3, 535, 342, 23 };
int sumOfGreaterThen20List = numberList.Where(x => x > 20).Sum();
Console.WriteLine(sumOfGreaterThen20List);
```

📌 **Key Takeaways:**
- Chaining methods means adding them together to get a specific result
- Careful with chaining methods as they can prove difficult to read and debug

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
## 🔹 Best Practices for Lambda Expressions

📌 **Key Takeaways:**
- Use lambda expressoins for short, inline functions
- Use meaningful names for lambda variabls (x, n, item).
- Use `{}` for multi-line lambdas
- Prefer LINQ with lambdas instead of `foreach` loops

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