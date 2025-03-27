# MVC

**Overview**
MVC is a pattern of organization for a computer program.

---
## 🔹 MVC
A way of organizing code of a computer program to make changes easier over time

📌 **Key Takeaways:**
- MVC = Model View Controller
- MVC is a pattern of organization for a computer program
- MVC divided three interconnected common elements of a program to provide easier modifications to it over time
- `Concerns` = three common elements in a program. they are:
1. `View` = present data to the user
2. `Model` = managing the data, logic and rules of the program
3. `Controller` = Taking in user input and passing commands to the Model and View based on that user input
- Code is organized in three folders called Models, Views, and Controllers.
- MVC framework asists with template code a programmer would start with then add to the program to customize the overall program needs.
- `Separation of concerns` = separating code in different sections based on what that code is concerned with. This is the main concept of MVC
- Code is easy to maintain over time via separations of concerns  because code is organized in a way that modifying code only involves the necessary code
- HTTP Request and Response system: a user requests a resource via browers, web server gets resource ane returns repsonse and renders a view back to user
- MVC is an architectural paradigm that focuses on separations of concerns. 
- `ASP.NET MVC` is an MVC web app framework.
- Default view is `Index.cshtml view` at the route `Home/Index`
- The `View` you passing from Controller is used in `@RenderBody()` in the `_Layout.cshtml`

🔄 **Active Recall Questions:**
1. What does MVC stand for?
2. What is MVC?
3. How is a program divided using the MVC design pattern?
4. What are `concerns`?
5. What are the three `concerns` in MVC? Define each.
6. What folders is code in a program organized in using MVC?
7. What type of code library asists with creating a program using the MVC pattern with some pre-made template code?

🔗 **Related Hands-On Project:**
- 📂  View Full Implementation in Projects Folder

✅ **Checklist:**
- [ ] I understand the core concept.
- [ ] I have practiced writing C# code related to this topic.
- [ ] I can explain this topic without notes.

---
## 🔹 Model (MVC)
It is a class the represents a specific element or object with which your program is interacting

📌 **Key Takeaways:**
- A `Model` is a class
- `Model` represents a specific element or object your program is interacting with
- `Model`s are the things in the domain, which means subject or field, you are working with
- A `Model` usually maps exactly to a db table where each of its properties correspons to a column.
- Example: Bike Shop program. Models: Bike, Customer, Order.

🔄 **Active Recall Questions:**
1. What is the data type of a `Model`?
2. What does a `Model` represent?
3. To what does a `Model` usually maps to?

🔗 **Related Hands-On Project:**
- 📂  View Full Implementation in Projects Folder

✅ **Checklist:**
- [ ] I understand the core concept.
- [ ] I have practiced writing C# code related to this topic.
- [ ] I can explain this topic without notes.

---
## 🔹 View (MVC)
It is the visual display of a program given to a user.

📌 **Key Takeaways:**
- A `View` is the part of a program that the user sees and interacts with.
- A `View` usually is a `.cshtml` file; a file made of csharp and html
- EXAMPLE: Bike Shop MVC app. `OrderPage.cshtml` would provide the user an order screen to place an order
- A MVC app has a folder called `Views` which holds `.cshtml` files in folders derived from `Controller` classes
- `Layout template` file under `Views/Shared folder` is a `view` file containeing the 'theme' of the website that is applied to ALL `views`
- `Razor syntax` is used in `.cshtml` `view` files to denote `Csharp` CODE
- An `@` is for single lines and you add in `{ }` if multiple lines
- `ViewData` is like a `Csharp dictionary` as follows: `ViewData["<KEY>"] = <VALUE>`
- `ViewBag` is a dynamic property that is used to pass data from the `Controller` to `View`
- `property name` comes after the `.` and its value is assigned like so: `ViewBag.id = '123';`
- When passing a `ViewData`, it is a key-value pair.
- When passing a `ViewBag`, it is a property.
- To pass parameters to a method, the URL route ends with that data: `Home/Index/12`
- The number is an `id` of the `object` you want data on. 
-

🔄 **Active Recall Questions:**
1. What part of a program is the `View`?
2. What type of file is the `View` usually?

🔗 **Related Hands-On Project:**
- 📂  View Full Implementation in Projects Folder

✅ **Checklist:**
- [ ] I understand the core concept.
- [ ] I have practiced writing C# code related to this topic.
- [ ] I can explain this topic without notes.

