# C# Code Journal

## Table of Contents
- [C# Course Projects](#c-course-projects)
- [Concepts](#concepts)
- [Code Snippets](#code-snippets)
- [Debugging Tips](#debugging-tips)
- [Resources](#resources)

---

## C# Course Projects

- [The-Tech-Academy-C-Sharp-Projects (GitHub)](https://github.com/7k7/The-Tech-Academy-C-Sharp-Projects) — All C# coursework projects.
- [Calculator.cs](https://github.com/7k7/The-Tech-Academy-C-Sharp-Projects/blob/main/CalculatorApp/Calculator.cs) — Example of optional parameters.
- [FileIOExample.cs](https://github.com/7k7/The-Tech-Academy-C-Sharp-Projects/blob/main/FileIOExample/FileIOExample.cs) — File I/O operations in C#.

---

## Recent GitHub Activity

![GitHub Last Commit](https://img.shields.io/github/last-commit/7k7/The-Tech-Academy-C-Sharp-Projects)
![GitHub Repo Size](https://img.shields.io/github/repo-size/7k7/The-Tech-Academy-C-Sharp-Projects)
![GitHub Contributors](https://img.shields.io/github/contributors/7k7/The-Tech-Academy-C-Sharp-Projects)

---

## C# Project Files

- [View All Project Files (Alphabetical Order)](https://github.com/7k7/The-Tech-Academy-C-Sharp-Projects/blob/main/Coding_Journal/ProjectLinks_Alphabetical.md)
- [View All Project Files (Most Recently Modified)](https://github.com/7k7/The-Tech-Academy-C-Sharp-Projects/blob/main/Coding_Journal/ProjectLinks_Recent.md)

---

## Concepts Checklist (For progress tracking)
- [ ] Classes and Objects  
- [ ] Methods and Parameters  
- [ ] Optional Parameters  
- [ ] Static vs Instance Members  
- [ ] Exception Handling  
- [ ] File I/O  

---

## Code Snippets

```csharp
// Example: Create a class with optional parameters
public class Calculator
{
    public int Add(int a, int b = 0)
    {
        return a + b;
    }
}
```

✅ **Markdown Features You’ll Love:**
- `#` for headings  
- `-` for bullet points  
- Code snippets with triple backticks ` ```csharp `  
- Checklists `[ ]` for tracking progress  

---

## **✅ Step 4: Automate Your Learning & Review**
Now that your **Concepts** folder is in Markdown, here’s how to **reinforce learning**:

### **1️⃣ Daily Review (Spaced Repetition)**
- Open **one** Markdown file each day and try to recall key concepts before reading.
- Answer the **Active Recall** questions from memory.

### **2️⃣ Track Your Progress**
- Use **checklists** at the bottom of each note to mark concepts as “mastered.”

### **3️⃣ Quick Access from Notes.md**
To navigate easily, link your Markdown notes in `Notes.md`:
```markdown
## C# Learning Topics

- [Classes and Objects](Concepts/ClassesAndObjects.md)
- [Methods and Parameters](Concepts/MethodsAndParameters.md)
- [Optional Parameters](Concepts/OptionalParameters.md)
- [Static vs Instance](Concepts/StaticVsInstance.md)
- [Exception Handling](Concepts/ExceptionHandling.md)
- [File I/O](Concepts/FileIO.md)
```

## **🚀 Updated Learning Workflow (With Anki Integration)**
**Now that Anki automatically formats your concepts correctly, your learning process is fully optimized. Here’s your step-by-step workflow for learning, reviewing, and reinforcing C# concepts efficiently.**

## **✅ Step 1: Learn a New Concept & Create a Markdown File**
### **What to Do?**
1️⃣ Pick a C# concept to learn (e.g., Method Overloading).
2️⃣ Create a new .md file (if it’s a new topic) OR add a new ## 🔹 Concept Title inside an existing file.
3️⃣ Structure your notes properly using the Markdown template.
EXAMPLE
# Methods and Parameters  

## 🔹 Method Overloading (Same Name, Different Parameters)  

🔄 **Active Recall Questions:**  
1. What is the difference between a **method** and a **function**?  
2. What happens if you don’t specify a **return type** in a method?  
3. What is **method overloading**, and why is it useful?  

📌 **Key Takeaways:**  
- Method overloading allows multiple methods with the **same name but different parameters**.  
- Overloading improves **code readability and flexibility**.  

👨‍💻 **Code Example:**  
```csharp
void Print(int number) { Console.WriteLine(number); }
void Print(string text) { Console.WriteLine(text); }

🔗 Related Hands-On Project:
📂 View Full Implementation in Projects Folder
```

✅ **Make sure the format is consistent so the script extracts everything correctly.**  

### ** Hands-On Practice in Visual Studio **
What to Do?
1️⃣ Open Visual Studio and create a small coding project related to the new concept.
2️⃣ Try implementing examples from your Markdown file:
- Write your own variations of the code.
- Experiment with different parameter types and logic.
- Debug and understand errors that occur.
3️⃣ Upload your code to GitHub in The-Tech-Academy-C-Sharp-Projects repository.
✅ This ensures practical application of what you’re learning!

** 📌 Where to Store Project Files in Coding_Journal? **
- Inside your Coding_Journal, create a dedicated folder for hands-on coding practice to keep things organized and easily accessible.

EXAMPLE
```
Coding_Journal/
│── Concepts/                # Markdown notes on concepts
│── Projects/                # Hands-on practice files
│   ├── MethodsAndParameters/ # Example: Folder for a specific concept
│   │   ├── MethodOverloading.cs
│   │   ├── OptionalParameters.cs
│   │   └── README.md          # Explanation of project files
│   ├── LINQQueries/
│   ├── Interfaces/
│   └── Other_Concepts/
│── ProjectLinks_Alphabetical.md
│── ProjectLinks_Recent.md
```
✅ Why Use Projects/ Inside Coding_Journal?
✔ Keeps hands-on code organized per concept.
✔ Easier to reference projects while reviewing Anki cards.
✔ Allows simple linking between Markdown notes and actual code.
✔ Helps track practical implementation of concepts.

✅ Best Practices
1️⃣ Create a new folder inside Projects/ for each concept.
2️⃣ Use meaningful filenames for .cs files (e.g., MethodOverloading.cs).
3️⃣ Include a README.md to summarize what the files contain.


## **✅ Step 2: Run the Anki Import Script**  
### **What to Do?**  
1️⃣ **Open Anki** and ensure it’s running in the background.  
2️⃣ **Run the script** in your terminal or command prompt:  
   ```sh
   python add_to_anki.py
   ```
3️⃣ **The script will:**
- Scan your Concepts folder for new/updated Markdown files.
- Extract all concepts (## 🔹 Concept Title).
- Create properly formatted Anki cards:
- Front: Concept Title + Active Recall Questions
- Back: Key Takeaways + "Show Code" button
- Automatically skip duplicates to avoid redundant cards.
✅ Now, your new concept is ready for review in Anki!

## ✅ **Step 3: Review in Anki (Active Recall)**
### **What to Do?**
1️⃣ **Open Anki** every day and review scheduled cards.
2️⃣ **When a card appears:**
Read the Concept Title.
Try to answer the Active Recall Questions without looking.

3️⃣ **Flip the card to check the Key Takeaways:**
If you got it right → ✅ Mark Easy (longer review interval).
If you struggled → 🔄 Mark Again (shorter review interval).

4️⃣ **Click "Show Code"** if needed to verify how it works.
✅ The script ensures everything is inside Anki, so you don’t need to open Markdown files during review!

## ✅ **Step 4: Improve Notes & Concepts Based on Review**
### **What to Do?**
1️⃣ **If you struggled with a concept:**
- Revisit the Markdown file (Concepts/).
- Improve Key Takeaways (make them clearer).
- Add extra questions to help reinforce weak areas.
1. Find the card in Anki and delete it manually.
2️. Update the corresponding .md file inside Concepts/.
3️. Run the script again to re-add the updated concept:
```python add_to_anki.py```
4️. The script will now:
- Add the updated version of the card to Anki.
- Ensure that no duplicates are created.
5️. Review the updated card in Anki when it appears in your schedule.
✅ This ensures that Anki always has the latest version of your concept notes!

2️⃣ **If a concept feels fully mastered:**
- Lower its review frequency in Anki to avoid unnecessary repetition.
- Archive the Markdown file if it’s no longer needed.
✅ Now, you continuously refine your understanding while reviewing efficiently.

3️⃣ **Identify Most Missed Concepts**
What to Do?
1️⃣ Check Anki’s built-in stats:
Open Anki
Click "Stats" (Shift + S)
Look for "Leech Cards" or "Lapses"
2️⃣ If a concept is frequently forgotten:
Revisit the Markdown file (Concepts/).
Improve Key Takeaways (make them clearer).
Add extra Active Recall Questions to reinforce weak areas.
3️⃣ Delete the old card manually, update the .md file, then run the script again to re-add it.
✅ This ensures that your notes & Anki cards evolve with your learning progress.

## **🔥 Final Workflow Summary**
### **Step Action**
1️⃣ Learn a Concept	Write a Markdown Note (Concepts/).
2️⃣ Run the Script	Extract concepts into Anki (python add_to_anki.py).
3️⃣ Review in Anki	Test recall daily, flip for Key Takeaways, check "Show Code". 
Anki schedules your reviews and adjusts difficulty dynamically. 
If you need to check your weak concepts, Anki's built-in stats help you see your most missed cards.
4️⃣ Improve concept notes. Update .md files based on struggles in Anki.
💡 Now, you only focus on reviewing and improving—not on manual tracking.


## **📌 What is Coding_Journal/Challenges For?**
The Challenges/ directory inside your Coding_Journal is meant for storing coding exercises, problem-solving challenges, and algorithm practice that reinforce key concepts you're learning.

✅ How It Fits Into Your Workflow
Folder	Purpose
Concepts/	Markdown notes explaining C# concepts.
Projects/	Hands-on coding practice for each concept.
Challenges/	Coding challenges & problem-solving practice.
✅ When to Use Challenges/
When you complete coding exercises from courses, books, or online coding platforms.
When practicing algorithmic problem-solving (e.g., LeetCode, HackerRank, CodeWars).
When you want to reinforce a concept with self-made practice problems.
When preparing for coding interviews or technical assessments.
```
Coding_Journal/
│── Concepts/                  # Theory & explanations
│── Projects/                   # Hands-on coding practice
│── Challenges/                 # Coding exercises & algorithm practice
│   ├── Arrays/                 # Subfolder for array challenges
│   │   ├── ReverseArray.cs
│   │   ├── FindMaxValue.cs
│   │   └── README.md
│   ├── Recursion/
│   ├── LINQ/
│   ├── OOP_Practice/
│   └── Other_Exercises/
```

✅ Best Practices for Using Challenges/
✔ Create subfolders based on challenge type (e.g., Arrays/, Recursion/, OOP_Practice/).
✔ Write a README.md explaining the challenge and solution.
✔ Link challenges to related concepts in your Concepts/ Markdown notes.
✔ Use comments in .cs files to explain logic & thought process.

🔥 Example of a Challenge
📂 Path: Coding_Journal/Challenges/Arrays/FindMaxValue.cs
```csharp
using System;

class Program
{
    static void Main()
    {
        int[] numbers = { 10, 25, 33, 15, 99, 65 };
        int max = FindMax(numbers);
        Console.WriteLine($"The maximum value is: {max}");
    }

    static int FindMax(int[] arr)
    {
        int max = arr[0];
        foreach (int num in arr)
        {
            if (num > max)
                max = num;
        }
        return max;
    }
}
```

📄 README.md (Inside Challenges/Arrays/):
```
# Find Maximum Value in an Array

## 🔹 Challenge:
Write a C# function that finds the **largest number** in an array.

## 📌 Key Takeaways:
- Use **loops** to iterate over an array.
- Use **conditional logic** to update the max value.
- Understand **edge cases** (e.g., empty arrays, single-element arrays).

## 👨‍💻 Code Implementation:
[FindMaxValue.cs](FindMaxValue.cs)
```

**🚀 Summary**
- Challenges/ is for coding exercises, algorithm practice, and problem-solving.
- It helps you reinforce concepts through hands-on practice.
- Each challenge should have a .cs file + a README.md explaining the solution.
- You can link challenges to Concepts/ to make learning more structured.





# 🚀 Learning Workflow (C# + Anki + Coding Practice)

This file contains my structured **learning workflow** for mastering C# efficiently.

---

## ✅ Step 1: Learn a New Concept  
1. **Choose a topic** from my bootcamp or documentation.  
2. **Create/update a `.md` file** inside `Concepts/` using the template.  
3. **Ensure the file includes**: Concept Title, Active Recall Questions, Key Takeaways, and a Code Example.

---
## ✅ Step 2: Hands-On Coding Practice  
1. **Implement the concept** inside `Projects/` as a mini-project.  
2. **Experiment with different approaches & variations.**  
3. **Link to Project** | Add a **direct link** from `Concepts/` to `Projects/`. |
3. **Upload my project files to GitHub.**

---

## ✅ Step 3: Add Concept to Anki  
1. **Ensure Anki is running.**  
2. **Run the script** to extract concepts and add them to Anki:  
   ```sh
   python add_to_anki.py
   ```
3. Now, Anki contains:
- Front: Concept Title + Active Recall Questions
- Back: Key Takeaways + Code Example (collapsible)

---

## ✅ Step 4: Daily Review in Anki
1. Use Anki's spaced repetition.
2. Test my recall using Active Recall Questions.
3. Click “Show Code” when needed.
4. Rate my confidence level to adjust review intervals.

---

## ✅ Step 5: Improve Weak Areas
1. Check Anki stats for most missed concepts.
2. Update Concepts/ files if needed (add clarity, improve examples).
3. Delete old Anki cards manually and re-run the script to update them.

🔥 With this system, I can focus on learning, reviewing, and coding without unnecessary tracking! 🚀

---

### **📌 Summary of Changes**  
✔ **Now your workflow emphasizes coding first, then review in Anki!**  





# 🚀 Git Workflow: Syncing Your Local Coding_Journal with Your Remote Repo
Since your Coding_Journal folder is inside your GitHub repository (The-Tech-Academy-C-Sharp-Projects), you need a consistent Git workflow to keep both your local and remote copies updated and in sync.

## **📌 Step-by-Step Git Workflow**
Whenever you make changes to Coding_Journal locally, follow this workflow to push updates to GitHub:

✅ Step 1: Open Your Terminal & Navigate to Coding_Journal
1️⃣ Open Git Bash (or Command Prompt/PowerShell if Git is installed).
2️⃣ Navigate to your GitHub repo where Coding_Journal is located:
```sh
cd "C:\Users\user\Documents\GitHub\The-Tech-Academy-C-Sharp-Projects"
```

---

✅ Step 2: Ensure Your Local Repo is Up-to-Date
Before making any changes, sync with the latest remote updates to avoid conflicts:
```sh
git pull origin main
```
📌 Why?
✔ This ensures your local Coding_Journal folder is up-to-date with any new changes from the GitHub repo.
✔ Prevents merge conflicts if the remote repo has been modified.

---

✅ Step 3: Stage Your Changes
After updating any files inside Coding_Journal, stage them for commit:
```sh
git add Coding_Journal
```
📌 Why?
✔ This tells Git which files should be included in the next commit.
✔ Coding_Journal ensures that everything inside the folder is staged.

---

✅ Step 4: Commit Your Changes
Now, commit your changes with a meaningful message:
```
git commit -m "Updated Coding_Journal notes and Anki workflow"
```
📌 Why?
✔ Commits track what changes were made and why.
✔ Helps you revert if needed.

--- 

✅ Step 5: Push Your Changes to GitHub
Once committed, push your changes to the remote repo:
```
git push origin main
```
📌 Why?
✔ Uploads your local changes to GitHub, keeping both in sync.
✔ Allows you to access your updated notes anywhere.

---

✅ Step 6: Verify Changes on GitHub
1️⃣ Go to your GitHub repository:
🔗 https://github.com/7k7/The-Tech-Academy-C-Sharp-Projects
2️⃣ Check the Coding_Journal/ folder to confirm that your updates are reflected.

---

## **🔥 Summary of Git Sync Workflow**
Step	Command	Purpose
1️⃣ Navigate to Repo	cd "C:\Users\user\Documents\GitHub\The-Tech-Academy-C-Sharp-Projects"	Move to the local repo.
2️⃣ Sync Latest Changes	git pull origin main	Ensure your local repo is up to date.
3️⃣ Stage Changes	git add Coding_Journal	Prepare Coding_Journal changes for commit.
4️⃣ Commit Changes	git commit -m "Updated Coding_Journal notes and Anki workflow"	Save a snapshot of changes.
5️⃣ Push to GitHub	git push origin main	Upload changes to the remote repository.
6️⃣ Verify on GitHub	Check Coding_Journal/ in the GitHub repo	Ensure updates are reflected.

---

## **✅ How Often Should You Sync?**
- Every time you finish updating notes, projects, or challenges inside Coding_Journal/.
- Before switching computers, so your latest work is available remotely.
- Before pulling new changes, to avoid merge conflicts.