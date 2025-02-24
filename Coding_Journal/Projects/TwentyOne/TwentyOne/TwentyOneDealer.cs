using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TwentyOne
{
    public class TwentyOneDealer : Dealer
    {
        // private property to initlize list Hand
        private List<Card> _hand = new List<Card>();
        public List<Card> Hand { get { return _hand; } set { _hand = value; } } // Dealer's own cards
        public bool Stay { get; set; } // If you feel like you are close to 21
        public bool IsBusted { get; set; } // If you go over 21
    }
}
