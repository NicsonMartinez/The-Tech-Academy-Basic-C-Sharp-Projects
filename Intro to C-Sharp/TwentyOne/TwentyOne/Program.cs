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
            Game game = new TwentyOneGame();

            //NOTE: Lists must be instantiated before they can be used (If we didn't it would cause an error).
            //NOTE: The property 'Players' (which is a list of 'Player' objects), which is a property of the 'Game' class 
            //      must be instantiated in this class before it can be used. The List of players needs to be used
            //      for us to call the overloaded operators "+" and "-" method in the 'Player' class.
            game.Players = new List<Player>();

            //NOTE: Here we are creating a new 'Player' object that has property name = 'Nicson'
            Player player = new Player();
            player.Name = "Nicson";

            //NOTE: Here we are seeing overloaded operator in action we created in the 'Player' class which 
            //technically is a method that takes in 'Game' & 'Player' objects and returns a game object.      
            game += player;
            //NOTE: The code above is the same as 'game = game + player;'
            //In this case Game.

            Console.WriteLine(game.Players.Count);
            //NOTE: At this point 'game.Players.Count' = 1 becuase the player "Nicson" was added. 

            game -= player;
            //NOTE: The code above is the same as 'game = game - player;'

            Console.WriteLine(game.Players.Count);
            //NOTE: At this point 'game.Players.Count' = 0 becuase the player "Nicson" was subtracted. 

            //NOTE: The code above will be altered later, this was just done to go over overloaded operators.
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
1
0
*/
