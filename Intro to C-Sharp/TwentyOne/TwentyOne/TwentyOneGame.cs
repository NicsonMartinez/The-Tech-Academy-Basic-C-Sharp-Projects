using System;
using System.Collections.Generic;
using System.Text;

namespace TwentyOne
{
    //NOTE: Here the 'TwentyOneGame' inherits from class, 'Game'.
    public class TwentyOneGame : Game
    {
        //NOTE: In order for this method, play() to agree to the abstract 'contract', we must write the keyword, 'override' 
        //      following 'public' as show on the code below.
        public override void Play()
        {
            throw new NotImplementedException();
        }
        //NOTE: If we were to not have a 'play()' method, this code wouldn't even compile because once we set a
        //      mehod to be abstract in our base/abstract class, it is required that any inheriting class has that method.

        public override void ListPlayers()
        {
            //NOTE: This line below here overrides the 'default' virtual 'ListPlayers()' implementation from the base/abstract class Game.
            //      This is the purpose of a virtual method in an abstract class. If there were other games inheriting from 'Game' they can
            //      take the virtual method, have the same implementation, and/or add its own implementation unique to that inhiriting class.
            Console.WriteLine("21 Players");

            //NOTE: This line here takes the exact same functionality that is in the base class.
            base.ListPlayers();
        }
        //NOTEL: See 'Programs.cs' to test see how this virtual and override 'listPlayers()' work.
    }
}
