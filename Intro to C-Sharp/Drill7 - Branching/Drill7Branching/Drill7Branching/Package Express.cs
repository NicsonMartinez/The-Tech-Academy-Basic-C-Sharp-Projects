/*
EXERCISE: BRANCHING
Your job is to create a console-based application for getting a shipping quote for a package.

REQUIREMENTS
The first line of the program must be: “Welcome to Package Express. Please follow the instructions below.”

The user must then be prompted for the package weight.

If the weight is greater than 50, display the error message, “Package too heavy to be shipped via Package Express. Have a good day.” 
At this point the program would end.

The user must then be prompted for the package width.

Then the package height.

Then the package length.

If the sum of the dimensions is greater than 50, display the error message, “Package too big to be shipped via Package Express.” 
At this point the program would end.

The sum total of dimensions are then multiplied by the weight and divided by 100.

The result of that calculation is the quote.

Display the quote to the user as a dollar amount.

EXAMPLE
Welcome to Package Express. Please follow the instructions below.
Please enter the package weight:
40
Please enter the package width:
5
Please enter the package height:
 3
Please enter the package length:
 3
Your estimated total for shipping this package is: $4.40
Thank you.
*/


using System;

namespace Drill7Branching
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Package Express. Please follow the instructions below.");
            Console.WriteLine("Please enter the package weight:");
            decimal userPackageWeight = Convert.ToDecimal(Console.ReadLine());
            if (userPackageWeight < 50)
            {
                Console.WriteLine("Please enter the package width:");
                decimal userPackageWidth = Convert.ToDecimal(Console.ReadLine());
                Console.WriteLine("Please enter the package height:");
                decimal userPackageHeight = Convert.ToDecimal(Console.ReadLine());
                Console.WriteLine("Please enter the package length:");
                decimal userPackageLength = Convert.ToDecimal(Console.ReadLine());
                decimal userPackageDimention = userPackageWidth + userPackageHeight + userPackageLength;
                if (userPackageDimention < 50)
                {
                    decimal quote = (userPackageDimention * userPackageWeight) / 100;
                    //NOTE: I went here to learn about string formatting 'quote.ToString("#,##0.00") https://docs.microsoft.com/en-us/dotnet/standard/base-types/formatting-types
                    Console.WriteLine("Your estimated total for shipping this package is: $" + quote.ToString("#,##0.00"));
                    Console.WriteLine("Thank You.");
                    Console.ReadLine();
                }
                else
                {
                    Console.WriteLine("Package too big to be shipped via Package Express.");
                    Console.ReadLine();
                }
            }
            else
            {
                Console.WriteLine("Package too heavy to be shipped via Package Express. Have a good day.");
                Console.ReadLine();
            }
        }
    }
}
