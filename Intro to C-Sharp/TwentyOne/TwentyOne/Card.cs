using System;
using System.Collections.Generic;
using System.Text;

namespace TwentyOne
{
    public class Card
    {
        //NOTE: Here we got rid of our constructor.

        //NOTE: Below we changed the data type of property 'Suit' from 'string' to 'Suit' (after creating enum 'Suit')
        public Suit Suit { get; set; }

        //NOTE: Below we changed the data type of property 'Face' from 'string' to 'Face' (after creating enum 'Face')
        public Face Face { get; set; }

    }
    //NOTE: Here we are creating enum 'Suit'.
    public enum Suit
    {
        Clubs,
        Diamonds,
        Hearts,
        Spades
    }
    //NOTE: Here we are creating enum 'Suit'.
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
