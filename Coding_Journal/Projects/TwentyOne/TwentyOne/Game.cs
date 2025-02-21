using System;
using System.Collections.Generic;

namespace TwentyOne
{
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

        // abstract method
        // All type of games have a play method
        public abstract void Play();

        // A method that prints a list of players
        public virtual void ListPlayers()
        {
            foreach (string player in Players)
            {
                Console.WriteLine(player);
            }
        }
    }
}
