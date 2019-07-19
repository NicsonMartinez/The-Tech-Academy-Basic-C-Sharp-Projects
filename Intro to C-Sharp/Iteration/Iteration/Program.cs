using System;
using System.Collections.Generic;

namespace Iteration
{
    class Program
    {
        static void Main(string[] args)
        {
            //NOTE: Below are for loops for arrays and for loops for lists in C#

            //------------------------------------------------------------------------------------------------

            //int[] testScores = { 98, 99, 85, 70, 82, 34, 91, 90, 94 };

            //for (int i = 0; i < testScores.Length; i++)
            //{
            //    if (testScores[i] > 85)
            //    {
            //        Console.WriteLine("Passingg test score: " + testScores[i]);
            //    }
            //}

            //------------------------------------------------------------------------------------------------

            //string[] names = { "Nicson", "Erik", "Daniel", "Adam" };

            //for (int j = 0; j < names.Length; j++)
            //{
            //    if (names[j] == "Nicson")
            //    {
            //        Console.WriteLine(names[j]);
            //    }
            //}
            //Console.ReadLine();

            //------------------------------------------------------------------------------------------------

            //List<int> testScores1 = new List<int>();
            //testScores1.Add(98);
            //testScores1.Add(99);
            //testScores1.Add(81);
            //testScores1.Add(72);
            //testScores1.Add(70);

            ////NOTE: To iterate through a list, 'foreach' is used.

            //foreach (int score in testScores1)
            //{
            //    if (score > 85){
            //        Console.WriteLine("Pssing test score:" + score);
            //    }
            //}
            //Console.ReadLine();

            //------------------------------------------------------------------------------------------------

            //List<string> names = new List<string>() { "Nicson", "Erik", "Daniel", "Adam" };

            //foreach (string name in names)
            //{
            //    Console.WriteLine(name);
            //}
            //Console.ReadLine();

            //------------------------------------------------------------------------------------------------

            List<int> testScores = new List<int>() { 98, 99, 12, 74, 23, 99 };

            //NOTE: With an array you have to define the length where as with a list you can just instantiate 
            //an empty one since it can be manipulated later
            List<int> passingScores = new List<int>();

            foreach (int score in testScores)
            {
                if (score > 85)
                {
                    passingScores.Add(score);
                }
            }

            //NOTE: To get the length of an array you use object.Length and for lists you use object.Count. 
            Console.WriteLine(passingScores.Count);
            Console.ReadLine();
        }
    }
}
