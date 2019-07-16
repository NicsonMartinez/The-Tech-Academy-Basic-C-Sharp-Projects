/*
EXERCISE:
IN A CONSOLE APP, CREATE CODE THAT DOES THE FOLLOWING:
Concatenate three strings.

Convert a string to uppercase.

Create a Stringbuilder and build a paragraph of text, one sentence at a time.
*/

using System;
using System.Text;

namespace Drill9StringFunct
{
    class Program
    {
        static void Main(string[] args)
        {
            string the = "The ";
            string car = "car ";
            string isRed = "is red.";
            string concatinatedString = the + car + isRed;
            Console.WriteLine("My concatinated string is: " + concatinatedString);
            Console.WriteLine("My concatinated string in all upper caps is: " + concatinatedString.ToUpper()+"\n");
            StringBuilder mySb = new StringBuilder();

            mySb.Append("This is my first sentence in the paragraph I'm creating.\n");
            mySb.Append("I am looking to append each sentence one by one.\n");
            mySb.Append("It is great to be able to change my current string over time.\n");
            mySb.Append("This is my last sentence in the paragraph created.");

            Console.WriteLine("Below is the pargraph I created by using the StringBuilder Class:\n\n" + mySb);
            Console.ReadLine();


        }
    }
}
