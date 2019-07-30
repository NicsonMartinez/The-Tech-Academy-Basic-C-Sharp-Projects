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
            //NOTE: Here we are instantiating a 'TwentyOneGame' object.
            TwentyOneGame game = new TwentyOneGame();

            //NOTE: After typing, 'game.', Visual studio intellisense shows you that the 'TwentyOneGame' object called 'game' has 
            //      access to the 'Game' class properties and methods. So, our 'TwentyOneGame' object is using our superclass (which is 'Game')
            //      property, 'Players' & method, 'ListPlayers'.
            game.Players = new List<string>() { "Nicson", "Jessie", "Bill" };
            game.ListPlayers();
            //NOTE: The above code is possible because of inheritance. 'TwentyOneGame' class inherits the 'Game' class.
            //NOTE: Just like methods help avoid repeating code, inheritance help avoid reating code in related classes.

            //NOTE: The method 'Play()' below is currently only accessible to a 'TwentyOneGame' object specifically. 
            //      This 'Play()' method can not be accessed by class 'TwentyOneGame' object's superclass 'Game' or 
            //      any other class, unless we create a class that inherits the 'TwentyOneGame' class.
            game.Play();
            Console.ReadLine();


            //Deck deck = new Deck();

            ////NOTE: The 'Shuffle' method was moved from the this class, to the 'Deck' class becuase in OOP objects
            ////      have a state and behaviors, and we can consider shuffle a behavior of a deck object.
            ////NOTE: Since we removed the 'Shuffle' method to the Deck class (and made changes to that method), now we are 
            ////      able to call the 'Shuffle' method from a deck object and optionally pass in a parameter an int
            ////      telling the method how many times we are shuffling the deck.
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
