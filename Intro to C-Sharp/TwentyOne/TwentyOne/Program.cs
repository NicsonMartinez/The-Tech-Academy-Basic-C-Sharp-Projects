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
            //NOTE: Here we instantiated a 'TwentyOneGame' game object.
            TwentyOneGame game = new TwentyOneGame();

            //NOTE: Here we added players to the 'Players' (list of strings), which is a 'Game' property (we have access
            //      to that property due to inheritance).
            game.Players = new List<String>() { "Nicson", "Jesse", "Bill" };

            //NOTE: Now we are calling that 'ListPlayers()' which has implementation from the 'public override void ListPlayers()' which
            //      includes the overriden implementation ("12 Players"), and the default implementation (List of players). 
            game.ListPlayers();
            Console.ReadLine();

            //NOTE: The code above will be deleted, it was just done to go over abstract classes, abstract methods, 
            //      and virtual methods, and override methods.
            //NOTE: The code below will be uncommented.

            //Deck deck = new Deck();

            //deck.Shuffle(3);

            //foreach (Card card in deck.Cards)
            //{
            //    Console.WriteLine(card.Face + " of " + card.Suit);
            //}
            //Console.WriteLine(deck.Cards.Count);
            //Console.ReadLine();
        }

    }
}
/*NOTE:
OUTPUT:
21 Players
Nicson
Jesse
Bill
*/
