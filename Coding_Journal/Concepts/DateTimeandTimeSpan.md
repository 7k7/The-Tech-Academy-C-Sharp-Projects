# DateTime

**Overview**
Its a struct meanin not nullable
therefore a value type

---
## 🔹 Concept Title
Add description here:

👨‍💻 **Code Example:**
```csharp
DateTime yearOfBirth = new DateTime(1995, 2, 27, 8, 32, 45);
DateTime yearOfGraduation = new DateTime(2013, 6, 1, 16, 34, 22);

TimeSpan ageAtGraduation = yearOfGraduation - yearOfBirth;


public class Dealer
{
    public string Name { get; set; }
    public Deck Deck { get; set; }
    public int Balance { get; set; }

    public void Deal(List<Card> Hand)
    {
        Hand.Add(Deck.Cards.First());
        // store card dealt 
        string card = string.Format(Deck.Cards.First().ToString() + "\n");
        Console.WriteLine(card);
        // logging to file each card being dealt in game
        // This appends to the file
        using (StreamWriter file = new StreamWriter(@"C:\Users\kevinmontano\log.txt", true))
        {
            file.WriteLine(DateTime.Now); // add current time
            file.WriteLine(card);
        }
        Deck.Cards.RemoveAt(0);
    }
}
```

📌 **Key Takeaways:**
- Summarize the key ideas of this topic.

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

# TimeSpan

**Overview**
Add short summary

---
## 🔹 Concept Title
Add description here:

👨‍💻 **Code Example:**
```csharp
// Add all relevant C# code example here.
```

📌 **Key Takeaways:**
- Summarize the key ideas of this topic.

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