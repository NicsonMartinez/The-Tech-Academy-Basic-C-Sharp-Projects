using System;
using System.Collections.Generic;
using System.Text;

namespace TwentyOne
{
    public class Player
    {
        public List<Card> Hand { get; set; }
        public int Balance { get; set; }
        public string Name { get; set; }
        public bool isActivelyPlaying { get; set; }

        //NOTE: Here we will add an overloaded operator and we are going to overload 
        //      the plus operator first.
        //NOTE: Our goal is to just go "Game + Player" and that 'Player' object will 
        //      automaticllay be added to the list of players property in the 'Game' object.

        //NOTE: The code below will show how to overload an operator.
        //NOTE: Overloaded Operators must be declared static and public, if not the code will not compile. Then
        //      it follows the return data type (in this case 'Game') followed by keword,'operator', followed 
        //      by the operator you wish to overload (In this case '+'). The rest it it just treated like a reguar
        //      method. It passes in some objects and the developer makes it do something and return something.
        public static Game operator+ (Game game, Player player)
        {
            game.Players.Add(player);
            return game;
        }

        //NOTE: Below we are using the operator, '-', to remove a player from a game.
        public static Game operator- (Game game, Player player)
        {
            game.Players.Remove(player);
            return game;
        }
        //NOTE: This is polymorphism at work becuase player reutrns a game, ane becuase the parameter takes in
        //      a 'Game' rather than a 'TwentyOneGame'. So if we had some other game, lets say solitaire, it would
        //      be able to call the overloaded operators above due to inheritance.

    }
}
