using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TwentyOne
{
    public class Player
    {
        // Constructor
        public Player(string name, int beginningBalance) // Pass in name and amount in bank
        {
            // Initializing the Hand property of type List<Card>
            Hand = new List<Card>();
            // Assigning each property to the passed in arguments
            Balance = beginningBalance;
            Name = name;
        }
        // Class properties

        // private property to initialize List hand
        private List<Card> _hand = new List<Card>();
        public List<Card> Hand { get { return _hand; } set { _hand = value; } }
        public int Balance { get; set; }
        public string Name { get; set; }
        public bool isActivelyPlaying { get; set; }
        public bool Stay { get; set; } // specific to twentyONe

        public bool Bet(int amount)
        {
            if (Balance - amount < 0)
            {
                Console.WriteLine("You do not have enough to place a bet that size.");
                return false;
            }
            else
            {
                Balance -= amount;
                return true;
            }
        }

        // overloaded operator methods //
        // for plus operator
        public static Game operator+ (Game game, Player player)
        {

            game.Players.Add(player);
            return game;
        }

        // subtract oiverload operator
        public static Game operator- (Game game, Player player)
        {
            game.Players.Remove(player);
            return game;
        }
    }
}
