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
            
            // loop trhogu each face
            // there are 13 of them
            for (int i = 0; i < 13; i++)
            {
                for (int j = 0; j < 4; j++)
                {
                    Card card = new Card();
                    // cast underlying value to its
                    // corresponding enumerator
                    card.Face = (Face)i;
                    card.Suit = (Suit)j;
                    Cards.Add(card);
                }
            }

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