---
## 🔹 Controller (MVC)
The part of a program responsible for handling user requests and interactions.

📌 **Key Takeaways:**
- A `Controller` is the part of a program that interprets what is being requested by the user
- A `Controller` handles any business logic
- A `Controller` returns the proper view back to the user
- EXAMPLE: Bike shop app. Controller file `OrderController.cs` contains logic for ordering bikes. After a user orders something via the `OrderPage.cshtml` page, the request would go to a speific method in the controller, which would do things like process a credit card and update a database with a new order.
- A `Controller` is a `class` whose job is to figure out what to display to the user
- All `Controller` files are inside a directory called `Controllers`
- Naming format for a `Controller` file is: `[thing_being_controlled][Controller].cs`
- File name and `Class` name are the same for a `Controller` class
- A `Controller` class file always inherits from the `Controller Class`
- The method `View()` and the pseudo-dictionary `ViewBag` are provided by the `Controller` class a `Controller` inherits from
- `Controller methods` return type is `IActionResult` which is the result of an action being performed by the method. E.g. The `View()` returning a result or action
- `IActionResult` is a `class` from the `Microsft.AspNetCore.Mvc` namespace
- The `View()` returns the `View` `.cshtml` file following the `Controller class` name and `Controller method` name. If another name is passed in the `View()`, it will seek that file

🔄 **Active Recall Questions:**
1. What is a web app?
2. What handles the display of a web app?
3. What does a web browser do?
4. What does a web server handle?
5. What makes a computer program different from web app?

🔗 **Related Hands-On Project:**
- 📂  View Full Implementation in Projects Folder

✅ **Checklist:**
- [ ] I understand the core concept.
- [ ] I have practiced writing C# code related to this topic.
- [ ] I can explain this topic without notes.

---
## 🔹 Web app vs computer app
The key difference between the two.

📌 **Key Takeaways:**
- A `web app` is a comp program that uses both web browser and web server to acoomplish its functions
- Browser displays information to user and allows user to input and interact with web app
- Web server handles the processing actions based on a user's input
- Computer prgrams reside entirely on a computer

🔄 **Active Recall Questions:**
1. What is a web app?
2. What handles the display of a web app?
3. What does a web browser do?
4. What does a web server handle?
5. What makes a computer program different from web app?

🔗 **Related Hands-On Project:**
- 📂  View Full Implementation in Projects Folder

✅ **Checklist:**
- [ ] I understand the core concept.
- [ ] I have practiced writing C# code related to this topic.
- [ ] I can explain this topic without notes.

---
## 🔹 Design Pattern
Established ways of organizing code to solve a particular problem

📌 **Key Takeaways:**
- 'Design pattern' is a way of organizing code to solve a particular problem.
There are established ways to solve common problems
- Each design pattern has a name
- Example: repository pattern = grouping code related to making database calls in the same folder or file and adding 'Repository' in the name

🔄 **Active Recall Questions:**
1. Whats a design pattern?
2. Does each design pattern have a name?

🔗 **Related Hands-On Project:**
- 📂  View Full Implementation in Projects Folder

✅ **Checklist:**
- [ ] I understand the core concept.
- [ ] I have practiced writing C# code related to this topic.
- [ ] I can explain this topic without notes.

---
## 🔹 Separation of concerns in MVC
Organizing code in different folders based on the area of concern.
There are 3 areas of concerns:

📌 **Key Takeaways:**
- One concern is `where to handle the business logic of the app`?
- `Business logic` = The critical decisions that your app should make to implement the goals of your business. Why you made the app?
- The `Controller` handles the business logic of an app
- Another concern: `How to get current state data from the things an app keeps track of?`
- `Model` hadnles state of data of objects and keeps tracks of them
- The web is `stateless` = A website displays the state of data at a specific point in time. It can and does change after that. 
- Lastly, another concern: `The need for a user interface for a user to interact and display content and data`
- `View` handles user interface
- These separations of concerns allows the app to be easily maintained over time.


🔄 **Active Recall Questions:**
1. What is the concern that a `Controller` handles?
2. What concern does the `View` handle?
3. What concern does the `Model` handle?
4. What does it mean that the web is `stateless`?
5. What is the benefit of separation of concerns in an app? 

