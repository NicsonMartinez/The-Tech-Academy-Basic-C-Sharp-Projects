using System;
using System.Collections.Generic;
using System.Text;

namespace TwentyOne
{
    //NOTE: First we make it public so it is accessible theroughout the program.
    public class Player
    {
        //NOTE: By typing 'prob' then [Tab][Tab], this will come up automatically 'public int MyProperty { get; set; }'.
        //      It is a faster way to create properties. 

        //NOTE: A player is going to have a hand(list of cards), a balance, a name, and we are going to have to know if the player
        //      is actively playong, which will com in handy down the road.
        public List<Card> Hand { get; set; }
        public int Balance { get; set; }
        public string Name { get; set; }
        public bool isActivelyPlaying { get; set; }
    }
}
