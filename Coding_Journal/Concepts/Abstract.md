# Abstract

**Overview**
The word abstract refers to thoughts or ideas as opposed to concrete facts.
Abstract data means the output of that data and not the implementation aspect.
Example: We might not know how a car's brake system work. We just know that if the brake pedal is pressed down, the car will begin to brake. 
Using the above example, abstract is important because different cars could have different methods of accomplishing the same expected bahvior; braking. 
This example is a demonstartion of "abstracting out" the implementation, so only what something does is know and not how it is done.

---
## 🔹 Abstract Class
A class marked with a keyword 'Abstract'
Can never be instantiated or an object. Only meant to be inherited from.
Example:
Like class game. It is a base (abstract) class for other specific game classes.

a generic class or type of object used as a template for creating other objects that conform with its 
specifications.
Classes that derived from abstract classes are called inherited or derived classes.
Through inheritance, classes can derive specifc implemention of abstract classes
When inheritance is performed many times, the resuilt is a hierarchy of classes. 
The abstract class being the roof of the hierarchy:

👨‍💻 **Code Example:**
```csharp
public abstract class Game
{
    // Inherency example //
    // Programming practice: design towards abstraction
    // The more generic your code is, the more features you can add later
    // To resuse this class with another type of game
    // Build this game with properties and behaviors that all games
    // have in common

    // Like players
    public List<string> Players { get; set; }

    // Game name
    public string Name { get; set; }

    // dealer
    public string Dealer { get; set; }

    // A method that prints a list of players
    public void ListPlayers()
    {
        foreach (string player in Players)
        {
            Console.WriteLine(player);
        }
    }
}
```

📌 **Key Takeaways:**
- Abstract class is a generic class meaning it is used to share its properties and behaviors with 
multiple other classes
- Inherited or derived classes are created from abstract classes.
- Abstract classes are the root of a hierarcy of inherited classes
- This relates to polymorphism, same thing but in multiple different forms, because
an abstract class can be used as the basis for other classes but each inhertied class can 
specify its own specific implementation data

🔄 **Active Recall Questions:**
1. What makes an Abstrct class different from other?
2. What makes an inherited class
3. Why use or create an abstract class?
4. What type of class is the root class in a hierarchy of inhertied classes?
5. How is this related to polymorphism?
6. How is inheritance applied when using abstract classed to create other classes?

🔗 **Related Hands-On Project:**
- 📂  View Full Implementation in Projects Folder
C:\Users\user\Documents\GitHub\The-Tech-Academy-C-Sharp-Projects\Coding_Journal\Projects\TwentyOne\TwentyOne.sln

✅ **Checklist:**
- [ ] I understand the core concept.
- [ ] I have practiced writing C# code related to this topic.
- [ ] I can explain this topic without notes.

---

---
## 🔹 Abstract Methods in Abstract Classes
Classes derived from abstract classes will inherit its methods.
Marked with the abstract keyword. They only exist inside an abstract class.
The abstract method does not specify implementation, then it won't be abstract,
but does define the general purpose of it.
This allows each inherited class to define their own implementation of the abstract method.
It is mandatory that every class inheriting from this class must implement and define the
abstract methods.
The `override` keyword allows no implementation temporary if you don't have one.:

👨‍💻 **Code Example:**
```csharp
// Code example: //
// Abstract method
public abstract void Play();

// override keyword
public override void Play()
{
    throw new NotImplementedException();
}

// Usage example: //

// Abstract class
public abstract class Game
{
    // Abstract method
    // All type of games have a play method
    public abstract void Play();
}

// Inhertiing class from the abstract class Game
public class TwentyOneGame : Game
{
    // Abstract method
    // implemented and defined in this derived class
    public void Play()
    {
        Console.WriteLine("play");
    }
}
```

📌 **Key Takeaways:**
- Defined by `abstract` keyword.
- Only exist in abstract classes.
- Cannot have implementation
- Must to be defined implementaion by the inheriting class.
- Can use `override` keyword as a placeholder.

🔄 **Active Recall Questions:**
1. What keyword is used to define this method?
2. Where does it only exist?
3. Does it have any implementation defined?
4. Which class defines its implemenation?
5. Why use `override` keyword when inherting cvlass uses this?
6. How does this relate to the concept of abstraction?
7. Why use abstract methods?
8. How does thios relate to polymoirphism and inheritance?

🔗 **Related Hands-On Project:**
- 📂  View Full Implementation in Projects Folder
C:\Users\user\Documents\GitHub\The-Tech-Academy-C-Sharp-Projects\Coding_Journal\Projects\TwentyOne\TwentyOne.sln

✅ **Checklist:**
- [ ] I understand the core concept.
- [ ] I have practiced writing C# code related to this topic.
- [ ] I can explain this topic without notes.

---

## 🔹 Virtual Methods in Abstract Classes
These methods have implementation but can be overriden and defined by the inheriting class.
Can completely override and define its own implementation or use the base clases' partially.
Identified by the `virtual` keyword. Use the `override` keyword to define this method 
in an inheriting class.:

👨‍💻 **Code Example:**
```csharp
// Code example //

// Virtual method
public virtual void ListPlayers() {}

// Usage example //

//Abstract Class
public abstract class Game
{
    // A method that prints a list of players
    public virtual void ListPlayers()
    {
        foreach (string player in Players)
        {
            Console.WriteLine(player);
        }
    }
}

// Inheriting class using the virtual method with override keyword
public class TwentyOneGame : Game
{
    public override void Play()
    {
        throw new NotImplementedException();
    }
    // override keyword
    public override void ListPlayers()
    {
        // This references the virtual method's own implementation of it
        // See the abstract class.
        base.ListPlayers();
    }
}
```

📌 **Key Takeaways:**
- Virtual methods are meant to allow inheriting classes to define their version of it.
- Must use `virtual` keyword to define a virtual method
- Inheriting classes must ad the `override` keyword when defining a virtual method 
of the base class
- Base.<virtual-method()> is a refference to the orignal implementation. 

🔄 **Active Recall Questions:**
1. What keyword defines a Virtual method?
2. What makes a virtual method different from regular methods?
3. Can virtual methods be defined in an inheriting class however or are there limitations?
4. When should you use this type of method?
5. virtual vs abstract methods.
6. How is this related to the concept of abstraction in OOP?
7. How does this relate to polymorphism?
8. How is this helpful in terms of inheritance?

🔗 **Related Hands-On Project:**
- 📂  View Full Implementation in Projects Folder
C:\Users\user\Documents\GitHub\The-Tech-Academy-C-Sharp-Projects\Coding_Journal\Projects\TwentyOne\TwentyOne.sln

✅ **Checklist:**
- [ ] I understand the core concept.
- [ ] I have practiced writing C# code related to this topic.
- [ ] I can explain this topic without notes.

---