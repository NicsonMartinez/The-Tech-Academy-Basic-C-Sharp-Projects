using System;
using System.Collections.Generic;
using System.Text;

namespace TwentyOne
{
    public class Player
    {
        //NOTE: Below is a 'Player' constructor (Constructors go at the top of the class).
        //      Here we have a constructor that takes two arguments and we are assigning them
        //      to properties in this object.
        public Player(string name, int beginningBalance)
        {
            Hand = new List<Card>();
            Balance = beginningBalance;
            Name = name;
        }
        public List<Card> Hand { get; set; }
        public int Balance { get; set; }
        public string Name { get; set; }
        public bool isActivelyPlaying { get; set; }

        public static Game operator+ (Game game, Player player)
        {
            game.Players.Add(player);
            return game;
        }
        public static Game operator- (Game game, Player player)
        {
            game.Players.Remove(player);
            return game;
        }
    }
}
