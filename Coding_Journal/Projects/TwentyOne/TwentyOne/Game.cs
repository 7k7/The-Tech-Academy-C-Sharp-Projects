using System;
using System.Collections.Generic;

namespace TwentyOne
{
    public abstract class Game
    {
        // private fields
        // Intialize each as a new List/Dictionary
        private List<Player> _players = new List<Player>();
        private Dictionary<Player, int> _bets = new Dictionary<Player, int>();
        // Inherency example //
        // Programming practice: design towards abstraction
        // The more generic your code is, the more features you can add later
        // To resuse this class with another type of game
        // Build this game with properties and behaviors that all games
        // have in common

        // Like players
        public List<Player> Players
        {
            get { return _players; }
            set { _players = value; }
        }

        // Game name
        public string Name { get; set; }

        // Bets
        public Dictionary<Player, int> Bets  // list of key-value pairs
        {
            get { return _bets; }
            set { _bets = value; }
        }

        // abstract method
        // All type of games have a play method
        public abstract void Play();

        // A method that prints a list of players
        public virtual void ListPlayers()
        {
            foreach (Player player in Players)
            {
                Console.WriteLine(player.Name);
            }
        }
    }
}
