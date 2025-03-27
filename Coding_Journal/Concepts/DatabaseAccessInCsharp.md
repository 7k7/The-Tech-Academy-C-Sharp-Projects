# Database Access in Csharp

**Overview**
ADO.net is part of Base CLass Class
It is an abstraction layer for communicating with a database.
Allows to write SQL queries in Csharp program
and execute them in the target database 
and return results back to the program

---
## 🔹 ADO.NET: What is it?

📌 **Key Takeaways:**
- ADO.NET stands for ActiveX Data Objects for .NET
- `ADO.NET` is a data access technology in Csharp
- It allows apps to connect to databases and perform crud ops
- Execute SQL commands inside Csharp apps
- Works with multiple dbs: SQL Server, MySQL, SQLite, Oracle and other
- Useful cause its lightweight and fast as it uses direct database connections

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
## 🔹 Creating a DB with SQL Server Object Explorer
This is a built-in widget inside VS. Allows to have a DB for your app.

👨‍💻 **Code Example:**
```csharp
Open SQL Server Object Explorer in the View menu
Open a localdb
Right-click on the <Databases> and click on "Add New Database"
Name it as your project/app
```

📌 **Key Takeaways:**
- Build a local db for your app

🔄 **Active Recall Questions:**
1. What is SQL Server Object Explorer?
2. What are the general steps to creating a local db?

🔗 **Related Hands-On Project:**
- 📂  View Full Implementation in Projects Folder

✅ **Checklist:**
- [ ] I understand the core concept.
- [ ] I have practiced writing C# code related to this topic.
- [ ] I can explain this topic without notes.

---
## 🔹 Creating a Table with SQL Server Object Explorer
Now create a table within your local database for your app.

👨‍💻 **Code Example:**
```csharp
Open SQL Server Object Explorer in the View menu
Open a localdb
Click on the <Databases>
Expand your local database folder
Right-click on <Tables> and Add new table
The Designer will pop up to allow you to create it
```

📌 **Key Takeaways:**
- Create a table in your local db for your app.
- Design your table in the Designer, which will create a script of it.
- Run the script that creates the table.

🔄 **Active Recall Questions:**
1. What is SQL Server Object Explorer?
2. What are the general steps to creating a table?
3. What does the Designer do?
4. What to run after dsigning your table?

🔗 **Related Hands-On Project:**
- 📂  View Full Implementation in Projects Folder

✅ **Checklist:**
- [ ] I understand the core concept.
- [ ] I have practiced writing C# code related to this topic.
- [ ] I can explain this topic without notes.

---
## 🔹 Creating a Database
Usually large apps have a logging database table 
to keep a record of exceptions.
If a customer/user complains about a bug, look up this db

👨‍💻 **Code Example:**
```csharp
Creating a db table for logging exceptions ECAMPLE:
4-column table
1. ID - type int (primary key) - autoincrement by 1 every time a new ENTRY is added
2. ExceptionType - type varchar(50) - The type of Exceptoin
3. ExceptionMessage - type varchar(200) - The error message itself
4. TimeStamp - type datetime - The specifc date and time the exception occurred

RUN the script the Designer created out of the db table by clicking on <Update>
Then click <Updatea Database>

Rename a table by right-clicking on it under the <Tables> folder
Update the script 

View it by right-clicking on <table> and <view data>
```

📌 **Key Takeaways:**
- Use SQL Server Object Explorer to create a DB, design a table, and run the scipt
- Use the Designer to create the columns in your table
- Make sure your primary key increments and is the ID of each entry
- After creating table, run script by <Update>
- View table by right-clicking on it and <view data>

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
## 🔹 Real-world use: log to database each exception
This example shows a private method in the main program that
holds the logic of logging exceptions to the database

