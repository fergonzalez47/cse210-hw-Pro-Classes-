using System;

class Program
{
    static void Main(string[] args)
    {

        DisplayWelcome();
        string name = PromptUserName();
        int preferNumber = PromptUserNumber();
        int square = SquareNumber(preferNumber);
        DisplayResult(name, square);

    }


    static void DisplayWelcome()
    {
        Console.WriteLine("Welcome to the Program!");
    }
    static string PromptUserName()
    {
        Console.Write("Please enter your name: ");
        string userName = Console.ReadLine();
        return userName;
    }
    static int PromptUserNumber()
    {
        Console.Write("Please enter your favorite number:");
        string preferNumberStr = Console.ReadLine();
        int preferNumber = int.Parse(preferNumberStr);
        return preferNumber;
    }
    static int SquareNumber(int param)
    {
        int square = param * param;
        return square;
    }
    static void DisplayResult(string name, int square)
    {
        Console.WriteLine($"{name}, the square of your number is {square}");
    }
}