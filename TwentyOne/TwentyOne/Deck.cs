using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TwentyOne
{
    public class Deck
    {
        // Constructors always go at the top of the class b4 props
        public Deck()
        {
            // Must instantiate property Cards inside 
            // constructor method to use it 
            Cards = new List<Card>();
            // A Better way //

            // There are 13 faces of cards in a deck
            // and each card has four suits = 52 cards total

            // For each face, must loop through it four times
            // becuase of the four suits
            // use a nested for loop or foreach loop

            // Create a list for all possible suits
            List<string> Suits = new List<string>()
            {
                "Clubs", "Hearts", "Diamonds", "Spades"
            };

            // Create list for all faces
            List<string> Faces = new List<string>()
            {
                "Two", "Three", "Four", "Five", "Six", "Seven",
                "Eight", "Nine", "Ten", "Jack", "Queen", "King", "Ace"
            };

            foreach (string face in Faces)
            {
                foreach (string suit in Suits)
                {
                    Card card = new Card();
                    card.Suit = suit;
                    card.Face = face;

                    Cards.Add(card);
                }
            }


            // One way: //

            //Cards = new List<Card>();
            //Card cardOne = new Card();
            //cardOne.Face = "Two";
            //cardOne.Suit = "Hearts";
            //Cards.Add(cardOne);

        }

        // Deck is a collection of cards
        // Could use array data type since a deck of cards is 52
        // but a List is easier to use
        public List<Card> Cards { get; set; }
    }
}
