using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TwentyOne
{
    public class Dealer
    {
        public string Name { get; set; }
        public Deck Deck { get; set; }
        public int Balance { get; set; }

        public void Deal(List<Card> Hand)
        {
            //NOTE: 'using System.Linq;' to use the integrated 'First()' method.
            //NOTE: What we are doing here is passing in a 'Deck' of 'Cards' (property of Deck), then getting the 
            //      first card in that list ( using 'First()' ), then adding it to the 'Hand' (which is a list of cards)  
            //	    that was passed in, in the 'Deal' method.
            Hand.Add(Deck.Cards.First());

            //NOTE: This line is done so that the player can see the card on the console.
            Console.WriteLine(Deck.Cards.First().ToString() + "\n");

            //NOTE: The line below removes the card from the deck, at index 0 ('RemoveAt' is an integrated method for lists).
            Deck.Cards.RemoveAt(0);
        }
        //NOTE: In this class the dealer has a few properties, but a dealer needs to do more.
        //      In blackjack a dealer also has a hand, they also 'stay' and 'bust' so it would
        //      be a nice approach to have a 'TwentyOneDealer' class which inherits 'Dealer'.

    }
}
