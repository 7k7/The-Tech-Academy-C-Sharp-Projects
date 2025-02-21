# Interfaces

**Overview**
Interfaces are similar to abstract classes in that there are no implementation defined.
Due to the design of the .NET framework, a class can only inherit 1 abstract class no more.
But .Net does support multple inheritance of interfaces. Interfaces are useful when you want to
Add certain functionality to a an inherited class without changing the abtract class. because that 
small changes would then have to be used for other inheritied classes.
Everything is public in an interface - no need to add the keyword to methods.

---
## 🔹 Creating Interfaces
Contain no implementation like abstract classes.
Classes can inherit multiple interfaces. Each inheriting class must implement
each interface method with same parameters and return type.
Defined with keyword `interface`. They are public by default so no need for `public`
Useful for when you want to add specific functionality to your classes without
changing its base class which would affect every inheriting class.
Use `,` to add multiple interaces to a class
naming convention for interface is always begin name with `I` capital I.
Thats how you can immediately identify interfaces.:

👨‍💻 **Code Example:**
```csharp
// code eg //

// interface
interface IWalkAway

// usage //

// interface
interface IWalkAway
{
    void WalkAway(string player);
}
// this class inherits IWalkAway interface
public class TwentyOneGame : Game, IWalkAway
{
    public override void Play()
    {
        throw new NotImplementedException();
    }
    public override void ListPlayers()
    {
        Console.WriteLine("21 Players:");
        base.ListPlayers();
    }
    // implements interfaces' method
    // use public here but not in the interface itself
    public void WalkAway(string player)
    {
        throw new NotImplementedException();
    }
}
```

📌 **Key Takeaways:**
- No implementation like abstract classes
- Classes can inherit from multiple interfaces but only 1 abstract class.
- Interfaces are defined by `interface` keyword.
- Useful to add specific functionality without changing abstract classes.
- No need to use `public` keyword in interfaces; only in other inheriting classses.
- Always start interface name with a capital I
- Add commas to add multiple interfaces to a class
- All inheriting classes must implement every method exactly.

🔄 **Active Recall Questions:**
1. Do Interfaces include implementation?
2. How many interfaces can a class inherit from?
3. What keyword defines an interface?
4. Why use an interface rather than an abstract class?
5. When is the `pubblic` keyword needed?
6. Naming convention?
7. How to add multiple Interfaces to a classs?
8. Must all methods of an interface be implemented by inherited classes?
9. How is this related to abstraction?
10. How does this support polymorphism?

🔗 **Related Hands-On Project:**
- 📂  View Full Implementation in Projects Folder
C:\Users\user\Documents\GitHub\The-Tech-Academy-C-Sharp-Projects\Coding_Journal\Projects\TwentyOne\TwentyOne\IWalkAway.cs

✅ **Checklist:**
- [ ] I understand the core concept.
- [ ] I have practiced writing C# code related to this topic.
- [ ] I can explain this topic without notes.

---

## 🔹 An Object of an Interface type
An Object can be of an interface type if that Classes object implements it.

👨‍💻 **Code Example:**
```csharp
// Interface
interface IQuittable
{
    // void method
    void Quit();
}
// This class implements an interace
public class Employee : IQuittable
{
    public void Quit()
    {
        Console.WriteLine("Well boss... I quit.");
    }
}

internal class Program
{
    static void Main(string[] args)
    {
        // Instance of type IQuittable
        // IQuittable is type because employee implements it
        IQuittable quitObject = new Employee();

        // call Quit() on the object
        quitObject.Quit();
    }
}
```

📌 **Key Takeaways:**
- Object type can be an interface type if its class implements the interface
- ```<interface type> <ObjectName> = new <Object typw>()```;

🔄 **Active Recall Questions:**
1. Can any object be of an interface type? explain. 
2. How to make an object of an interface type?
3. How is this related to polymorphism?

🔗 **Related Hands-On Project:**
- 📂  View Full Implementation in Projects Folder
C:\Users\user\Documents\GitHub\The-Tech-Academy-C-Sharp-Projects\Coding_Journal\Projects\POLYMORPHISM SUBMISSION ASSIGNMENT\POLYMORPHISM SUBMISSION ASSIGNMENT\

✅ **Checklist:**
- [ ] I understand the core concept.
- [ ] I have practiced writing C# code related to this topic.
- [ ] I can explain this topic without notes.

---