using System;
using System.Collections.Generic;
using System.Text;

namespace TwentyOne
{
    public class Deck
    {
        public Deck()
        {
            Cards = new List<Card>();

            List<string> Suits = new List<string>() { "Clubs", "Hearts", "Diamonds", "Spades" };
            List<string> Faces = new List<string>()
            {
                "Two", "Three", "Four","Five", "Six", "seven",
                "Eight", "Nine", "Ten", "Jack", "Queen", "King", "Ace"
            };

            foreach(string face in Faces)
            {
                foreach(string suit in Suits)
                {
                    Card card = new Card();
                    card.Suit = suit;
                    card.Face = face;
                    Cards.Add(card);
                }
            }
        }

        //NOTE: Now we will give this class a public property of a list of 'Card's called 'Cards'.
        public List<Card> Cards { get; set; }

        //NOTE: Here we had to make a couple of changes to the 'Shuffle' method since it was preoviously in the 'Program' class.
        //      Now the 'Shuffle' method is no longer 'static' because an object of the (Deck) class where this method resides in , is what
        //      is going to call this method. Since, a deck object can change, it's method can no longer be fixed/'static'.
        //NOTE: The 'Shuffle' method will no longer to take in a 'deck' to return a deck, it will only shuffle the cards, applying it to
        //      the deck object that called it, thus, the method must now be void 'void'. Also, this method is no longer going have 
        //      an 'out parameter' because it is no longer needed, and it will only have an 'optional parameter' to take in.
        //NOTE: Another major change was that since we are now in the 'Deck' class, we no longer need to refernce deck.Cards to get a hold
        //      the Deck class property ('Cards'), which is needed to creata a new list of cards howver many times the user wants to.
        public void Shuffle(int times = 1)
        {
            for (int i = 0; i < times; i++)
            {
                List<Card> TempList = new List<Card>();
                Random random = new Random();
                while (Cards.Count > 0)

                {
                    int randomIndex = random.Next(0, Cards.Count);
                    TempList.Add(Cards[randomIndex]);
                    Cards.RemoveAt(randomIndex);
                }
                Cards = TempList;
            }
        }

    }
}