🔗 **Related Hands-On Project:**
- 📂  View Full Implementation in Projects Folder

✅ **Checklist:**
- [ ] I understand the core concept.
- [ ] I have practiced writing C# code related to this topic.
- [ ] I can explain this topic without notes.

---
## 🔹 MVC Library
the `system.web.mvc` namespace represents the MVC library portion of the .NET Framework Class Library.

📌 **Key Takeaways:**
- The `system.web.mvc` namespace is the MVC library with .NET framwork Class Lib
- It holds the many data types and their methods that MVC apps use


🔄 **Active Recall Questions:**
1. What namespace contains the MVC library?
2. What holds powerful data types and methods of MVC apps?

🔗 **Related Hands-On Project:**
- 📂  View Full Implementation in Projects Folder

✅ **Checklist:**
- [ ] I understand the core concept.
- [ ] I have practiced writing C# code related to this topic.
- [ ] I can explain this topic without notes.

---
## 🔹 .CONFIG
Files with `.CONFIG` contain information related to how the project is set up and how it should operate.

📌 **Key Takeaways:**
- `.Config` is a file extension for files that contain information related to the settings of a project and how it operates.
- It really is an XML document with tags indicating what database to use, C# compiler version to use or 3rd party libraries to use.
- `web.config` contains information on the database used like its name and credentails to access it.
- `package.config` contains information about 3rd party libraries used.

🔄 **Active Recall Questions:**
1. What do `.config` files contain?
2. What type of document is a `.config` file really?
3. What information does `web.config` hold?
4. What information does the `package.config` hold?

🔗 **Related Hands-On Project:**
- 📂  View Full Implementation in Projects Folder

✅ **Checklist:**
- [ ] I understand the core concept.
- [ ] I have practiced writing C# code related to this topic.
- [ ] I can explain this topic without notes.

---
## 🔹 Azure by Microsoft
Set of cloud-services

📌 **Key Takeaways:**
- Azure is a set of cloud services by Microsoft
- One part of it hosts databases and the other web apps

🔄 **Active Recall Questions:**
1. What is azure?
2. What does azure host?

🔗 **Related Hands-On Project:**
- 📂  View Full Implementation in Projects Folder

✅ **Checklist:**
- [ ] I understand the core concept.
- [ ] I have practiced writing C# code related to this topic.
- [ ] I can explain this topic without notes.

---
## 🔹 Web Forms


📌 **Key Takeaways:**
- `IIS` stands for Internet Information Services
- `IIS` is a web server that runs on the Windows platform that renders requested HTML pages or files
- `IIS Express` is a verison of `IIS` that helps with creating and testing websites
- `Razor` is markup syntax found in `.cshtml` files which combine Csharp and HTML code in one
- `Razor` syntax is indicated with the `@` symbol to denote Csharp code in the file to help render it as such.
- All csharp code in `.cshtml` files are rendered on the web server, populating the file as html only before sending it to the user's web browser.
- `ASP.NET` is a framework by Microsoft to create dynamic websites with large amounts of data.
- `ASP.NET Web Forms` is a programming model that can be used to create `ASP.NET` web apps
- `Web Forms` is an event-driven model for creating dynamic websites

🔄 **Active Recall Questions:**
1. What does IIS stand for?
2. What is IIS?
3. What is IIS Express?
4. What is `razor`?
5. What razor syntax denoted csharp code in a `.cshtml` file?
6. Where is csharp code rendered in a `.cshtml` file?
7. What is `ASP.NET Web Forms`?
8. What kind of model is `Web Forms`?

🔗 **Related Hands-On Project:**
- 📂  View Full Implementation in Projects Folder

✅ **Checklist:**
- [ ] I understand the core concept.
- [ ] I have practiced writing C# code related to this topic.
- [ ] I can explain this topic without notes.

---
## 🔹 Microsoft Web API
A framwork that allows you to build HTTP servies to a broad range of clients including broswers and mobile devices.

📌 **Key Takeaways:**
- `Microsft Web API` is a framework for building HTTP services for mutliple types of clients
- it is ideal for building `RESTful` apps
- `RESTful` is a system that can use HTTP protocol to monitor and control the state of various resources

🔄 **Active Recall Questions:**
1. What is the `Microsoft Web API` and what is it for?
2. What type of apps is it best ideal for?
3. What is `RESTful`?

