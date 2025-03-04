﻿using System;
using System.IO;
using Casino;
using Casino.TwentyOne;
using System.Data.SqlClient;

namespace TwentyOne
{
    internal class Program
    {
        string connectionString = "Server=(localdb)\\MSSQLLocalDB;Database=MyDatabase;Trusted_Connection=True;";

        // Entrance point of this console app
        static void Main(string[] args)
        {
            // print welcome message
            Console.WriteLine("Welcome to the Grand Hotel and Casino." +
                "Let's start by telling me your name:");

            // Take in and store user inpiut
            string playerName = Console.ReadLine();

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
                using (StreamWriter file = new StreamWriter(@"C:\Users\kevinmontano\log.txt", true))
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
                    catch (FraudException)
                    {
                        Console.WriteLine("Security! Kick this person out!");
                        Console.ReadLine();
                        return;
                    }
                    catch (Exception)
                    {
                        Console.WriteLine("An error occurred. Please contact your System Administrator.");
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
    }
}
