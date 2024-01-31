using System;

class Program
{
    static void Main(string[] args)
    {
        Assignment obj = new Assignment("Fernando", "CSE210");
        Console.WriteLine(obj.GetSummary());

        MathAssignment mathObj = new MathAssignment("Roberto Rodrigez", "Fractions", "7.3", "8-19");
        Console.WriteLine(mathObj.GetSummary());
        Console.WriteLine(mathObj.GetHomeworkList());

        WritingAssignment writingObj = new WritingAssignment("Mary Waters", "European History", "The Causes of World War II");
        Console.WriteLine(writingObj.GetSummary());
        Console.WriteLine(writingObj.GetWritingInformation());

    }
}