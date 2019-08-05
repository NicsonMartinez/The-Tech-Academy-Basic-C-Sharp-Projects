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

            //NOTE: For the most part we changed everything is this 'Deck' constructor after changing card values from simple 'string' 
            //      data types to 'enum' data types.

            //NOTE: Again, we will approach creating a deck of cards with a nested for loop.
            for (int i = 0; i < 13; i++)
            {
                for (int j = 0; j < 4; j++)
                {
                    //NOTE: with our logic we will instantiate a card 52 times.
                    Card card = new Card();

                    //NOTE: Here we are type casting int 'i' to an enum type, 'Face',  and int 'j' to an enum type, 'Suit'. These two lines
                    //      of code will store the name of the current 'face' and 'suit' in this iteration and store it in the 'Face' and 'Suit' 
                    //      properties of that current card objectin the iteration.
                    card.Face = (Face)i;
                    card.Suit = (Suit)j;

                    //NOTE: Here we are adding the card which will have a combination of a 'Face' enum and a 'Suit' enum. This will happen
                    //      52 times, adding  52 cards to the 'Cards' property (wich is a list of card objects).
                    Cards.Add(card);
                }
            }
        }
        public List<Card> Cards { get; set; }
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
