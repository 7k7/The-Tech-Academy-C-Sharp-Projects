using System;
using System.IO;
using Casino;
using Casino.TwentyOne;
using System.Data.SqlClient;
using System.Data;
using System.Collections.Generic;
using System.Diagnostics;

namespace TwentyOne
{
    internal class Program
    {
        // Entrance point of this console app
        static void Main(string[] args)
        {
            // print welcome message
            Console.WriteLine("Welcome to the Grand Hotel and Casino." +
                "Let's start by telling me your name:");

            // Take in and store user inpiut
            string playerName = Console.ReadLine();

            // print out a log of exceptions
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

            bool validAnswer = false;
            int bank = 0;
            while (!validAnswer)
            {
                // Prompt user for money to play
                Console.WriteLine("And how much money did you bring today?");
                validAnswer = int.TryParse(Console.ReadLine(), out bank);
                if (!validAnswer) Console.WriteLine("Please enter digits only, no decimals.");
            }

            // Ask if user wants to play the game
            Console.WriteLine("Hello, {0}. Would you like to join a game of 21 right now?", playerName);

            // Take in response
            string answer = Console.ReadLine().ToLower();

            // Check answer if user said yes
            if (answer == "yes" || answer == "yeah" || answer == "y" || answer == "ya")
            {
                // Instance of player with the users' input data passed in
                Player player = new Player(playerName, bank);
                // assign id
                player.id = Guid.NewGuid();
                // log the player's guid
                using (StreamWriter file = new StreamWriter(@"C:\Users\user\Documents\GitHub\The-Tech-Academy-C-Sharp-Projects\Coding_Journal\Projects\TwentyOne\log.txt", true))
                {
                    file.WriteLine(player.id);
                }
                //Instance of Game of type TwentyOneGame
                Game game = new TwentyOneGame();
                // Add new Player instance to the Game's List<Player>
                // Using the overloaded operator+ (See Player class)
                game += player;
                // This property dictates whether a player wants to continue playing
                player.isActivelyPlaying = true;
                // This loop determines when to end the game
                // For as long as the Player wants to play
                // And their balance is greater than 0
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
                // Remove player from list of Players in the game TwentyOne
                // after they exist from while loop
                game -= player; // overloaded operator-
                                // Exit message
                Console.WriteLine("Thank you for playing!");
            }
            // Exit message: since user answered no or no longer actively playing or no money
            Console.WriteLine("Feel free to look around the casino. Bye for now.");
            // Prevent the console from closing immediately after the program finishes
            Console.Read();
        }

        // This private method in main, 'UpdateDbWithException'.
        // Pass in Exception object type to log it to the database;
        // This is use of polymorphism as this datatype covers all types of Exceptions
        // Place method calls to private method in each catch block

        private static void UpdateDbWithException(Exception ex)
        {
            // CONNECTION STRING //
            // This long string references the database instance to CONNECT to.
            // It is found within the properties of that datatbase
            // Use '@' before the string to 'override' all escape chars like the backslash.
            // which means it will read the backslash as just a backslash.
            string connectionString = @"Data Source=(localdb)\ProjectModels;Initial Catalog=TwentyOneGame;" + 
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
            string queryString = @"INSERT INTO ExceptionsLog (ExceptionType, ExceptionMessage, TimeStamp) VALUES
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
    }
}