🔗 **Related Hands-On Project:**
- 📂  View Full Implementation in Projects Folder

✅ **Checklist:**
- [ ] I understand the core concept.
- [ ] I have practiced writing C# code related to this topic.
- [ ] I can explain this topic without notes.

---
## 🔹 Razor Pages
A front-end-centric framework for creating dynamic, data-driven websites without the complexiting of MVC.

📌 **Key Takeaways:**
- `Razor Pages` is a framework for creating dynamic, data-driven websites 
- It is built upon ASP.NET Core MVC
- All concerns of MVC are combined into the Razor Page itself
- `Razor Pages` is lightweight and allows full control of rendered HTML
- Extension is `cshtml` for `Razor Pages`
- Razor syntax rules:
1. Code blocks enclosed in `@{  }`
2. Inline expressions like variables and functions are denoted with `@`
3. Variables are declared with the `var` keyword
4. Csharp code is case sensitive

🔄 **Active Recall Questions:**
1. What is `Razor Pages`?
2. What is it used for?
3. Based on what other framework is `Razor Pages` built upon?
4. How is it related to MVC?
5. What full control does `Razor Pages` offer?
6. What is the file extension for `Razor pages`
7. What are the four `razor syntax` rules?

🔗 **Related Hands-On Project:**
- 📂  View Full Implementation in Projects Folder

✅ **Checklist:**
- [ ] I understand the core concept.
- [ ] I have practiced writing C# code related to this topic.
- [ ] I can explain this topic without notes.

---
## 🔹 ASP.NET CORE
A microsft framework 

📌 **Key Takeaways:**
- Core is said perform better than ASP.NET Framework
- Core is open-souce and devs can contribute to it via Github Repo
- ASP.NET CORE has merged both the MVC and WEB SPI into one single, seamless API service

🔄 **Active Recall Questions:**
1. Does Core perform better than ASP.NET Framework?
2. Is Core open-source?
3. What merge happened in the first major release?

🔗 **Related Hands-On Project:**
- 📂  View Full Implementation in Projects Folder

✅ **Checklist:**
- [ ] I understand the core concept.
- [ ] I have practiced writing C# code related to this topic.
- [ ] I can explain this topic without notes.

---
## 🔹 ASP.NET CORE VS ASP.NET FRAMEWORK
pros and cons

📌 **Key Takeaways:**
- With Core, can leverage MVC and Razor Pages packages to build testable web apps and APIs faster and more efficiently
- Core is designed to be a modular series of NuGet packages which helps cut out a lot of overhead and only referene and deploy packages that theur apps need
- Core can run on the OG .NET Framework or new .NET Core framework libraries. 

🔄 **Active Recall Questions:**
1. What can devs leverage in CORE to build web apps and APIS faster?
2. How is Core designed that helps cut overhead?
3. ASP.NET CORE can run on which framework libraries?

🔗 **Related Hands-On Project:**
- 📂  View Full Implementation in Projects Folder

✅ **Checklist:**
- [ ] I understand the core concept.
- [ ] I have practiced writing C# code related to this topic.
- [ ] I can explain this topic without notes.

---
## 🔹 How web pages are served up by web servers
Web servers use routes to serve up MVC app's webpages

📌 **Key Takeaways:**
- A `Route` is the path after the domain name like Home/Contact
- `web address` is where the server is located contains the `domain name`
Example: https://localhost:44385/ the IIS express server location
- `Routes` are defined the in the URLs which have a sepcific pattern
- The web server parses through a route in a specific way:
-Starts at the first word as the `controller` after the domain name "Home"
Which references the `HomeController.cs` file.
-Then the next word is the `method` inside the `HomeController.cs`
- Returns whatever resource at this specific route
- Then the view() method returns the specific webpage which is a view .cshtml that shares the same name as the method name

🔄 **Active Recall Questions:**
1. What is a route?
2. What is a web address?
3. What is a domain name?
4. Where are `Routes` defined at?
5. How does the web server parse a `Route` for a MVC app?
6. What does `view()` return?

🔗 **Related Hands-On Project:**
- 📂  View Full Implementation in Projects Folder

✅ **Checklist:**
- [ ] I understand the core concept.
- [ ] I have practiced writing C# code related to this topic.
- [ ] I can explain this topic without notes.