👨‍💻 **Code Example:**
```csharp
// This private method in main, 'UpdateDbWithException'.
// Pass in Exception object type to log it to the database;
// This is use of polymorphism as this datatype covers all types of Exceptions
// Place method calls to private method in each catch block

private static void UpdateDBWithException(Exception ex)
{
    // CONNECTION STRING //
    // This long string references the database instance to CONNECT to.
    // It is found within the properties of that datatbase
    // Use '@' before the string to 'override' all escape chars like the backslash.
    // which means it will read the backslash as just a backslash.
    string connectionString = @"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=TwentyOneGame;" + 
                                "Integrated Security=True;Connect Timeout=30;Encrypt=False;" +
                                "TrustServerCertificate=False;ApplicationIntent=ReadWrite;" +
                                "MultiSubnetFailover=False";

    // QUERY STRING //
    // This is the SQL query 
    // What it does: insert this entry into table Exceptions
    // COLUMN NAMES: (ExceptionType, ExceptionMessage, TimeStamp)
    // VALUES that go into COLUMNS specified come from the Exception argument
    // Best practice: use parameterized queries to protect your database from SQL injection attacks
    // It verfies the user/data that the data is the expected data type.
    string queryString = @"INSERT INTO Exceptions (ExceptionType, ExceptionMessage, TimeStamp) VALUES
                            (@ExceptionType, @ExceptionMessage, @TimeStamp)";

    // USING STATEMENT // 
    // Helps control unmanaged resources/code
    // Unmanaged resoureces = When accessing resources outside of the CLR
    // Solution: Open connection then CLOSE it
    // 'Using' is a shorthand solution for this. Automatically closes after code block is done executing
    // SQL connection is a connection to an external database (unmanaged)
    // Instantiate SQL connectoin with the connection string var
    using (SqlConnection connection = new SqlConnection(connectionString))
        // Inside this code block is where we operate within this external database connection
    {
        // Create SQL command of type SqlCommand // 
        // Pass in query and SQL connection
        SqlCommand command = new SqlCommand(queryString, connection);

        // Add data type to each parameter in the query//
        // Parameters is a List in the command where you add the type of each parameter
        // This PROTECTs your database from SQL Injection
        command.Parameters.Add("@ExceptionType", SqlDbType.VarChar);
        command.Parameters.Add("@ExceptionMessage", SqlDbType.VarChar);
        command.Parameters.Add("@TimeStamp", SqlDbType.DateTime);

        // Now add actual parameter values to the command //
        // Add the values to the each parameters in Parameters List
        command.Parameters["@ExceptionType"].Value = ex.GetType().ToString();
        command.Parameters["@ExceptionMessage"].Value = ex.Message;
        command.Parameters["@TimeStamp"].Value = DateTime.Now.ToString();

        // OPEN CONNECTION //
        // Send this command to the database
        connection.Open();
        // EXECUTE COMMAND //
        // a non query is an insert
        command.ExecuteNonQuery();
        // CLOSE CONNECTION //
        connection.Close();

    }
}

-------------------

while (player.isActivelyPlaying && player.Balance > 0)
{
    try
    {
        game.Play();
    }

    // CALL UpdateDbWithException() IN EACH EXCEPTION CATCH //
    // ex is the var name of the Exception object
    // This way, we can pass it as an argument
    catch (FraudException ex)
    {
        Console.WriteLine(ex.Message);
        UpdateDbWithException(ex);
        Console.ReadLine();
        return;
    }
    catch (Exception ex)
    {
        Console.WriteLine("An error occurred. Please contact your System Administrator.");
        UpdateDbWithException(ex);
        Console.ReadLine();
        return;
    }
    
}

```

📌 **Key Takeaways:**
- Connect to a specific database instance via a its 'connection string'
- A query string is a query to the database
- Using parameterized queries helps protect from SQL Injection attacks
- using statement manages the connection to external, unmanaged resources/code
- A SQL command object holds both SQL connection instance, made from connection string,
and the query itself, from the query string.
- Add data types and values of each parameter in the parameterized query
- Execute SQL command by opening connection, then executing command, finally close connection


🔄 **Active Recall Questions:**
1. What string is used to connection to a database?
2. What does a query string contain?
3. What type of query protects from SQL injection
4. What statment manages connections to external resources?
5. What two things are passed in to a SQL command?
6. How to properly pass in the actual values of each parameter?
7. How to execute a SQL command (within a connection)?

🔗 **Related Hands-On Project:**
- 📂  View Full Implementation in Projects Folder

✅ **Checklist:**
- [ ] I understand the core concept.
- [ ] I have practiced writing C# code related to this topic.
- [ ] I can explain this topic without notes.

---
## 🔹 Mapping a Class to a DB
Create a class whose properties match well with the column data types of a db table.
Each entry in DB is an object of this class.
👨‍💻 **Code Example:**
```csharp
// A Database class object //
// each property matches each column to a db table
public class ExceptionEntity
{
    public int Id {get; set;}
    public string ExceptionType {get; set;}
    public string ExceptionMessage {get; set;}
    public DateTime TimeStamp {get; set;}
}

// Query DB for all ExceptionEntity objects and display them //
// When you enter 'admin' as user name, all exceptions will be displayed
if (playerName.ToLower() == "admin")
{
    List<ExceptionEntity> Exceptions = ReadExceptions();
    foreach (var exception in Exceptions)
    {
        Console.Write(exception.Id + " | ");
        Console.Write(exception.ExceptionType + " | ");
        Console.WriteLine(exception.ExceptionMessage + " | ");
        Console.WriteLine(exception.TimeStamp + " | ");
        Console.WriteLine();
    }
    Console.ReadLine();
    return;
}

// QUERY THE DB FOR ALL EXCEPTIONS //
// Returns a list of all db entries as objects of type ExceptionEntity
private static List<ExceptionEntity> ReadExceptions()
{
    // App.CONFIG is usually where you can find this connection string and just call it via a method
    // because throughout the program development, this string can change and it is tedious to 
    // have to change it manually everywhere.
    string connectionString = @"Data Source=(localdb)\ProjectModels;Initial Catalog=TwentyOneGame;" +
                                "Integrated Security=True;Connect Timeout=30;Encrypt=False;" +
                                "TrustServerCertificate=False;ApplicationIntent=ReadWrite;" +
                                "MultiSubnetFailover=False";

    // query string
    string queryString = @"Select Id, ExceptionType, ExceptionMessage, TimeStamp From ExceptionsLog";

    // Declare the List var to return
    List<ExceptionEntity> Exceptions = new List<ExceptionEntity>();

    // Begin connection to db
    using (SqlConnection connection = new SqlConnection(connectionString))
    {
        SqlCommand command = new SqlCommand(queryString, connection);

        // open connection
        connection.Open();

        // Execute a reader and assign to reader object
        SqlDataReader reader = command.ExecuteReader();
        
        // reader.Read() iterates through each entry/record of queried db table
        // Each record is in SQL format
        while (reader.Read())
        {
            // create a new ExceptionEntity instance for each record
            ExceptionEntity exception = new ExceptionEntity();
            // convert the sql record to the appropiate data type
            // and add it to its ExceptionEntity instance
            exception.Id = Convert.ToInt32(reader["Id"]);
            exception.ExceptionType = reader["ExceptionType"].ToString();
            exception.ExceptionMessage = reader["ExceptionMessage"].ToString();
            exception.TimeStamp = Convert.ToDateTime(reader["TimeStamp"]);

            // Once populated the properities of exception instance, 
            // add to list
            Exceptions.Add(exception);
        }

        // close connection
        connection.Close();
    }

    // return the List of exceptions from db
    return Exceptions;
}
```

