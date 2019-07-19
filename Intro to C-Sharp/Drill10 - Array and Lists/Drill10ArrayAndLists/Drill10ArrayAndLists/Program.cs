/*
EXERCISE:
IN A CONSOLE APP, CREATE CODE THAT DOES THE FOLLOWING:
1. Create an array of strings. Ask the user to select an index of the Array and then display the string at that index on the screen.

2. Create an array of integers. Ask the user to select an index of the Array and then display the integer at that index on the screen.

3. Add in a message that displays when the user selects an index that doesn’t exist.

4. Create a List of strings. Ask the user to select an index of the List and then display the content at that index on the screen.

By:Nicson Martinez
7/18/19
 */


using System;
using System.Collections.Generic;

namespace Drill10ArrayAndLists
{
    class Program
    {
        static void Main(string[] args)
        {
            bool run = true;
            while (run)
            {
                string[] playersArray = new string[] { "L. Messi", "C. Ronaldo", "Neymar Jr.", "A. Griezman" };
                int[] playerShirtNumber = new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

                Console.WriteLine("\nA Program for Football fans! ( Note: Some call it soccer.. -__- )\n");
                Console.WriteLine("This what the 'playersArray' variable contains:");
                for (int i = 0; i < playersArray.Length; i++)
                {
                    Console.WriteLine("Index " + i + " = " + playersArray[i]);
                }

                int selectedPlayerNumber = 0;
                int selectedPlayerShirtNum = 0;
                string userPlayerSelection = "";

                bool playerIsPicked = false;
                do
                {
                    try
                    {
                        Console.WriteLine("\nEnter the Index number to select your favorite player from our 'playersArray' variable (eg. '1' NOT 'index 1'):");
                        selectedPlayerNumber = Convert.ToInt32(Console.ReadLine());
                        userPlayerSelection = playersArray[selectedPlayerNumber];
                        playerIsPicked = true;
                    }
                    catch (FormatException)
                    {
                        Console.WriteLine("\nError: Your entry was invalid, please enter an integer.");
                        playerIsPicked = false;
                    }
                    catch (IndexOutOfRangeException)
                    {
                        Console.WriteLine("\nError: Your Index selected is out of range (it doesn't exist), please try again.");
                        playerIsPicked = false;
                    }

                }
                while (playerIsPicked == false);


                Console.WriteLine("\nYou have selected " + userPlayerSelection + " as your 'favorite player'.");
                Console.WriteLine("\nWhat jersey number belongs to your 'favorite player'(at club level as of 7/18/19)?");
                Console.WriteLine("\nThis what the 'playerShirtNumber' array variable contains:");

                for (int i = 0; i < playerShirtNumber.Length; i++)
                {
                    Console.WriteLine("Index " + i + " = " + playerShirtNumber[i]);
                }


                int userJerseyNumSelection = 0;
                bool playerShirtNumIsPicked;
                do
                {
                    try
                    {
                        Console.WriteLine("\nEnter the Index number to select the Jersey number from our 'playerShirtNumber' array (eg. '1' NOT 'index 1'):");
                        selectedPlayerShirtNum = Convert.ToInt32(Console.ReadLine());
                        userJerseyNumSelection = playerShirtNumber[selectedPlayerShirtNum];
                        playerShirtNumIsPicked = true;
                    }
                    catch (FormatException)
                    {
                        Console.WriteLine("\nError: Your entry was invalid, please enter an integer.");
                        playerShirtNumIsPicked = false;
                    }
                    catch (IndexOutOfRangeException)
                    {
                        Console.WriteLine("\nError: Your Index selected is out of range (it doesn't exist), please try again.");
                        playerShirtNumIsPicked = false;
                    }
                }
                while (playerShirtNumIsPicked == false);


                switch (userPlayerSelection)
                {
                    case "L. Messi" when userJerseyNumSelection == 10:
                        Console.WriteLine("\nYour jersey selection, " + userJerseyNumSelection + " is Correct!!");
                        Console.WriteLine("As of July 18th, 2019 L. Messi's jersey number is number 10 with Barcelona.");
                        break;
                    case "L. Messi" when userJerseyNumSelection != 10:
                        Console.WriteLine("\nYour jersey selection, " + userJerseyNumSelection + " is Incorrect.");
                        Console.WriteLine("As of July 18th, 2019 L. Messi's jersey number is number 10 with Barcelona.");
                        break;
                    case "C. Ronaldo" when userJerseyNumSelection == 7:
                        Console.WriteLine("\nYour jersey selection, " + userJerseyNumSelection + " is Correct!!");
                        Console.WriteLine("As of July 18th, 2019 C. Ronaldo's jersey number is number 7 with Juventus.");
                        break;
                    case "C. Ronaldo" when userJerseyNumSelection != 7:
                        Console.WriteLine("\nYour jersey selection, " + userJerseyNumSelection + " is Incorrect.");
                        Console.WriteLine("As of July 18th, 2019 C. Ronaldo's jersey number is number 7 with Juventus.");
                        break;
                    case "Neymar Jr." when userJerseyNumSelection == 10:
                        Console.WriteLine("\nYour jersey selection, " + userJerseyNumSelection + " is Correct!!");
                        Console.WriteLine("As of July 18th, 2019 Neymar's jersey number is number 10 with PSG.");
                        break;
                    case "Neymar Jr." when userJerseyNumSelection != 10:
                        Console.WriteLine("\nYour jersey selection, " + userJerseyNumSelection + " is Incorrect.");
                        Console.WriteLine("As of July 18th, 2019 Neymar's jersey number is number 10 with PSG.");
                        break;
                    case "A. Griezman" when userJerseyNumSelection == 17:
                        Console.WriteLine("\nYour jersey selection, " + userJerseyNumSelection + " is Correct!!");
                        Console.WriteLine("As of July 18th, 2019 A. Griezman's jersey number is number 17 with Barcelona.");
                        break;
                    case "A. Griezman" when userJerseyNumSelection != 17:
                        Console.WriteLine("\nYour jersey selection, " + userJerseyNumSelection + " is Incorrect.");
                        Console.WriteLine("As of July 18th, 2019 A. Griezman's jersey number is number 17 with Barcelona.");
                        break;
                    default:
                        Console.WriteLine("There was an error..");
                        break;
                }

                //if (userPlayerSelection == "L. Messi" && userJerseyNumSelection == 10)
                //{
                //    Console.WriteLine("\nYour jersey selection, " + userJerseyNumSelection + " is Correct!!");
                //    Console.WriteLine("As of July 18th, 2019 L. Messi's jersey number is number 10 with Barcelona.");
                //}
                //else if (userPlayerSelection == "L. Messi" && userJerseyNumSelection != 10)
                //{
                //    Console.WriteLine("\nYour jersey selection, " + userJerseyNumSelection + " is Incorrect.");
                //    Console.WriteLine("As of July 18th, 2019 L. Messi's jersey number is number 10 with Barcelona.");
                //}
                //else if (userPlayerSelection == "C. Ronaldo" && userJerseyNumSelection == 7)
                //{
                //    Console.WriteLine("\nYour jersey selection, " + userJerseyNumSelection + " is Correct!!");
                //    Console.WriteLine("As of July 18th, 2019 C. Ronaldo's jersey number is number 7 with Juventus.");
                //}
                //else if (userPlayerSelection == "C. Ronaldo" && userJerseyNumSelection != 7)
                //{
                //    Console.WriteLine("\nYour jersey selection, " + userJerseyNumSelection + " is Incorrect.");
                //    Console.WriteLine("As of July 18th, 2019 C. Ronaldo's jersey number is number 7 with Juventus.");
                //}
                //else if (userPlayerSelection == "Neymar Jr." && userJerseyNumSelection == 10)
                //{
                //    Console.WriteLine("\nYour jersey selection, " + userJerseyNumSelection + " is Correct!!");
                //    Console.WriteLine("As of July 18th, 2019 Neymar's jersey number is number 10 with PSG.");
                //}
                //else if (userPlayerSelection == "Neymar Jr." && userJerseyNumSelection != 10)
                //{
                //    Console.WriteLine("\nYour jersey selection, " + userJerseyNumSelection + " is Incorrect.");
                //    Console.WriteLine("As of July 18th, 2019 Neymar's jersey number is number 10 with PSG.");
                //}
                //else if (userPlayerSelection == "A. Griezman" && userJerseyNumSelection == 17)
                //{
                //    Console.WriteLine("\nYour jersey selection, " + userJerseyNumSelection + " is Correct!!");
                //    Console.WriteLine("As of July 18th, 2019 A. Griezman's jersey number is number 17 with Barcelona.");
                //}
                //else if (userPlayerSelection == "A. Griezman" && userJerseyNumSelection != 17)
                //{
                //    Console.WriteLine("\nYour jersey selection, " + userJerseyNumSelection + " is Incorrect.");
                //    Console.WriteLine("As of July 18th, 2019 A. Griezman's jersey number is number 17 with Barcelona.");
                //}
                //else
                //{
                //    Console.WriteLine("There was an error..");
                //}

                List<string> quitOrRestart = new List<string>();
                quitOrRestart.Add("Quit");
                quitOrRestart.Add("Restart");

                Console.WriteLine("\nEnter the Index number to select your your choice from our 'quitOrRestart' List (eg. '1' NOT 'index 1'):");
                for (int i = 0; i < quitOrRestart.Count; i++)
                {
                    Console.WriteLine("Index " + i + " = " + quitOrRestart[i]);
                }

                bool selectionPicked;
                do
                {
                    try
                    {
                        int quitOrRestartSelectionIndex = Convert.ToInt32(Console.ReadLine());
                        string quitOrRestartSelection = quitOrRestart[quitOrRestartSelectionIndex];
                        Console.WriteLine("\nYou have selected: '" + quitOrRestartSelection + "'.");
                        if(quitOrRestartSelection == "Quit")
                        {
                            Console.WriteLine("See you Later!");
                            Console.ReadLine();
                            run = false;
                            selectionPicked = true;
                        }
                        else if(quitOrRestartSelection == "Restart")
                        {
                            Console.WriteLine("We are now restarting");
                            run = true;
                            selectionPicked = true;
                        }
                        else
                        {
                            Console.WriteLine("An arror has occured.");
                            selectionPicked = false;
                        }
                        selectionPicked = true;
                    }
                    catch (ArgumentOutOfRangeException)
                    {
                        Console.WriteLine("Invalid Entry: Please select from the options provided.");
                        selectionPicked = false;
                    }
                    catch (FormatException)
                    {
                        Console.WriteLine("\nError: Your entry was invalid, please enter an integer.");
                        selectionPicked = false;
                    }
                }
                while (selectionPicked == false);


                
            }

            

        }
    }
}