---
## 🔹 Logging in MVC Web App
This demo logging events to a text file. This logic is in the HomeController. Then the view is returned to user. Purpose is to monitor or track who visits your site or which method is called.

👨‍💻 **Code Example:**
```csharp
public class HomeController : Controller
{
    public ActionResult Index()
    {
        string text = "Hello";
        System.IO.File.WriteAllText(@"C:\Users\user\Documents\GitHub\The-Tech-Academy-C-Sharp-Projects\Coding_Journal\Projects\IntroToMVC\log.txt", text);
        return View();
    }
}
```

📌 **Key Takeaways:**
- Logging allows for tracking events each time a specific method/view is visited

🔄 **Active Recall Questions:**
1. Logging allows for what?

🔗 **Related Hands-On Project:**
- 📂  View Full Implementation in Projects Folder

✅ **Checklist:**
- [ ] I understand the core concept.
- [ ] I have practiced writing C# code related to this topic.
- [ ] I can explain this topic without notes.

---
## 🔹 Reference a ViewBag variable from a View
Using `ViewBag` to create variables and reference them from the corresponding view .cshtml file of that specific controller method it was created in

👨‍💻 **Code Example:**
```csharp
public class HomeController : Controller
{
    public ActionResult Index()
    {
        Random rnd = new Random(10);
        int num = rnd.Next();

        // print random number by referencing it on Index.cshtml
        // declare and initialize it here first
        ViewBag.RandomNumber = num;
        return View();
    }
}

--- 
// In the Index.cshtml file
// Should display random number when you pull up the index page
@ViewBag.RandomNumber

```

📌 **Key Takeaways:**
- `Viewbag` allows to create variables in Controller classes and reference them in their corresponding view .cshtml file

🔄 **Active Recall Questions:**
1. `Viewbag` is what?
2. What does it do?

🔗 **Related Hands-On Project:**
- 📂  View Full Implementation in Projects Folder

✅ **Checklist:**
- [ ] I understand the core concept.
- [ ] I have practiced writing C# code related to this topic.
- [ ] I can explain this topic without notes.

---
## 🔹 Return a different view than the default
Pass in the view exact name in the View() to return a specific view than the default

👨‍💻 **Code Example:**
```csharp
public class HomeController : Controller
{
    public ActionResult Index()
    {
        Random rnd = new Random(10);
        int num = rnd.Next();

        // Diff view rendered only if num is geater than 200000
        if (num > 200000) 
        {
            // Return a diff view by passing in its name
            return View("About");
        }
        return View();
    }
}

```

📌 **Key Takeaways:**
- Can render a diff view by passing in the specified name of that view in the View()
- It works if the view is within the same controller class file

🔄 **Active Recall Questions:**
1. How to render a different view other than the default for a controller method?
2. Are there any constraints on which view can be referenced besides the default?

🔗 **Related Hands-On Project:**
- 📂  View Full Implementation in Projects Folder

✅ **Checklist:**
- [ ] I understand the core concept.
- [ ] I have practiced writing C# code related to this topic.
- [ ] I can explain this topic without notes.

---
## 🔹 Return nothing or just text from a Controller Method
Can return other data not just view files from a controller method

👨‍💻 **Code Example:**
```csharp
public class HomeController : Controller
{
    return Content("Hello!");
    // or nothing in case you are already on that page:
    // return Content("");
}

```

📌 **Key Takeaways:**
- Can return other data besides a view within a controller method
- it is possible because `ActionResult` is a broad data type

🔄 **Active Recall Questions:**
1. What method can return a different data than a view?
2. Why is it possible to return something other than a view from a controller method?

🔗 **Related Hands-On Project:**
- 📂  View Full Implementation in Projects Folder

✅ **Checklist:**
- [ ] I understand the core concept.
- [ ] I have practiced writing C# code related to this topic.
- [ ] I can explain this topic without notes.

---
## 🔹 Redirect to another Controller Method 
If you want to redirect from one controller method to another, use RedirectToAction("<controllerMethodName>")

👨‍💻 **Code Example:**
```csharp
public class HomeController : Controller
{
    public ActionResult Index()
    {
        return RedirectToAction("Contact");
    }
    public ActionResult Contact()
    {
        return View();
    }
}

```

📌 **Key Takeaways:**
- `RedirectToAction()` allows to redirect from one controller method to another
- Controller methods are sometimes called `actions`
- The URL is tied to the `action` (controller method) NOT the `view` with same name
- returning a diff view will only retrieve and render the .cshtml file and maintain the same URL address of the current `action`
- View() returns the default view of the current action method 

