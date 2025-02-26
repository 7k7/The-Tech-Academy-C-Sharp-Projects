# Assembly

**Overview**
An application compiled into CIL (Common Intermedite Language)
are called an assembly.

---
## 🔹 Assembly Definition 
They are either .exe or .dll files of apps
Assemlies can be static or dynamic
Static assembly = stored on disk
Synamic assembly = run from memory and is not stored to the disk prior to exection.
All program is compiled twice. To CIL then to machine code.
Each computer/machine has its own compiler

👨‍💻 **Code Example:**
```csharp
// Add all relevant C# code example here.
```

📌 **Key Takeaways:**
- Your projects get compiled to an Assembly
- C# compiles an application into CIL is an assembly
- assemblies are either .exe or .dll
- .exe files = a program that can run.
- .dll files = a library of reusable code.
- Assemblies are compiled again by the computer to machine code
- Can be static, stored on disk
- can be dynamic, run from memory and not stored to disk till app is executed

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
# Libraries

**Overview**
Reusable code. 
The TwentyOne game program can be compiled into a dll library.
Without the main()

---
## 🔹 Referencing Libraries in your Console App
Create a library inside same solution,
build it to generate a .dll library
Then refernce it within your console app executable

📌 **Key Takeaways:**
- Reference = libraries included in your console app
- Create a library inside same solution,
- build it to generate a .dll library
- Then refernce it within your console app executable
- Everything except `Program.cs` is moved to own namespace library
- Can share on Github the .dll; they make their own main()

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