using System;
using System.Collections.Generic;
using System.Text;

namespace TwentyOne
{
    public abstract class Game
    {
        //NOTE: The line used to be, 'public List<string> Players { get; set; }' below and we changed the property to be a 
        //      a list of objects, 'Player', instead of a list of strings.(this change is happening because players 
        //      were only strings previously, but now we have player objects).  
        public List<Player> Players { get; set; }
        public string Name { get; set; }
        public string Dealer { get; set; }
        public abstract void Play();
        public virtual void ListPlayers()
        {
            //NOTE: Since the Players list Property changed, we also needed to change the 'foreach' loop below.
            //NOTE: Now we are iterating through a list of type 'Player' objects in 'Players' list (which is the game property)
            foreach (Player player in Players)
            {
                //NOTE: We will have the players names printed  by calling the name property from a 'Player object'.
                Console.WriteLine(player.Name);
            }
        }
    }
}