🔄 **Active Recall Questions:**
1. What method allows to redirect from one ctronller method to another?
2. The URL is tied to the controller method or view? Explain.
3. Does the returning a diff view other than default within a controller method change the url?
4. What does view() return?

🔗 **Related Hands-On Project:**
- 📂  View Full Implementation in Projects Folder

✅ **Checklist:**
- [ ] I understand the core concept.
- [ ] I have practiced writing C# code related to this topic.
- [ ] I can explain this topic without notes.

---
## 🔹 Throw a new Exception from a Controller Action
Just demoing how the view changes when you explicitly throw an exception

👨‍💻 **Code Example:**
```csharp
public class HomeController : Controller
{
    public ActionResult Index()
    {
        throw new Exception("Invalid Page");
        return View();
    }
}

```

📌 **Key Takeaways:**
- throw new Exception() renders an error page instead of the default view()

🔄 **Active Recall Questions:**
1. Code to return a new Exception.

🔗 **Related Hands-On Project:**
- 📂  View Full Implementation in Projects Folder

✅ **Checklist:**
- [ ] I understand the core concept.
- [ ] I have practiced writing C# code related to this topic.
- [ ] I can explain this topic without notes.

---
## 🔹 Give Controller Methods Parameters
You can pass arguments to Controller methods by defining parameters

👨‍💻 **Code Example:**
```csharp
public class HomeController : Controller
{
    public ActionResult Contact(int id=0) // default param 0
    {
        ViewBag.Message = id; // assign this var to the passed param value

        return View();
    }
}
----
// Can display, render, or operate on that argument
// Contact.cshtml
@ViewBag.Message

```

📌 **Key Takeaways:**
- Can add parameters to pass in user data to then use for operations inside a controller

🔄 **Active Recall Questions:**
1. how to pass data to controller methods?

🔗 **Related Hands-On Project:**
- 📂  View Full Implementation in Projects Folder

✅ **Checklist:**
- [ ] I understand the core concept.
- [ ] I have practiced writing C# code related to this topic.
- [ ] I can explain this topic without notes.

---
## 🔹 Models in MVC web apps
Models folder hold .cs files each representing a Model/object. Any object that model the thing your app interacts with.

👨‍💻 **Code Example:**
```csharp
// This example demos how anything passed into the View() is considered a Model
// Index.cshtml // 
@model IntroToMVC.Models.User

<h1>
    @Model.Id
</h1>
<h1>
    @Model.FirstName
</h1>
<h1>
    @Model.LastName
</h1>
<h1>
    @Model.Age
</h1>

---
// HomeController.cs //
public class HomeController : Controller
{
    public ActionResult Index()
    {
        User user = new User();
        user.Id = 1;
        user.FirstName = "Kevin";
        user.LastName = "Montano";
        user.Age = 32;
        return View(user);
    }
}
---
// User Model //
namespace IntroToMVC.Models
{
    public class User
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int Age { get; set; }
    }
}
```

📌 **Key Takeaways:**
- A `Model` is an object of your app
- Often a `Model` matches a db table entities
- Whatever you pass into the `View()` is considered a `Model` by the MVC app
- You can access your passed data via the `Model` keyword and using `@` razor syntax

🔄 **Active Recall Questions:**
1. how to pass data to controller methods?

🔗 **Related Hands-On Project:**
- 📂  View Full Implementation in Projects Folder

✅ **Checklist:**
- [ ] I understand the core concept.
- [ ] I have practiced writing C# code related to this topic.
- [ ] I can explain this topic without notes.

---
## 🔹 NUGET
A Microsoft supported mechanism for sharing libraries and packages of code for .NET framework and .NET Core.

📌 **Key Takeaways:**
- `Nuget` is package manager that defines how packages for .NET are created, hosted, and shared
- A `Nuget package` is a single zipped file that contains compiles code, DLLs, any other files related to that code, and a manifest
- A `manifest` is a descriptive document. In a `Nuget package`, it contains metadata like the packages' version number
- Devs can share code by creating and publishing a `Nuget package` that other devs can add to their own projects and use the code within these packages

🔄 **Active Recall Questions:**
1. 

