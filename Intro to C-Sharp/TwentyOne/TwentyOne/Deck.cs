using System;
using System.Collections.Generic;
using System.Text;

namespace TwentyOne
{
    //NOTE: In this instance, a deck is a collection of cards
    public class Deck
    {
        //NOTE: Constructors always go at the top of the class before the properties.
        //NOTE: A constructor is a way of assigning values to an object immediately upon creation.
        //NOTE: Below is our 'Deck' constructor 'public Deck()'.
        public Deck()
        {

            //NOTE: 'Cards' is a list object property of the 'Deck' class. In order to create the deck, we must instantiate a list 
            //      that property, 'Cards' like this, 'Cards = new List<Card>();' specifically because it is a property of this class.
            //      If we initalized it like this, 'List<Card> Cards = new List<Card>();' we would only be creating a local variable,
            //      that wouldn't able to be accessed by other classes in the way properties are.
            //NOTE: Below, we istantiated the data type List<Card> of property 'Cards';
            Cards = new List<Card>();

            //NOTE: Here we are creating to 2 lists of strings (knowing that there are 52 cards and 13 * 4 = 52)
            //      There are 4 suits, and 13 faces.
            List<string> Suits = new List<string>() { "Clubs", "Hearts", "Diamonds", "Spades" };
            List<string> Faces = new List<string>()
            {
                "Two", "Three", "Four","Five", "Six", "seven",
                "Eight", "Nine", "Ten", "Jack", "Queen", "King", "Ace"
            };

            //NOTE: Here we are using a nested for loop in order to create a list of the combination of strings to create
            //      52 different strings items in the list, representing each representing a card.
            foreach(string face in Faces)
            {
                foreach(string suit in Suits)
                {
                    //NOTE: Here we are initializing a 'card' type 'Card' (from the 'Card' class) that will be used as a temp variable where
                    //      each of the 'Card' class properties (Suit and Face) can be used and populated by string values, the create 
                    //      different 'card' objects, so that it can be added to the 'Cards' list (which is a property of Deck class).
                    Card card = new Card();
                    card.Suit = suit;
                    card.Face = face;
                    Cards.Add(card);
                }
            }
        }

        //NOTE: Now we will give this class a public property of a list of 'Card's called 'Cards'.
        public List<Card> Cards { get; set; }
     }
}
