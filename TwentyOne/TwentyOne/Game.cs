using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TwentyOne
{
    public class Game
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

        // A method that prints a list of players
        public void ListPlayers()
        {
            foreach (string player in Players)
            {
                Console.WriteLine(player);
            }
        }
    }
}
