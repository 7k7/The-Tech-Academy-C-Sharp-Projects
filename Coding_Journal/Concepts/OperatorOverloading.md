# Operator Overloading  

**Overview**
Overload = make your own implementation.
overloading operators mean overriding the + - / * operators
with a different implementation specific to your object class.

---
## 🔹 Overloading an Operator
Defines an implementation for an operator, overriding its default behavior
within a specific class.

👨‍💻 **Code Example:**
```csharp
// code eg //
public static Game operator+ (Game game, Player player)
{
    game.Players.Add(player);
    return game;
}

// usage of overloaded operator methods //

public class Player
{
    public List<Card> Hand {  get; set; }
    public int Balance { get; set; }
    public string Name { get; set; }
    public bool isActivelyPlaying { get; set; }

    // overloaded operator methods //

    // for plus operator
    public static Game operator+ (Game game, Player player)
    {

        game.Players.Add(player);
        return game;
    }

    // subtract oiverload operator
    public static Game operator- (Game game, Player player)
    {
        game.Players.Remove(player);
        return game;
    }
}

internal class Program
{
    static void Main(string[] args)
    {
        Game game = new TwentyOneGame();
        // must instantiate a list in order to use it
        game.Players = new List<Player>();
        Player player = new Player();
        player.Name = "Jesse";
        // operator + overload use here:
        // game + player is the method call so to speak
        game = game + player;
        // now user the operator - using short hand way
        game -= player;
    }
}

// Overloading Comparison Operators by pairs
// Employee class with certain properties
public class Employee
{
    public string Id { get; set; }
    public string FirstName { get; set; }   
    public string LastName { get; set; }

    // overloaded == and != operators
    public static Boolean operator== (Employee one, Employee two)
    {
        // Checks if the two Employee objects are equal by Id field
        bool isEqual = one.Id == two.Id;
        return isEqual;
    }

    public static Boolean operator!= (Employee one, Employee two)
    {
        // Checks if both Employees's Ids are not equal
        bool isNotEqual = one.Id != two.Id;
        return isNotEqual;
    }
}
```

📌 **Key Takeaways:**
- Defined like a method but with the `operator<type>` as the name. 
- must be `static` keyword
- In parenthesis, it takes parameters that will be used to overload operator
- Can implement whatever you want
- Allows you to make your own implementation of the operator as a nifty shortcut
- Comparison operators can be overloaded but must be done in pairs i.e. < and >

🔄 **Active Recall Questions:**
1. How to name a operator overloading method?
2. Must it static?
3. What does it take in parenethuiss?
4. What can you define for its implementation?
5. Why use it?
6. What operators must be overloaded in pairs?

🔗 **Related Hands-On Project:**
- 📂  View Full Implementation in Projects Folder
C:\Users\user\Documents\GitHub\The-Tech-Academy-C-Sharp-Projects\Coding_Journal\Projects\TwentyOne\TwentyOne\Player.cs

✅ **Checklist:**
- [ ] I understand the core concept.
- [ ] I have practiced writing C# code related to this topic.
- [ ] I can explain this topic without notes.

---