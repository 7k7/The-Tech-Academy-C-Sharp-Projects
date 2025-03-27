using System;
using System.Collections.Generic;
using System.Linq;
using Casino.Interfaces;

namespace Casino.TwentyOne
{
    public class TwentyOneGame : Game, IWalkAway
    {
        // Dealer
        public TwentyOneDealer Dealer { get; set; }
        public override void Play() // This is one hand of the game TwentyOne
        {
            Dealer = new TwentyOneDealer(); // Instantiate a Dealer object as A TwentyOneDealer
            foreach (Player player in Players) // Reset players 
            {
                player.Hand = new List<Card>(); // hand should be blank
                player.Stay = false;
            }
            Dealer.Hand = new List<Card>(); // Dealers hand should be blank
            Dealer.Stay = false;
            Dealer.Deck = new Deck(); // new deck each time, each round
            Dealer.Deck.Shuffle(); // Shuffle cards
            // All Players make bets
            foreach (Player player in Players)
            {
                // Handle exceptions for wrong format input
                bool isValid = false;
                int bet = 0;
                while (!isValid)
                {
                    Console.WriteLine("Place your bet!");
                    isValid = int.TryParse(Console.ReadLine(), out bet);
                    if (!isValid) Console.WriteLine("Please enter digits only, no decimals.");
                }
                if (bet < 0)
                {
                    // The string argument is the 'Message' parameter passed to the constructor
                    throw new FraudException("Security! Kick this person out.");
                }
                bool successfullyBet = player.Bet(bet); // check if enough balance to place bet
                if (!successfullyBet)
                {
                    return; // exits out of Play()
                }
                Bets[player] = bet; // Add an index of the player and their bet
            }

            // Deal cards //
            for (int i = 0; i < 2; i++)
            {
                Console.WriteLine("Dealing....");
                // After the second card deal, check if blackjack
                foreach (Player player in Players)
                {
                    Console.Write("{0}: ", player.Name);
                    Dealer.Deal(player.Hand);
                    if (i == 1) // if this is the second card deal
                    {
                        bool blackjack = TwentyOneRules.CheckForBlackJack(player.Hand);
                        if (blackjack)
                        {
                            Console.WriteLine("Blakcjack! {0} wins {1}", player.Name, Bets[player]);
                            player.Balance += Convert.ToInt32((Bets[player] * 1.5) + Bets[player]);
                            return;
                        }
                    }
                }
                // The dealers' turn:
                Console.WriteLine("Dealer: ");
                // Deal the dealers hand
                Dealer.Deal(Dealer.Hand);
                // After the second card deal, check if blackjack
                if (i == 1)
                {
                    bool blackJack = TwentyOneRules.CheckForBlackJack(Dealer.Hand);
                    if (blackJack)
                    {
                        Console.WriteLine("Dealer has BlackJack! Everyone loses!");
                        foreach (KeyValuePair<Player, int> entry in Bets)
                        {
                            Dealer.Balance += entry.Value;
                        }
                        return;
                    }
                }

            }
            // Ask players if they want to bust or stay //
            foreach (Player player in Players)
            {
                while(!player.Stay)
                {
                    Console.WriteLine("Your cards are: ");
                    foreach (Card card in player.Hand)
                    {
                        Console.Write("{0} ", card.ToString());
                    }
                    Console.WriteLine("\n\nHit or stay?");
                    // take in response and check 
                    string answer = Console.ReadLine().ToLower();
                    if (answer == "stay")
                    {
                        player.Stay = true;
                        break;
                    }
                    else if (answer == "hit")
                    {
                        Dealer.Deal(player.Hand);
                    }
                    bool busted = TwentyOneRules.IsBusted(player.Hand);
                    if (busted)
                    {
                        Dealer.Balance += Bets[player];
                        Console.WriteLine("{0} Busted! You lose your bet of {1}. Your balance: {2}", 
                            player.Name, Bets[player], player.Balance);
                        Console.WriteLine("Do you want to play again?");
                        answer = Console.ReadLine().ToLower();
                        if (answer == "yes" || answer == "yeah")
                        {
                            player.isActivelyPlaying = true;
                        }
                        else
                        {
                            player.isActivelyPlaying = false;
                        }
                    }
                }
            }
            // check if dealer busted
            Dealer.IsBusted = TwentyOneRules.IsBusted(Dealer.Hand);
            // is staying?
            Dealer.Stay = TwentyOneRules.ShouldDealerStay(Dealer.Hand);
            // As long as the Dealer 
            while (!Dealer.IsBusted && !Dealer.Stay)
            {
                Console.WriteLine("Dealer is hitting...");
                Dealer.Deal(Dealer.Hand);
                Dealer.IsBusted = TwentyOneRules.IsBusted(Dealer.Hand);
                Dealer.Stay = TwentyOneRules.ShouldDealerStay(Dealer.Hand);
            }
            if (Dealer.Stay)
            {
                Console.WriteLine("Dealer is staying..");

            }
            if (Dealer.IsBusted)
            {
                Console.WriteLine("Dealer busted!");
                foreach (KeyValuePair<Player, int> entry in Bets)
                {
                    Console.WriteLine("{0} won {1}!", entry.Key.Name, entry.Value);
                    Players.Where(x => x.Name == entry.Key.Name).First().Balance += (entry.Value * 2);
                    Dealer.Balance -= entry.Value;
                }
                return;
            }
            // Who won or tie?
            foreach (Player player in Players)
            {
                // compare player and deals' hand
                // true = player won , false = dealer won, null = tie
                bool? playerWon = TwentyOneRules.CompareHands(player.Hand, Dealer.Hand);
                // Check bool result; if no one won, push = tie
                if (playerWon == null)
                {
                    Console.WriteLine("Push! No one wins.");
                    // return bet to player
                    player.Balance += Bets[player];
                }
                else if (playerWon == true)
                {
                    Console.WriteLine("{0} won {1}!", player.Name, Bets[player]);
                    // pay player
                    player.Balance += (Bets[player] * 2);
                    // remove from dealer's balance
                    Dealer.Balance -= Bets[player];
                }
                else
                {
                    Console.WriteLine("Dealer wins {0}!", Bets[player]);
                    // Add to dealers' balance
                    Dealer.Balance += Bets[player];
                }
                // Ask player if they want to play again
                Console.WriteLine("Play again?");
                string answer = Console.ReadLine().ToLower();
                if (answer == "yes" || answer == "yeah")
                {
                    player.isActivelyPlaying = true;
                    return;
                }
                else
                {
                    player.isActivelyPlaying = false;
                    return;
                }
            }
        }
        public override void ListPlayers()
        {
            Console.WriteLine("21 Players:");
            base.ListPlayers();
        }
        public void WalkAway(Player player)
        {
            throw new NotImplementedException();
        }
    }
}
