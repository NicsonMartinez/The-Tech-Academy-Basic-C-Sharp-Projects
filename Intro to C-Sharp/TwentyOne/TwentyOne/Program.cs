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

            deck.Shuffle(3);

            foreach (Card card in deck.Cards)
            {
                Console.WriteLine(card.Face + " of " + card.Suit);
            }
            Console.WriteLine(deck.Cards.Count);
            Console.ReadLine();
        }

    }
}
/*NOTE:
OUTPUT:
Jack of Hearts
Three of Spades
Nine of Diamonds
Six of Hearts
Seven of Clubs
Five of Spades
Ten of Hearts
Two of Spades
Five of Clubs
Seven of Spades
Seven of Diamonds
Ace of Diamonds
Eight of Clubs
Ten of Clubs
Three of Clubs
Nine of Clubs
King of Clubs
Six of Clubs
four of Hearts
four of Spades
Queen of Hearts
Ten of Spades
Queen of Spades
Jack of Clubs
Ace of Hearts
Ace of Clubs
four of Clubs
Queen of Diamonds
Ace of Spades
Five of Hearts
Jack of Spades
Eight of Spades
Ten of Diamonds
Queen of Clubs
Three of Diamonds
King of Spades
Three of Hearts
Six of Spades
Two of Clubs
four of Diamonds
Two of Hearts
Eight of Diamonds
Two of Diamonds
Five of Diamonds
Seven of Hearts
Nine of Spades
Six of Diamonds
Nine of Hearts
Eight of Hearts
King of Hearts
King of Diamonds
Jack of Diamonds
52
*/
