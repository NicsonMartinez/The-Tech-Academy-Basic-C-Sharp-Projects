using System;
using System.Collections.Generic;
using System.Text;

namespace TwentyOne
{
    //NOTE: Here the 'TwentyOneGame' inherits from class, 'Game' and from interface 'IWalkAway'.
    public class TwentyOneGame : Game, IWalkAway
    {
        public override void Play()
        {
            throw new NotImplementedException();
        }
        public override void ListPlayers()
        {
            Console.WriteLine("21 Players");
            base.ListPlayers();
        }

        //NOTE: Here is the 'WalkAway' method from  the interface 'IWalkAway' (including it,s implementation.. which isn't much at the moment).
        public void WalkAway(Player player)
        {
            throw new NotImplementedException();
        }
        //NOTE: If we were to not have a 'void WalkAway(Player player)' method, this code wouldn't even compile because the 
        //      'IWalkAway' interface has a 'WalkAway' method and it 'MUST' be included in the class inhereitng from it
    }
}
