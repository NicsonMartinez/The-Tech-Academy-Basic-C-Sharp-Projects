/*
EXERCISE:
IN A CONSOLE APP, CREATE CODE THAT DOES THE FOLLOWING:
1. Do a boolean comparison using a while statement.

2. Do a boolean comparison using a do while statement.

By: Nicson Martinez
Date: 7/12/19
*/
using System;

namespace Drill8Loops
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Please type the word 'start' to start the program, or 'stop' to stop the program: ");
            string programState = Console.ReadLine();

            //I only initialized this variable 'isStart', and didn't assign it a value because it will get reassigned 
            //below right away in the line that says 'isStart = programState == "start"';
            bool isStart; 

            //This starts my Do-While loop.
            do
            {
                isStart = programState == "start" || programState == "restart";
                //Here 'isStart' has a value of true if programState is equal to 'start' or 'restart'. 

                if (isStart)
                {
                    //Even though It wasn't required for this assignement, I added exception handling so in case the user doesn't enter an integer as asked.
                    try
                    {
                        Console.WriteLine("This is The Count Down Program!");
                        Console.WriteLine("Please eneter an integer greater than zero so we can do a count down: ");
                        int userNum = Convert.ToInt32(Console.ReadLine());

                        bool isHigherThanZero = userNum > 0;

                        if (userNum > 0)
                        {
                            Console.WriteLine("Here We go!!");
                            //This starts my While loop.
                            while (isHigherThanZero)
                            {
                                if (userNum != 0)
                                {
                                    userNum = userNum - 1;
                                    Console.WriteLine(userNum);
                                }
                                else
                                {
                                    break;
                                }
                            }
                        }

                        //At this point the user can decide to restart or stop the program by changing the 'programState'
                        Console.WriteLine("We're done!!");
                        Console.WriteLine("Please type the word 'restart' to restart 'The Count Down Program', or 'stop' to stop: ");
                        programState = Console.ReadLine();
                    }
                    catch (FormatException)
                    {
                        Console.WriteLine("Error: Your enry was invalid, please enter an integer.");

                        //By setting 'isStart' to true,  I am making the program stay in the loop thus asking the user to enter an integer again.
                        isStart = true;
                    }
                }
                else
                {
                    //This is done if the user wants to stp the program.
                    if (programState == "stop")
                    {
                        Console.WriteLine("The program was stopped. Thank You!");
                        Console.WriteLine("In order to start again you must close and reopen the application.");
                        Console.ReadLine();
                    }

                    //This happens if the user doesn't type either 'start' or 'stop' as told.
                    else
                    {
                        Console.WriteLine("Sorry, your enrty was invalid..");
                        Console.WriteLine("Please type the word 'start' to start the program, or 'stop' to stop the program: ");
                        programState = Console.ReadLine();

                        //This line will keep the user in the loop.
                        isStart = true;
                    }

                }

            }
            while (isStart);  
        }
    }
}
