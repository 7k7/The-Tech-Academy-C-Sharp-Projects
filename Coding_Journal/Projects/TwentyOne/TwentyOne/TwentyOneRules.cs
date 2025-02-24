using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TwentyOne
{
    public class TwentyOneRules
    {
        // Values of each Face
        private static Dictionary<Face, int> _cardValues = new Dictionary<Face, int>
        {
            [Face.Two] = 2,
            [Face.Three] = 3,
            [Face.Four] = 4,
            [Face.Five] = 5,
            [Face.Six] = 6,
            [Face.Seven] = 7,
            [Face.Eight] = 8,
            [Face.Nine] = 9,
            [Face.Ten] = 10,
            [Face.Jack] = 10,
            [Face.Queen] = 10,
            [Face.King] = 10,
            [Face.Ace] = 1 // A player decides what Ace worth: 1 or 11 
        };

        private static int[] GetAllPossibleHandValues(List<Card> Hand)
        {
            // how many aces in hand
            int aceCount = Hand.Count(x => x.Face == Face.Ace);

            // How many possible values?
            int[] result = new int[aceCount + 1];

            // when ace equals 1
            int value = Hand.Sum(x => _cardValues[x.Face]);
            // asign result to first index of result array
            result[0] = value;

            // If only one ace, then return
            if (result.Length == 1) return result;

            // if more than one ace in hand 
            for (int i = 1; i < result.Length; i++) // i = 1 to start at second index of result[]
            {
                value += (i * 10); // adds 10 to ace value (1)
                result[i] = value;
            }
            return result;
        }

        // This method checks if the player's hand contains a sum of 21/blackjack
        public static bool CheckForBlackJack(List<Card> Hand)
        {
            // Get all values
            int[] possibleValues = GetAllPossibleHandValues(Hand);
            // Get the largest value (largest possible is 22)
            int value = possibleValues.Max();
            // Blackjack = 21, true
            if (value == 21) return true;
            // if now, false
            else return false;
        }

        // busted>
        public static bool IsBusted(List<Card> Hand)
        {
            int value = GetAllPossibleHandValues(Hand).Min();
            if (value > 21) return true;
            else return false;
        }

        // Check if Dealer stays
        // Rule: If hand sum is 17 - 21, Deal should stay
        public static bool ShouldDealerStay(List<Card> Hand)
        {
            int[] possibleHandValues = GetAllPossibleHandValues(Hand);
            foreach (int value in possibleHandValues)
            {
                if (value > 16 && value < 22)
                {
                    return true;
                }
            }
            return false;
        }

        // Compare both player and dealer hands
        // Output: can be true, false, or null
        // meaning player won, dealer won, or tie
        public static bool? CompareHands(List<Card> PlayerHand, List<Card> DealerHand)
        {
            // get all possible results for player
            int[] playerResults = GetAllPossibleHandValues(PlayerHand);
            // all possible results for a dealer
            int[] dealerResults = GetAllPossibleHandValues(DealerHand);

            // Get the hightest value that is less than 22
            int playerScore = playerResults.Where(x => x < 22).Max();
            int dealerScore = dealerResults.Where(x => x < 22).Max();

            // Compare both hands
            if (playerScore > dealerScore) return true; // player won 
            else if (playerScore < dealerScore) return false; // dealer won
            else return null; // tie

        }
    }
}
