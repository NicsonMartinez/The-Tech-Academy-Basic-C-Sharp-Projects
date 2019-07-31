using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TwentyOne
{
    public class Dealer
    {
        public string Name { get; set; }

        public Deck Deck { get; set; }
        public int Balance { get; set; }

        public void Deal(List<Card> Hand)
        {
            //NOTE: 'using System.Linq;' to use the integrated 'First()' method.
            //NOTE: What we are doing here is assing a 'Deck' of 'Cards' (property of Deck), then getting the 
            //      first card in that list ( using 'First()' ), then adding it to the 'Hand' that was passed in (which is a list of cards).
            Hand.Add(Deck.Cards.First());

            //NOTE: This line is done so that the player can see the card on the console.
            Console.WriteLine(Deck.Cards.First().ToString() + "\n");

            //NOTE: The line below removes the card from the deck, at index 0 ('RemoveAt' is an integrated method for lists).
            Deck.Cards.RemoveAt(0);
        }

        //NOTE: At this point, some people have asked, why don't we have the 'Dealer' class inherit from the 'Deck' class? as opposed to
        //      adding it in as a property. The reasoning to that question is that by having the 'Dealer' class inherit from the 'Deck' class,
        //      it would save us from adding deck as a property, and we would just have the 'Deck' available through inheritance.
        //Answ: The reason why we are not doing that is because inheritance is a 'is a' relationship, not  a 'has a' relationship. 
        //      eg. A 'TwentyOneGame' 'is a' 'Game' (That's why we inherit 'Game' properties into 'TwentyOneGame').
        //          A 'TwentyOneGame' doen't have a 'Game' it 'is a' 'Game'.
        //      eg. A 'Dealer' 'has a' 'Deck' (That's why we added a 'Deck' as property to the 'Dealer' class).
        //          A 'Dealer' is not a 'Deck', it 'has a' 'Deck'.
        //NOTE: This is how you can decide wether you should inherit from a class, or add that class as a property.
        //      That keeps things more aligned and more similar to the real world, and that is the entire point of Object Oriented Programming.
        //NOTE: Later in your carrer you might com across the saying, 'Composition over Inheritance' which literally means it is safer to 
        //      to add a class as a property if you are unsure if that class has a 'is a' or a 'has a' relationship with another class, and
        //      preventing from using inheritance fro the wrong reasons.
    }
}
