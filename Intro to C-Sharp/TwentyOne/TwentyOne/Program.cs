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
    }
}
//NOTE: 
/*OUTPUT:
Two of Clubs
Two of Hearts
Two of Diamonds
Two of Spades
Three of Clubs
Three of Hearts
Three of Diamonds
Three of Spades
Four of Clubs
Four of Hearts
Four of Diamonds
Four of Spades
Five of Clubs
Five of Hearts
Five of Diamonds
Five of Spades
Six of Clubs
Six of Hearts
Six of Diamonds
Six of Spades
seven of Clubs
seven of Hearts
seven of Diamonds
seven of Spades
Eight of Clubs
Eight of Hearts
Eight of Diamonds
Eight of Spades
Nine of Clubs
Nine of Hearts
Nine of Diamonds
Nine of Spades
Ten of Clubs
Ten of Hearts
Ten of Diamonds
Ten of Spades
Jack of Clubs
Jack of Hearts
Jack of Diamonds
Jack of Spades
Queen of Clubs
Queen of Hearts
Queen of Diamonds
Queen of Spades
King of Clubs
King of Hearts
King of Diamonds
King of Spades
Ace of Clubs
Ace of Hearts
Ace of Diamonds
Ace of Spades
52
     */
