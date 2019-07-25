/*
THE TECH ACADEMY PROGRAM
- This Program represents a game known as 'TwentyOne' aka BlackJack.
- This games have aspects of it that demonstrates very well every basic feature in C#
- The end result won't be a perfect program by any means but it will be a good model of the important part of C#.

 */

 //NOTE: Objects are the backbone of Object Oriented Programing (OOP). 
 /*NOTE: In OOP - Objects are items that can be represented by a program, the often meat to represent real world thin.
 In the world around you, you are surrounded by objects your dog, tv etc. Objects have states and behavior. The states
 of an object would be the size, color etc at any point in time.*/ 

 /*NOTE: We are going to take basic models for objects called classes. and we are going to give these classes properties.*/
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
            //NOTE: On the line below we have instantiated an object of type Deck and assigned it to a object variable called, 'deck'.
            Deck deck = new Deck();

            //NOTE: Now that we wrote a Shuffle function, we can use it by passing in our ordered deck, and making that function's return, 
            //      replace the 'deck' object we instantiated.
            //NOTE: Now when we run this program, it will print out the shuffled card object. 
            deck = Shuffle(deck);

            //NOTE: Here we are iterating through each card object in the iterable deck object that has a property
            // of 'Cards', which List of objects of type 'card' (each card having properties of Face and Suit created in the 'Card' class). 
            foreach(Card card in deck.Cards)
            {
                Console.WriteLine(card.Face + " of " + card.Suit);
            }

            //NOTE: Here we are printing the legnth of that list, so we can see that it is 52.
            Console.WriteLine(deck.Cards.Count);

            Console.ReadLine();
        }

        //NOTE: This is our 'Shuffle' method.3
        public static Deck Shuffle(Deck deck)
        {
            //NOTE: Here we are instantiating a list of cards object, 'TempList' (which is currently empty at this point) but
            //      will be used later.
            List<Card> TempList = new List<Card>();

            //NOTE: 'Random' a C# intgrated class 'System.Random' that represents a pseudo-random number generator, which is a
            //      device that produces a sequence of numbers that produces a sequence of numbers that meet certain statistical
            //      requirements for randomness.
            //NOTE: Here we are inststiating a 'Random' object called 'random'.
            Random random = new Random();


            while (deck.Cards.Count > 0)
            {
                //NOTE: The System.Random class has a method called Next
                //NOTE: In 'random.Next(0, deck.Cards.Count)' the first argument takes in a number signifiying where to begin searching for a
                //      random number, and the second argument takes in the count/length of 'things' you want to count.
                //      Basically, since we have 52 cards, 'random.Next(0, deck.Cards.Count)' specifically will return a number 
                //      between 0 and 51 (52 things) before storing that integer in the int variable, 'ransomIndex'.
                int randomIndex = random.Next(0, deck.Cards.Count);

                //NOTE: Now we will add a random card from the deck property, 'Cards' (from a specific card index between 0-51), and 
                //      put it into 'TempList'.
                TempList.Add(deck.Cards[randomIndex]);

                //NOTE: Then we will remove that item that was added to 'TempList' so that the 'random' method doesn't run accross the same item
                //      in the next iteration of the loop. Notice the loop will end once 'deck.Cards.Count' reaches 0.
                deck.Cards.RemoveAt(randomIndex);
            }
            //NOTE: Here we are putting that the new list of shuffled cards in 'TempList', and putting it in the deck property, 'Cards'.
            //      So now the cards list in the deck object are shuffled.
            deck.Cards = TempList;

            //NOTE: Lastly, the method returns the modified deck object.
            return deck;

        }
    }
}
//NOTE: Below are the cards shuffled Output.
/*OUTPUT:
Nine of Spades
Five of Clubs
King of Spades
seven of Hearts
Eight of Diamonds
seven of Diamonds
Five of Diamonds
Two of Hearts
Four of Hearts
Jack of Spades
Five of Hearts
Six of Hearts
King of Clubs
Six of Diamonds
Four of Diamonds
Two of Spades
Six of Clubs
Nine of Clubs
seven of Clubs
King of Diamonds
Five of Spades
Eight of Spades
Three of Hearts
Jack of Clubs
Ten of Spades
Nine of Hearts
Six of Spades
Four of Clubs
Jack of Hearts
Jack of Diamonds
Queen of Diamonds
seven of Spades
Two of Clubs
Ten of Clubs
Nine of Diamonds
King of Hearts
Two of Diamonds
Queen of Clubs
Ace of Hearts
Four of Spades
Ace of Diamonds
Three of Clubs
Queen of Hearts
Ace of Clubs
Eight of Clubs
Queen of Spades
Three of Spades
Ten of Diamonds
Ten of Hearts
Ace of Spades
Three of Diamonds
Eight of Hearts
52 
*/
