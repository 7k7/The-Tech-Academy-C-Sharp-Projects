using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace TwentyOne
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Object state. 
            // Will create basic models for objects called CLASSES
            // Then give those objects properties.

            // Will use game of "21" to demonstrate these concepts

            // Card class

            // Must instantiate(create) a Card object 
            // Naming convention = camel case
            // Preferred way in C#
            //Card cardOne = new Card();
            //// Assign the Face property of this cardOne instance
            //cardOne.Face = "Queen";
            //// Anothre property assignment
            //cardOne.Suit = "Spades";

            //// Print to console
            //Console.WriteLine($"{cardOne.Face} of {cardOne.Suit}");



            // Now lets create a deck of cards using the Deck class //

            // Create object of data type Deck
            Deck deck = new Deck();

            // Suffled Deck of Cards //

            // Reassign deck to the returned Deck
            //deck = Shuffle(deck);

            // Out Parameter, must instatiate it here
            // to receive the output of it 
            int timesShuffled = 0;

            // A deck with an x amount of times to shuffle
            // named method, labels each parameter along with the arguments
            // it is for readability
            deck = Shuffle(deck: deck, out timesShuffled, times: 5);

            // it is an empty, new instance of Deck
            // Deck has a property called Cards of data type List<Card>
            // To assign this prop, must first instantiate it
            //deck.Cards = new List<Card>();

            //// Now add cards to this prop
            //deck.Cards.Add(cardOne);


            // Instead of adding cards one by one, create a constructor
            // for Deck class to have a List of cards by default //


            // Now every new Deck is instantiated with default property valuese 
            // In this case, the Deck Constructor method is creating a list of
            // Cards in the Deck
            foreach (Card card in deck.Cards)
            {
                Console.WriteLine(card.Face + " of " + card.Suit);
            }
            Console.WriteLine(deck.Cards.Count());
            // print out the OUT parameter
            Console.WriteLine("Times shuffled: {0}", timesShuffled);
            Console.ReadLine();

            // METHODS - composed of a 
            // Access modifier: gives its access scope
            // Return type: i.e. void = nothing, or Integer
            // May contain parameters or not
            // Methods have to be part of a class
            // If a method should be used without instantiating an object
            // of that same class, then it should be marked 'static'        }
        }

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
        public static Deck Shuffle(Deck deck, out int timesShuffled, int times = 1)
        {
            timesShuffled = 0;
            for (int i = 0; i < times; i++)
            {
                timesShuffled++;
                // create a temporary list
                List<Card> TempList = new List<Card>();

                // Random class object
                Random random = new Random();

                while (deck.Cards.Count > 0)
                {
                    int randomIndex = random.Next(deck.Cards.Count);
                    TempList.Add(deck.Cards[randomIndex]);
                    deck.Cards.RemoveAt(randomIndex);
                }
                deck.Cards = TempList;
            }
            return deck;
        }
    }
}
