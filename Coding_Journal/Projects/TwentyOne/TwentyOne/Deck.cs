using System;
using System.Collections.Generic;

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

        // Lets create a method that 'shuffles' a list of Cards in a Deck
        //public static Deck Shuffle(Deck deck)
        //{
        //    // create a temporary list
        //    List<Card> TempList = new List<Card>();

        //    // Random class object
        //    Random random = new Random();

        //    while (deck.Cards.Count > 0)
        //    {
        //        int randomIndex = random.Next(deck.Cards.Count);
        //        TempList.Add(deck.Cards[randomIndex]);
        //        deck.Cards.RemoveAt(randomIndex);
        //    }

        //    deck.Cards = TempList;
        //    return deck;
        //}

        // Method Overloading //
        // Can use he method name with different code blocks
        // Must follow some strict compiler rules
        // So the compiler knows which method to use 
        //public static Deck Shuffle(Deck deck, int times)
        //{
        //    for (int i = 0; i < times; i++)
        //    {
        //        deck = Shuffle(deck);
        //    }
        //    return deck;
        //}

        // Better alternative to oveloading methods //
        // What if a parameter can be optional? Default parameter
        // assign a default value to it
        // Also, add in an out parameter
        // Must be before any defult parametser
        public void Shuffle(int times = 1)
        {
            for (int i = 0; i < times; i++)
            { 
                // create a temporary list
                List<Card> TempList = new List<Card>();

                // Random class object
                Random random = new Random();

                while (Cards.Count > 0)
                {
                    int randomIndex = random.Next(Cards.Count);
                    TempList.Add(Cards[randomIndex]);
                    Cards.RemoveAt(randomIndex);
                }
                // 'this' is a keyword referring to itself, the object
                this.Cards = TempList;
            }
        }
    }
}
