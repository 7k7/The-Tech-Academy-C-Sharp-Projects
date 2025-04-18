﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Casino
{
    public class Dealer
    {
        public string Name { get; set; }
        public Deck Deck { get; set; }
        public int Balance { get; set; }

        public void Deal(List<Card> Hand)
        {
            Hand.Add(Deck.Cards.First());
            // store card dealt 
            string card = string.Format(Deck.Cards.First().ToString() + "\n");
            Console.WriteLine(card);
            // logging to file each card being dealt in game
            // This appends to the file
            using (StreamWriter file = new StreamWriter(@"C:\Users\kevinmontano\log.txt", true))
            {
                file.WriteLine(DateTime.Now); // add current time
                file.WriteLine(card); 
            }
            Deck.Cards.RemoveAt(0);
        }
    }
}
