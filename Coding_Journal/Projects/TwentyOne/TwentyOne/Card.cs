using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TwentyOne
{
    // A class is a model; A design for an object
    // We instantiate objects of this class
    // and set the properties of it given in this class
    // Class is the cookie cutter and objects are the cookies
    public class Card
    {
        // Constructor = assigning default values to when instantiating
        // an object of this class
        // The constructor method name is always the name of the class
        //public Card()
        //{
        //    Suit = "Spades";
        //    Face = "Two";
        //}

        // Properties = state of an object
        // This object's properties should be independent 
        // from card game "21" to make independent and reusable
        // for any other card game


        // suit i.e. diamond or heart etc
        // Set object properties  because they don't do anything
        // Methods are for processing data

        // public makes this property accessable to other parts of the program
        // get and set are the only thigns that properties can do
        public Suit Suit { get; set; }

        // Face is the front of the card- numbers but
        // aces, kings, queens, jacks are not int 
        // so used string as data type
        public Face Face { get; set; }
    }

    // Enum
    public enum Suit
    {
        Clubs,
        Diamonds,
        Hearts,
        Spades
    }

    public enum Face
    {
        Two,
        Three,
        Four,
        Five,
        Six,
        Seven,
        Eight,
        Nine,
        Ten,
        Jack,
        Queen,
        King,
        Ace
    }
}
