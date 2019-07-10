using System;

class VariableAndDataTypeDrill
{
    static void Main(string[] args)
    {

        //The purpose of this drill is to store information to a corresponding variable with a suitable data type.
        //Thus there is no logic for exception handling.
        Console.WriteLine("\nThe Tech Academy");
        Console.WriteLine("Student Daily Report\n");

        Console.WriteLine("What course are you on?");
        string userCourse = Console.ReadLine();

        Console.WriteLine("\nWhat page number?");
        string userPageNumber = Console.ReadLine();

        int userPageNumberInt = Convert.ToInt32(userPageNumber);

        Console.WriteLine("\nDo you need help with anything? Please answer \"true\" or \"false\".");
        string helpAnswer = Console.ReadLine();
        bool helpAnswerBool = Convert.ToBoolean(helpAnswer);

        Console.WriteLine("\nWere there any positive experiences you’d like to share? Please give Specifics.");
        string userExperiences = Console.ReadLine();

        Console.WriteLine("\nIs there any other feedback you’d like to provide? Please be specific.");
        string userFeedback = Console.ReadLine();

        Console.WriteLine("\nHow many hours did you study today?");
        string userStudyHours = Console.ReadLine();
        int userStudyHoursInt = Convert.ToInt32(userStudyHours);

        Console.WriteLine("\nThank you for your answers. An Instructor will respond to this shortly. Have a great day!");
        Console.ReadLine();
    }
}