using System;
using System.Collections.Generic;
using System.Text;

namespace TwentyOne
{
    //NOTE: Here we are changinig 'Card' from a 'class' to a 'struct' becuase once we set a value, we don't want it to change.
    //      Also, the Card class doesn't inherit from or to any other classes, which makes it qualify to be struct.
    public struct Card
    {
        public Suit Suit { get; set; })
        public Face Face { get; set; }

    }
    public enum Suit
    {
        Clubs,
        Diamonds,
        Hearts,
        Spades
    }
    public enum Face
    {
        Two,
        Three,
        four,
        Five,
        Six,
        Seven,
        Eight,
        Nine,
        Ten,
        Jack,
        Queen,
        King,
        Ace
    }
}
