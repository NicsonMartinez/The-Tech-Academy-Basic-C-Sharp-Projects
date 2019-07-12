using System;

namespace Loops
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Console.WriteLine("Guess a number?");
            int number = Convert.ToInt32(Console.ReadLine());
            bool isGuessed = number == 12;

            //Note: Below is a Do-While loop.

            do
            {
                //NOTE: Here we are learning about the switch statement.
                //NOTE: You must write 'break' in each case or else it will do the next case.
                //NOTE: 'default' happens if none of the cases weren't true ('number' never equaled any of the cases).
                switch (number)
                {
                    case 62:
                        Console.WriteLine("You guessed 62. Try again.");
                        Console.WriteLine("Guess a number?");
                        number = Convert.ToInt32(Console.ReadLine());
                        break;
                    case 29:
                        Console.WriteLine("You guessed 29. Try again.");
                        Console.WriteLine("Guess a number?");
                        number = Convert.ToInt32(Console.ReadLine());
                        break;
                    case 55:
                        Console.WriteLine("You guessed 55. Try again.");
                        Console.WriteLine("Guess a number?");
                        number = Convert.ToInt32(Console.ReadLine());
                        break;
                    case 12:
                        Console.WriteLine("You guessed the number 12. That is Correct!");
                        isGuessed = true;
                        Console.ReadLine();
                        break;
                    default:
                        Console.WriteLine("You're wrong.");
                        Console.WriteLine("Guess a number?");
                        number = Convert.ToInt32(Console.ReadLine());
                        break;
                }
            }
            while (!isGuessed);

            /*NOTE: If we did the while loop (below) instead of the do-while loop if the user guessed the number in the first try
            it would have never eneterd the while loop (which we need to happen so that we can show the user they have 
            guessed the number correctly).
            */

            //while (!isGuessed)
            //{
            //    //NOTE: Here we are learning about the switch statement.
            //    //NOTE: You must write 'break' in each case or else it will do the next case.
            //    //NOTE: 'default' happens if none of the cases weren't true ('number' never equaled any of the cases).
            //    switch (number)
            //    {
            //        case 62:
            //            Console.WriteLine("You guessed 62. Try again.");
            //            Console.WriteLine("Guess a number?");
            //            number = Convert.ToInt32(Console.ReadLine());
            //            break;
            //        case 29:
            //            Console.WriteLine("You guessed 29. Try again.");
            //            Console.WriteLine("Guess a number?");
            //            number = Convert.ToInt32(Console.ReadLine());
            //            break;
            //        case 55:
            //            Console.WriteLine("You guessed 55. Try again.");
            //            Console.WriteLine("Guess a number?");
            //            number = Convert.ToInt32(Console.ReadLine());
            //            break;
            //        case 12:
            //            Console.WriteLine("You guessed the number 12. That is Correct!");
            //            isGuessed = true;
            //            Console.ReadLine();
            //            break;
            //        default:
            //            Console.WriteLine("You're wrong.");
            //            Console.WriteLine("Guess a number?");
            //            number = Convert.ToInt32(Console.ReadLine());
            //            break;
            //    }
            //}

        }
    }
}
