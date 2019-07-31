using System;
using System.Collections.Generic;
using System.Text;

namespace TwentyOne
{
    //NOTE: A base base class aka abstract class is meant for it not to be instantiated. 
    //NOTE: Abstract classes are a way for the developer to keep control of the program design by
    //      locking down some of the features.
    public abstract class Game
    {
        public List<string> Players { get; set; }
        public string Name { get; set; }
        public string Dealer { get; set; }

        //NOTE: There are also 'abstract' methods! An abstract method can only exist inside of an abstract class.
        //NOTE: As you can see below, abstract methods do not have any implementation.
        //NOTE: All an abtract method does is state that any class inheriting this class MUST implement this method. It is sort of
        //      'contract' between the base class and the inheriting class (in our occasion, the inheriting class is 'TwentyOneGame').
        //NOTE: See the changes made in the inheriting class TwentyOneGame's 'Play()' method, it will now 'Have' to say 'public override void Play()'
        //      in order for the program to becompiled. 
        public abstract void Play();

        //NOTE: We also have virtual methods and unlike abstract methods, they do have implementation. You can have some 'default' 
        //      implementation, but that implementation can be overriden or part of it can be overriden by its inheriting class. 
        //      It adds flexibility by making what the method 'listPlayers()' do the same for every inheriting class but customizable.
        //NOTE: See the changes made in the inheriting class TwentyOneGame's 'ListPlayers()' method, it doesn't necessarily 'Have' to 
        //      say 'public override void ListPlayers()' for the program to compile, but it is necessary for it to use that 'default' 
        //      implentation from 'Game'.
        public virtual void ListPlayers()
        {
            foreach (string player in Players)
            {
                Console.WriteLine(player);
            }
        }
    }
}
