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

            Console.WriteLine("Welcome to the Grand Hotel and Casino. Let's start by telling me your name.");
            string playerName = Console.ReadLine();
            Console.WriteLine("And How much money did you bring today?");
            int bank = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Hello, {0}. Would you like to join a game of 21 right now?", playerName);
            string answer = Console.ReadLine().ToLower();
            if (answer == "yes" || answer == "yeah" || answer == "y" || answer == "ya")
            {
                //NOTE: When the user answers yes, it will create a new player.
                //      In the 'Player' class we will create a constructoe that will 
                //      create that player with how much money they are bringing to the game.
                Player player = new Player(playerName, bank);

                //NOTE: Here we are using Polymorphism, while creating a 'TwentyOneGame' as also its 
                //      parent class, 'Game' so that it exposes those overloaded operators we 
                //      made in the 'Player' class, which returns a 'Game' object, and to a  
                //      specified game object such as 'TwentyOneGame'.
                Game game = new TwentyOneGame();

                //NOTE: Here we are adding players into a game.
                game += player;

                player.isActivelyPlaying = true;

                //NOTE: 'isActivelyPlaying' and 'player.balabnce' are used as a way to track
                //      wether the player is playing the game or isn't/can't play the game.
                while (player.isActivelyPlaying && player.Balance > 0)
                {
                    //NOTE: The method, 'play()' doesn't have functionality yet, but it will
                    //      eventually.
                    game.Play(); 
                                
                }
            }
        }

    }
}
