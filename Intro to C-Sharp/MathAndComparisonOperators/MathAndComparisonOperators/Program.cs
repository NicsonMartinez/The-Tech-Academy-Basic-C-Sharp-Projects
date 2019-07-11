using System;

namespace MathAndComparisonOperators
{
    class Program
    {
        static void Main(string[] args)
        {
            //int total = 5 + 10;
            //int otherTotal = 12 + 22;
            //int combined = total + otherTotal;
            ////Console.WriteLine("Five plus Ten = " + total.ToString());
            //Console.WriteLine(combined);
            //Console.ReadLine();

            //int difference = 10 - 5;
            //Console.WriteLine("Ten minus Five = " + difference.ToString());
            //Console.ReadLine();

            //int product = 10 * 5;
            //Console.WriteLine(product);
            //Console.ReadLine();

            //double quotient = 100.0 / 17.0;
            ////NOTE: When you do 'int quotient = 100 / 17;' it rounds Answer = 5;
            ////NOTE: But when you do 'double quotient = 100.0 / 17.0;' the Answer = 5.88235294117647
            //Console.WriteLine(quotient);
            //Console.ReadLine();

            ////NOTE: By using the Modulus operator, you can find our if a number is even or odd.
            //int remainder = 11 % 2;
            //Console.WriteLine(remainder);
            //Console.ReadLine();

            //bool trueOrFalse = 12 < 5;
            //Console.WriteLine(trueOrFalse.ToString()); //NOTE: here we are casting a bool type to a string before writing on the console.
            //Console.ReadLine();

            int roomTemperature = 70;
            int currentTemperature = 70;

            //bool isWarm = currentTemperature >= roomTemperature;
            bool isWarm = currentTemperature != roomTemperature;
            Console.WriteLine(isWarm);
            Console.WriteLine();
        }
    }
}