🔗 **Related Hands-On Project:**
- 📂  View Full Implementation in Projects Folder

✅ **Checklist:**
- [ ] I understand the core concept.
- [ ] I have practiced writing C# code related to this topic.
- [ ] I can explain this topic without notes.

---
## 🔹 _Layout.cshtml
This `.cshtml` `view` file defines the theme applied to every page of your web app

👨‍💻 **Code Example:**
```csharp
@Scripts.Render("~/bundles/jquery")
@Scripts.Render("~/bundles/bootstrap")
@RenderSection("scripts", required: false)
```

📌 **Key Takeaways:**
- `_Layout.cshtml` is a file containing the main theme applied accoss all of your web app
- It is a `view` in the `Shared` folder
- `@Styles.Render` map to dependecies found the in the `Content` folder and described in a file called `BundleConfig.cs` in the `App_Start` folder
- `@RenderSection("scripts", required: false)` allows to to apply certain dependencies if a `view` needs it
-`@RenderSection()` is applied after `@Scripts.Render()` because MVC may need to upload main dependencies that the unrequired dependencies depend upon 

🔄 **Active Recall Questions:**
1. 

🔗 **Related Hands-On Project:**
- 📂  View Full Implementation in Projects Folder

✅ **Checklist:**
- [ ] I understand the core concept.
- [ ] I have practiced writing C# code related to this topic.
- [ ] I can explain this topic without notes.

---
## 🔹 Model Binding in MVC Web APP
Submit data to serve and how MVC how to map data from a `view` to a `controller`

👨‍💻 **Code Example:**
```csharp
/*
HomeController.cs 
*/

[HttpPost] // Best practice: always tag your controller methods that use the POST method
// Model Binding is how MVC intelligently maps your Controller's parameters to incoming data from the View
// Here, each parameter corresponds to the name atttribute of each input element on a html form in the view
public ActionResult SignUp(string FirstName, string LastName, string EmailAddress)
{

    return null; // temporary placeholder
}

/*
Index.cshtml
*/

<div class="row no-gutters m-3">
    <div class="card col-sm-12 col-md-10 col-lg-6 mx-auto shadow">
        <div class="card-header text-center">
            <h5 class="m-0">Sign up to our newsletter</h5>
        </div>
        <div class="card-body">
            @using (Html.BeginForm("SignUp", "Home", FormMethod.Post))
            {
                <div class="row no-gutters">
                    <div class="form-group col-md-12">
                        <input name="FirstName" type="text" class="form-control" placeholder="First Name"/>
                    </div>
                    <div class="form-group col-md-12">
                        <input name="LastName" type="text" class="form-control" placeholder="Last Name"/>
                    </div>
                    <div class="form-group col-md-12">
                        <input name="EmailAddress" type="email" class="form-control" placeholder="Email Address"/>
                    </div>
                    <button type="submit" class="btn btn-block btn-primary">Submit</button>
                </div>
            }
        </div>
    </div>
</div>
```

📌 **Key Takeaways:**
- `Model Binding` is the way MVC knows how to map data between your `View` and `Controller`
- Always tag `Contoller methods` with `[HttpPost]` to denote a POST controller method
- The parameters in the `controller method` must match exactly as the `name attribute` of a input element of a form element for MVC to properly Model bind the data
- `null` can be used as a placeholder for returning an accetable type of `ActionResult`

🔄 **Active Recall Questions:**
1. 

🔗 **Related Hands-On Project:**
- 📂  View Full Implementation in Projects Folder

✅ **Checklist:**
- [ ] I understand the core concept.
- [ ] I have practiced writing C# code related to this topic.
- [ ] I can explain this topic without notes.

---
## 🔹 ViewModels to limit data passed to the View
It is a best practice to send only necesary data to the `View`

📌 **Key Takeaways:**
- it is considered best practice where the `Model` maps exactly to the DB table, pull in fully populated Models, then pass only data you need to ViewModel then ViewModel to the View

🔄 **Active Recall Questions:**
1. What is a brest pracitce of a ViewModel?

🔗 **Related Hands-On Project:**
- 📂  View Full Implementation in Projects Folder

✅ **Checklist:**
- [ ] I understand the core concept.
- [ ] I have practiced writing C# code related to this topic.
- [ ] I can explain this topic without notes.

---
## 🔹 Refactoring Code
Imporivng your programs code

