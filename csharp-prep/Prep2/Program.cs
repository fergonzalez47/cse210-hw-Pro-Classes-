using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("Hello, Pease enter the grade percentage: ");
        string percentage = Console.ReadLine();
        int percentageInt = int.Parse(percentage);
        string letter = "";

        if (percentageInt >= 100)
        {
            Console.WriteLine("Grade percentage can not be greater than 100");
        }
        else if (percentageInt >= 90)
        {
            letter = "A";
        }
        else if (percentageInt >= 80)
        {
            letter = "B"; ;
        }
        else if (percentageInt >= 70)
        {
            letter = "C";
        }
        else if (percentageInt >= 60)
        {
            letter = "D";
        }
        else
        {
            letter = "E";
        }

        if (percentageInt < 70)
        {
            Console.WriteLine("Letter grade: " + letter);
            Console.WriteLine("Sorry, you must have at least a 70 to pass the class.");
            Console.WriteLine("Prepare better for next time, you can do it");
        }
        else 
        {
            Console.WriteLine("Letter grade: " + letter);
            Console.WriteLine("Congratulations! keep working!");
        }
    }
}