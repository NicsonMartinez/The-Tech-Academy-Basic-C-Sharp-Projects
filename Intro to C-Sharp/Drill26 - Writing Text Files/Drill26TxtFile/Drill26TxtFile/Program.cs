/*
EXERCISE:
IN A CONSOLE APP, CREATE CODE THAT DOES THE FOLLOWING:
1. Ask a user for a number.

2. Log that number to a text file.

3. Print the text file back to the user.
*/

using System;
using System.IO;

namespace Drill26TxtFile
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello user! Write a number so we can log it in a log file.");
            string userInput = Console.ReadLine();
            File.WriteAllText(@"C:/log/log.txt", userInput);

            string textRead = File.ReadAllText(@"C:/log/log.txt");
            Console.WriteLine("\nLog.txt:\n"+textRead);
            Console.ReadLine();

        }
    }
}