📌 **Key Takeaways:**
- `Refactor` means to rewrite code to improve its structure, readability without chaninging its behavior
- EG: streamlining code, cleanin it up, making it more concise

🔄 **Active Recall Questions:**
1. What does it mean to `refactor` code?

🔗 **Related Hands-On Project:**
- 📂  View Full Implementation in Projects Folder

✅ **Checklist:**
- [ ] I understand the core concept.
- [ ] I have practiced writing C# code related to this topic.
- [ ] I can explain this topic without notes.

---
## 🔹 Production Code
The code that is the 'final' product of your app and is live for users to use

📌 **Key Takeaways:**
- `Production Code` means code that users are interacting with.
- `Refactoring code` is done to the `Production Code` then re-released


🔄 **Active Recall Questions:**
1. What does `Production code` mean?
2. What code get refactored?

🔗 **Related Hands-On Project:**
- 📂  View Full Implementation in Projects Folder

✅ **Checklist:**
- [ ] I understand the core concept.
- [ ] I have practiced writing C# code related to this topic.
- [ ] I can explain this topic without notes.

---
## 🔹 Quality Assurance (QA)
ensuring code is up to standard

📌 **Key Takeaways:**
- `QA` means ensuring code is up to standard
- Main component of `QA` is testing code
- `Testing code` is the process of putting software through various tesets to attempt to locate bugs that need to be fixed
- There is `QA software` that can automate testing code and provide detailed reports of potential issues

🔄 **Active Recall Questions:**
1. What does `QA` mean?
2. What is the main component of `QA`?
3. What does testing code mean?
4. What does `QA software` do?

🔗 **Related Hands-On Project:**
- 📂  View Full Implementation in Projects Folder

✅ **Checklist:**
- [ ] I understand the core concept.
- [ ] I have practiced writing C# code related to this topic.
- [ ] I can explain this topic without notes.

---
## 🔹 Popular Methods of Testing
Acceptance testing and unit testing.

📌 **Key Takeaways:**
- `Acceptance testing` a for of QA that tests software if it complies with the project requirements.
- The purpose is to determine where or not the software is ready for delivery/prod
-`Unit testing` is a way of testing individual units of code instead of the entire software
- `Units of code` are categorized by setting related code sections of a program together and running them through tests
- A `Unit` is the smallest testable element in your code
- A `Unit Test` is a short program that checks the result of and tests VARIOUS units of code
- These tests help detect when code is no longer working as originally intended when that code is refactored
- `Usability testing` tests how easily software can be utilized by users


🔄 **Active Recall Questions:**
1. What does `QA` mean?
2. What is the main component of `QA`?
3. What does testing code mean?
4. What does `QA software` do?

🔗 **Related Hands-On Project:**
- 📂  View Full Implementation in Projects Folder

✅ **Checklist:**
- [ ] I understand the core concept.
- [ ] I have practiced writing C# code related to this topic.
- [ ] I can explain this topic without notes.

---
## 🔹 Designing a Unit Test
Main points of the concept of a unit test

📌 **Key Takeaways:**
- `Pattern of desiging a unit test`: 
1. `Arrange` the conditions for that `unit` to a control enviroment
2. `Act` call method and know the outcome or expectations
3. `Assert` which checks whether you got what you expected
- It is best to use Mock objects instead of objects whose data is in a db as it is no longer constant and controlled data and can fail a unit test

🔄 **Active Recall Questions:**
1. What are the three A's of the pattern of desigining a unit test?
2. Why use Mock objects in unit tests?

🔗 **Related Hands-On Project:**
- 📂  View Full Implementation in Projects Folder

✅ **Checklist:**
- [ ] I understand the core concept.
- [ ] I have practiced writing C# code related to this topic.
- [ ] I can explain this topic without notes.

---
## 🔹 Object Relational Mapping


📌 **Key Takeaways:**
- `Mapping` is the creation of a system that connects one thing with another
- `Object Relational Mapping` is a program that maps between objects in a program and tables in a database
- abbreviated as `O/RM`
- 

🔄 **Active Recall Questions:**
1. 

🔗 **Related Hands-On Project:**
- 📂  View Full Implementation in Projects Folder

✅ **Checklist:**
- [ ] I understand the core concept.
- [ ] I have practiced writing C# code related to this topic.
- [ ] I can explain this topic without notes.

---