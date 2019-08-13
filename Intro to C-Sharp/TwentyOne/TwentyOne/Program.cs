/*
THE TECH ACADEMY PROGRAM
- This Program represents a game known as 'TwentyOne' aka BlackJack.
- This games have aspects of it that demonstrates very well every basic feature in C#
- The end result won't be a perfect program by any means but it will be a good model of the important part of C#.
 */
using System;
using System.IO; //NOTE: This is neede for 'StreamWriter'.
using Casino;
using Casino.TwentyOne;

namespace TwentyOne
{
    class Program
    {
        static void Main(string[] args)
        {
            const string casinoName = "Grand Hotel and Casino";

            Console.WriteLine("Welcome to the {0}. Let's start by telling me your name.", casinoName);
            string playerName = Console.ReadLine();

            //NOTE: Here instead of reciving the information with out it being handled,
            //      eg. 'int bank = Convert.ToInt32(Console.ReadLine());', we created a
            //      validator that uses the 'int.TryParse' method wich returns a boolean
            //      based on whether the first string parameter is an int32. The method
            //      also includes an 'out parameter' of the int result in the case that 
            //      it is a valid int. This is a quick way to validate user input without
            //      having to use exception handling.
            bool validAnswer = false;
            int bank = 0;
            while (!validAnswer)
            {
                Console.WriteLine("And how much money did you bring today?");
                validAnswer = int.TryParse(Console.ReadLine(), out bank); 
                if (!validAnswer) Console.WriteLine("Please enter digits only, no decimals.");
            }
            
            Console.WriteLine("Hello, {0}. Would you like to join a game of 21 right now?", playerName);
            string answer = Console.ReadLine().ToLower();
            if (answer == "yes" || answer == "yeah" || answer == "y" || answer == "ya")
            {
                //NOTE: When the user answers yes, it will create a new player.
                //      In the 'Player' class we will create a constructoe that will 
                //      create that player with how much money they are bringing to the game.
                Player player = new Player(playerName, bank);

                //NOTE: Here we are logging a player 'Guid' so we can uniquely identify that player,
                //      and the cards that player has dealt with.
                player.Id = Guid.NewGuid();
                using (StreamWriter file = new StreamWriter(@"C:\log\log.txt", true))
                {
                    file.WriteLine(player.Id);
                }

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

                    //NOTE: This try-cath will catch any errors in the 'Play()' method.
                    try
                    {
                        game.Play();
                    }
                    //NOTE: This is an exception we created which inherits the integrated 'Exception' class.
                    //      It is a great way of 'throwing' a custom exception by when a condition is in
                    //      our program is met.
                    catch (FraudException)
                    {
                        Console.WriteLine("Security! Kick this person out.");
                        Console.ReadLine();
                        return;
                    }
                    //NOTE: This is the 'Exception' class that will catch any exception if not covered in the 
                    //      TwentyOneGame 'Play()' method.
                    catch (Exception)
                    {
                        Console.WriteLine("An error occured. Please contact your System Administrator.");
                        Console.ReadLine();
                        return;
                    }
                         
                }
                //NOTE: Outside of the while loop we will subtract the  player form the game.
                game -= player;
                Console.WriteLine("Thank You for playing!");
            }
            //NOTE: We won't do an else statement, if they say anything other than 'yes' 'yeah' 'y' & 'ya',
            //      then it will jump to this line.
            Console.WriteLine("Feel free to look around the casino. Bye for now.");
            Console.ReadLine();

            //NOTE: This is all that the main method is going to have.
        }

    }
}
