/*
EXERCISE:
IN A CONSOLE APP, CREATE CODE THAT DOES THE FOLLOWING:

By: Nicson Martinez
Date: 7/22/19
*/

using System;
using System.Collections.Generic;

namespace Drill11forloop
{
    class Program
    {
        static void Main(string[] args)
        {
            /************************************************************************************************************************
             * 1. Create a one-dimensional Array of strings. Ask the user to input some text. Create a loop that goes through each
             * string in the Array, adding the user’s text to the string. Then create a loop that prints off each string 
             * in the Array on a separate line.
             ***********************************************************************************************************************/

            Console.WriteLine("//---------------------------------------------------------------------");
            Console.WriteLine("EXERCISE 1");
            string[] stringArray = { "1one", "2two", "3", "4four", "5five" };

            Console.WriteLine("Please Fix This:\n");

            for (int i = 0; i < stringArray.Length; i++)
            {
                Console.WriteLine(stringArray[i]);
            }

            Console.WriteLine("\nTo fix this, please enter the 5 letter word missing on the the 3rd string value our array:");
            string stringInput = Console.ReadLine();

            stringArray[2] = stringArray[2] + stringInput;

            Console.WriteLine("");
            for (int i = 0; i < stringArray.Length; i++)
            {
                Console.WriteLine(stringArray[i]);
            }

            Console.WriteLine("\nThank You!");

            Console.WriteLine("//---------------------------------------------------------------------");
            Console.WriteLine("EXERCISE 2\n");
            /***************************************
             * 2.Create an infinite loop.
             ****************************************/

            //for (int i = 0; i >= 0; i++)
            //{
            //    Console.WriteLine("Repeat this lol");
            //}

            Console.WriteLine("This is My infinite loop:\n");
            Console.WriteLine("for (int i = 0; i >= 0; i++)\n{\n\tConsole.WriteLine(\"Repeat this lol\");\n}");

            Console.WriteLine("//---------------------------------------------------------------------");
            Console.WriteLine("EXERCISE 3\n");
            /******************************************************
             * 3. Fix the infinite loop so it will execute.
             ******************************************************/

            Console.WriteLine("This is My 'fixed' loop:\n");
            Console.WriteLine("for (int i = 0; i <= 4; i++)\n{\n\tConsole.WriteLine(\"Print this 5 times.\");\n}\n");


            for (int i = 0; i <= 4; i++)
            {
                Console.WriteLine("Print this 5 times.");
            }


            Console.WriteLine("//---------------------------------------------------------------------");
            Console.WriteLine("EXERCISE 4\n");
            /*******************************************************************************************************
             * 4. Create a loop where the comparison used to determine whether to continue iterating the loop 
             * is a “<” operator.
             *******************************************************************************************************/
            Console.WriteLine("Loop using the '<' sign:\n");

            Console.WriteLine("for (int i = 0; i < 4; i++)\n{\n\tConsole.WriteLine(\"Print this 4 times.\");\n}\n");

            for (int i = 0; i < 4; i++)
            {
                Console.WriteLine("Print this 4 times.");
            }


            Console.WriteLine("//\n---------------------------------------------------------------------");
            Console.WriteLine("EXERCISE 5\n");
            /*********************************************************************************************************
             * 5. Create a loop where the comparison used to determine whether to continue iterating the loop 
             * is a “<=” operator.
             ********************************************************************************************************/

            Console.WriteLine("Loop using the '<=' sign:\n");
            Console.WriteLine("Look at 'EXERCISE 3.");
            //NOTE: Look at number 3. 'Fix the infinite loop so it will execute'.

            Console.WriteLine("//\n---------------------------------------------------------------------");
            Console.WriteLine("EXERCISE 6\n");
            /********************************************************************************************************
             * 6. Create a List of strings where each item in the list is unique. Ask the user to select text 
             * to search for in the List. Create a loop that iterates through the list and then displays the 
             * index of the array that contains matching text on the screen.
             ********************************************************************************************************/

            List<string> colors = new List<string>();
            colors.Add("blue");
            colors.Add("red");
            colors.Add("yellow");
            colors.Add("green");
            colors.Add("purple");
            colors.Add("orange");

            foreach (string color in colors)
            {
                Console.WriteLine(color);
            }

            Console.WriteLine("\nPlease type one of the colors above so we can tell you its index in list 'colors':\n");
            string colorTyped = Console.ReadLine();



            bool isInList = false;
            for (int i = 0; i < colors.Count; i++)
            {
                //NOTE: Uncomment the comment below to check that the loop has stopped from executing once a match has been found (for number 8).
                //Console.WriteLine(colors[i]);
                if (colorTyped == colors[i])
                {
                    isInList = true;
                    if (isInList)
                    {
                        Console.WriteLine("The color you picked is, " + colorTyped + ", and it is in index '" + i + "' in the 'colors' list.");

                        //NOTE: The line below will stop it from executing after a match has been found (for Number 8).
                        break;
                    }

                }
            }

            //NOTE: The conditional below will check in the case the color typed by the user isn't in the list (for Number 7).
            if (isInList == false)
            {
                Console.WriteLine("The string you typed, " + colorTyped + ", is NOT  in index in the 'colors' list.");
            }


            Console.WriteLine("//\n---------------------------------------------------------------------");
            Console.WriteLine("EXERCISE 7.\n");
            /**************************************************************************************************
             * 7. Add code to that above loop that tells a user if they put in text that isn’t in the List.
             **************************************************************************************************/

            Console.WriteLine("Add code to that above loop that tells a user if they put in text that isn’t in the List:\n");
            Console.WriteLine("Look at 'EXERCISE 6 code.");
            //NOTE: Look at number 6.

            Console.WriteLine("//\n---------------------------------------------------------------------");
            Console.WriteLine("EXERCISE 8.\n");
            /**************************************************************************************************
             * 8. Add code to that above loop that stops it from executing once a match has been found.
             **************************************************************************************************/

            Console.WriteLine("Add code to that above loop that stops it from executing once a match has been found:\n");
            Console.WriteLine("Look at 'EXERCISE 6 code.");
            //NOTE: Look at number 6.

            Console.WriteLine("//\n---------------------------------------------------------------------");
            Console.WriteLine("EXERCISE 9.\n");
            /**************************************************************************************************
             * 9. Create a List of strings that has at least two identical strings in the List. Ask the 
             * user to select text to search for in the List. Create a loop that iterates through the 
             * list and then displays the indices of the array that contain matching text on the screen.
             **************************************************************************************************/
            List<string> colors2 = new List<string>();
            colors2.Add("blue");
            colors2.Add("red");
            colors2.Add("red");
            colors2.Add("yellow");
            colors2.Add("green");
            colors2.Add("purple");
            colors2.Add("orange");

            foreach (string color in colors2)
            {
                Console.WriteLine(color);
            }

            Console.WriteLine("\nPlease type one of the colors above so we can tell you its index in list 'colors2':\n");
            string colorTyped2 = Console.ReadLine();

            bool isInList2 = false;
            for (int i = 0; i < colors2.Count; i++)
            {
                if (colorTyped2 == colors2[i])
                {
                    isInList2 = true;
                    if (isInList2)
                    {
                        Console.WriteLine("The color you picked is, " + colorTyped2 + ", and it is in index '" + i + "' in the 'colors2' list.");
                    }

                }
            }

            //NOTE: The conditional below will check in the case the color typed by the user isn't in the list (for Number 10).
            if (isInList2 == false)
            {
                Console.WriteLine("The string you typed, " + colorTyped2 + ", is NOT  in index in the 'colors2' list.");
            }

            Console.WriteLine("//\n---------------------------------------------------------------------");
            Console.WriteLine("EXERCISE 10.\n");
            /**************************************************************************************************
             * 10. Add code to that above loop that tells a user if they put in text that isn’t in the List.
             **************************************************************************************************/

            Console.WriteLine("Add code to that above loop that tells a user if they put in text that isn’t in the List:\n");
            Console.WriteLine("Look at 'EXERCISE 9 code.");
            //NOTE: Look at number 9.

            Console.WriteLine("//\n---------------------------------------------------------------------");
            Console.WriteLine("EXERCISE 11.\n");
            /**************************************************************************************************
             * 11. Create a List of strings that has at least two identical strings in the List. Create 
             * a foreach loop that evaluates each item in the list, and displays a message showing the 
             * string and whether or not it has already appeared in the list.
             **************************************************************************************************/
            Console.WriteLine("11. Create a List of strings that has at least two identical strings in the List. Create a foreach loop that evaluates each item in the list, and displays a message showing the string and whether or not it has already appeared in the list:\n");
            List<string> colors3 = new List<string>();
            colors3.Add("blue");
            colors3.Add("red");
            colors3.Add("red");
            colors3.Add("red");
            colors3.Add("yellow");
            colors3.Add("green");
            colors3.Add("purple");
            colors3.Add("orange");

            int colorCount = 0;
            List<string> colorsLog = new List<string>();
            foreach (string color in colors3)
            {
                //NOTE: This condition checks if the 'colorsLog' contains the current iteration of color in 'colors3' list.
                //If it doesn't, it will just add that current string to 'colorsLog'. 
                //Then it will when it checks again if the 'colorsLog' contains the current iteration of color in 'colors3' list, it may find 
                //that this time it in fact does, thus adding 1 to 'colorCount' and mentioning to the user the color that 
                //is being was repeated and the amount of times it has previously appeared then proceeding to add that color to 
                //'colorsLog' to be able to continue catching previously appearings of he same color. 
                if (colorsLog.Contains(color))
                {
                    colorCount++;
                    Console.WriteLine(color + " - This color, " + color + ", has previously appeared '" + colorCount + "' time(s)");
                    colorsLog.Add(color);
                }
                else
                {
                    Console.WriteLine(color);
                    colorsLog.Add(color);
                }

                //NOTE: At the end both 'colors3' and 'colorsLog' lists will have the same strings in each.
                //Conlusion: Another list is being used to keep track of items in the main list.
            }
            Console.ReadLine();
        }
    }

}
