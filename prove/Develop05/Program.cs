using System;

class Program
{
    //I added verification to see if the user input a number that is not related to a goal, do nothing and return a error message.
    static void Main(string[] args)
    {
        GoalManager manager = new GoalManager();
        Console.Clear();
        manager.Start();
    }
}