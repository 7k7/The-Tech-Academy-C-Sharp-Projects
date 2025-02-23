using System;
using System.Collections.Generic;
using System.Linq;

namespace TwentyOne
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            Deck deck = new Deck();

            //int count = deck.Cards.Count(x => x.Face == Face.Ace);
            //Console.WriteLine(count);

            //List<Card> newList = deck.Cards.Where(x => x.Face == Face.King).ToList();
            //foreach (Card card in newList)
            //{
            //    Console.WriteLine(card.Face);
            //}

            List<int> numberList = new List<int>() { 1, 2, 3, 535, 342, 23 };
            int sum = numberList.Sum(x => x + 5);
            int max = numberList.Max();
            int min = numberList.Min();
            Console.WriteLine(sum);
            Console.WriteLine(max);
            Console.WriteLine(min);

            // Filter Lists
            var greaterThan20 = numberList.Where(x => x > 20);  
            foreach (int number in greaterThan20)
            {
                Console.WriteLine(number);
            }

            // Chain LINQ methods
            // Filter numbers in list then calculate the sum
            int sumOfGreaterThen20List = numberList.Where(x => x > 20).Sum();
            Console.WriteLine(sumOfGreaterThen20List);
            
            //deck.Shuffle();

            //foreach (Card card in deck.Cards)
            //{
            //    Console.WriteLine(card.Face + " of " + card.Suit);
            //}
            //Console.WriteLine(deck.Cards.Count);
            Console.ReadLine();

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

            // another option - Object Initialization //
            //Card card = new Card() { Face = "King", Suit = "Spades" };

            //// Print to console
            //Console.WriteLine($"{cardOne.Face} of {cardOne.Suit}");



            // Now lets create a deck of cards using the Deck class //

            // Create object of data type Deck
            //Deck deck = new Deck();

            //// Suffled Deck of Cards //
            //deck.Shuffle();

            // Reassign deck to the returned Deck
            //deck = Shuffle(deck);

            // Out Parameter, must instatiate it here
            // to receive the output of it 
            //int timesShuffled = 0;

            // A deck with an x amount of times to shuffle
            // named method, labels each parameter along with the arguments
            // it is for readability
            //deck = Shuffle(deck: deck, out timesShuffled, times: 5);

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
            //foreach (Card card in deck.Cards)
            //{
            //    Console.WriteLine(card.Face + " of " + card.Suit);
            //}
            //Console.WriteLine(deck.Cards.Count());
            //// print out the OUT parameter
            ////Console.WriteLine("Times shuffled: {0}", timesShuffled);
            //Console.ReadLine();

            // METHODS - composed of a 
            // Access modifier: gives its access scope
            // Return type: i.e. void = nothing, or Integer
            // May contain parameters or not
            // Methods have to be part of a class
            // If a method should be used without instantiating an object
            // of that same class, then it should be marked 'static'        


            // TwentyOneGame method //

            //TwentyOneGame game = new TwentyOneGame();
            //game.Players = new List<string>() { "Jesse", "Bill", "Joe" };
            //game.ListPlayers();
            //game.Play();

            //Console.ReadLine();
        }
    }
}
