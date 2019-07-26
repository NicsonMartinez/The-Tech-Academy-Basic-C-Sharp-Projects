/*
THE TECH ACADEMY PROGRAM
- This Program represents a game known as 'TwentyOne' aka BlackJack.
- This games have aspects of it that demonstrates very well every basic feature in C#
- The end result won't be a perfect program by any means but it will be a good model of the important part of C#.

 */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace TwentyOne
{
    class Program
    {
        static void Main(string[] args)
        {
            Deck deck = new Deck();

            //NOTE: What we added here on the 'Shuffle method call below, is what is called an 'out parameter'.
            //      This out parameter is a value that gets calculated in the method, and can be used outsed of the method,
            //      but it is Not the return value.
            int timesShuffled = 0;
            deck = Shuffle(deck, out timesShuffled, 3 );

            foreach (Card card in deck.Cards)
            {
                Console.WriteLine(card.Face + " of " + card.Suit);
            }

            Console.WriteLine(deck.Cards.Count);
            Console.WriteLine("Times shuffled {0}", timesShuffled);

            Console.ReadLine();
        }


        //NOTE: Here we updated the 'Shuffle' method again, by adding whats called an 'out parameter'. They must go before 
        //      any 'optional parameters' and they are initialized in the parameter.
        //NOTE: We changed, 'public static Deck Shuffle(Deck deck, int times = 1)' to 
        //      'public static Deck Shuffle(Deck deck, out int timesShuffled, int times = 1').
        //NOTE: What int 'timeShuffled' is designed to keep track of the amount of times a card was shiffled. All we had to do
        //      is add one to that it in the for loop where the shiffling takes place.
        public static Deck Shuffle(Deck deck, out int timesShuffled, int times = 1)
        {
            timesShuffled = 0;
            for (int i = 0; i < times; i++)
            {
                timesShuffled++;
                List<Card> TempList = new List<Card>();
                Random random = new Random();
                while (deck.Cards.Count > 0)

                {
                    int randomIndex = random.Next(0, deck.Cards.Count);
                    TempList.Add(deck.Cards[randomIndex]);
                    deck.Cards.RemoveAt(randomIndex);
                }
                deck.Cards = TempList;
            }
            return deck;
        }
    }
}
/*NOTE:
OUTPUT:
Five of Spades
Six of Diamonds
Five of Diamonds
Eight of Clubs
Three of Clubs
Nine of Hearts
Ace of Spades
Ten of Diamonds
Nine of Spades
Ten of Clubs
Five of Clubs
seven of Hearts
Four of Hearts
Ace of Diamonds
King of Diamonds
Six of Clubs
Three of Spades
Six of Spades
seven of Clubs
seven of Diamonds
King of Clubs
Jack of Clubs
Ten of Hearts
Nine of Clubs
Queen of Spades
Queen of Diamonds
Four of Clubs
Ace of Hearts
Ace of Clubs
seven of Spades
Two of Hearts
Jack of Hearts
King of Spades
Queen of Hearts
Six of Hearts
King of Hearts
Jack of Diamonds
Five of Hearts
Two of Diamonds
Two of Clubs
Two of Spades
Three of Hearts
Nine of Diamonds
Jack of Spades
Three of Diamonds
Eight of Spades
Eight of Hearts
Ten of Spades
Eight of Diamonds
Four of Diamonds
Queen of Clubs
Four of Spades
52
Times shuffled 3 
*/
