using System;
using System.Collections.Generic;
using System.Text;

namespace TwentyOne
{
    public class Game
    {
        //NOTE: Here the 'Game' class has properties of 'Players' (which is a list of strings), 'Name' (a string), & 'Dealer' (a string).
        //NOTE: The 'Game' class also has a  behavior / method called 'public void ListPlayers()' which lists players in proprty, 'Players'.
        public List<string> Players { get; set; }
        public string Name { get; set; }
        public string Dealer { get; set; }

        public void ListPlayers()
        {
            foreach (string player in Players)
            {
                Console.WriteLine(player);
            }
        }
    }
}
