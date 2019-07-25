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

            //NOTE: Here now we are able to shuffle a deck 3 times.
            //NOTE: Another trick in  C# to learn is, you can use something called a 'named parameter'. Which would change
            //	    'deck = Shuffle(deck, 3);' to 'deck = Shuffle(deck: deck, times: 3);'. It doesn't male a difference on the
            //	    code but it makes it better in terms of readability.
            deck = Shuffle(deck: deck, times: 3);

            foreach (Card card in deck.Cards)
            {
                Console.WriteLine(card.Face + " of " + card.Suit);
            }

            Console.WriteLine(deck.Cards.Count);

            Console.ReadLine();
        }

        //NOTE: below we changed the original Shuffle method, 'public static Deck Shuffle(Deck deck)', to say
        //	'public static Deck Shuffle(Deck deck, int times = 1)'. When you assign a parameter a default value
        //	like we did below, if the user doesn't assign how many times to shuffle the deck, it will shuffle 
        //	one time by default.
        //NOTE: We also moved the code inside a for loop to make this change functional.
        //NOTE: This is how you create an optional parameter.
        public static Deck Shuffle(Deck deck, int times = 1)
        {

            for (int i = 0; i < times; i++)
            {
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
        //NOTE: By creating a method with an optional parameter, there would be no need of overloading methods.
        //	Optional parameters may be convenient for soma occations, but if youu have a lot of optional
        //	parameters, then things will start to get messy, so overloading methods may make more sense to do.
    }
}