📌 **Key Takeaways:**
- A class refered as an Entity means that class maps perfectly to a db table;
As in each of its properties map to a column in a db table
- 'Select' is the query keyword to query records from a db table
- Specifcy columns separated by commas
- 'From' query keyword specifies the db table name
- SqlCommand.ExecuteReader() return a SqlDataReader object which is used to 
read records in a db table via the Read()
- SqlDataReader.Read() iterates through a db table, getting each record and returns
'false' when there are no more. 
- Every record from the Read() is in Sql format, must cast to the data type of that column
- Always close connection with Close()
- best practice: Keep ConnectionString at the TOP of all Controller methods for reusability


🔄 **Active Recall Questions:**
1. What keyword means 'a db class object whose properties map to each db table column'?
2. What query keyword queries a db table for records?
3. How are columns to be retrieved speecified in a query?
4. What is the 'From' keyword
5. What method in the SqlDataReader is used to retrieve each record in a db?
6. When does SqlDataReader.Read() return 'false'?
7. In what format is every record returned from the Read()?
8. After you finish operating within a connectoin, what should you do?
9. What is a best practice of resuing Connection String vars?

🔗 **Related Hands-On Project:**
- 📂  View Full Implementation in Projects Folder

✅ **Checklist:**
- [ ] I understand the core concept.
- [ ] I have practiced writing C# code related to this topic.
- [ ] I can explain this topic without notes.

---
## 🔹 LINQ

📌 **Key Takeaways:**
- Stands for 'Language-Integrated Query'
- part of .NET Framwork since version 3.5
- Used with Csharp to query different data sources
- LINQ queries returns results as objects which facilitates their use in OOP

🔄 **Active Recall Questions:**
1. What does it stand for?
2. part of what framework?
3. With what programming language is it used with?
4. What is the main purpose?
5. What data type is the results of LINQ queries?

🔗 **Related Hands-On Project:**
- 📂  View Full Implementation in Projects Folder

✅ **Checklist:**
- [ ] I understand the core concept.
- [ ] I have practiced writing C# code related to this topic.
- [ ] I can explain this topic without notes.

---
## 🔹 LINQ SYNTAX

👨‍💻 **Code Example:**
```csharp
using System;
using System.Collections.Generic;
using System.Linq; // provides classes and interface that support queries that use LINQ

namespace Linq_Example
{
    class Program
    {
        static void Main()
        {
            // Specify the data source
            string[] students = new string[] 
            { "Lacey", "Trisha", "Gavin", "Josh", "John" };

            // Define the query expression
            // query must be stored in a var that the object can be returned to
            IEnumerable<string> studentQuery =  
            from student in students
            where student.Length >= 6
            select student;

            // Execute the query
            // print the query results 
            foreach (string s in studentQuery)
            {
                Console.Write(s + " ");
            }
            Console.ReadLine();
        }
    }
}
```

📌 **Key Takeaways:**
- A 'query' is a set of instructions that define what data to retrieve
and what that data should look like when it is returned
- LINQ query operations conist of 3 actions:
1. Obtain the data source
2. Create the query
3. Execute the query
- A LINQ query is made of clauses
- The 'From' clause marks the beginning of a LINQ Query
- The 'Group' or 'Select' clause marks the end of a LINQ query
- In between the beginning and end clauses, there can be many other different clauses

🔄 **Active Recall Questions:**
1. What is query?
2. What 3 actions does a LINQ query operation consist of?
3. What makes the syntax of a LINQ query?
4. What is the beginning and end of a LINQ query?
5. What is in between the beggiining and end of a LINQ query?

🔗 **Related Hands-On Project:**
- 📂  View Full Implementation in Projects Folder

✅ **Checklist:**
- [ ] I understand the core concept.
- [ ] I have practiced writing C# code related to this topic.
- [ ] I can explain this topic without notes.