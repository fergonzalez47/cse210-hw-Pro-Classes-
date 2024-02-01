using System;
public class BreathingActivity : Activity
{

    public void Run()
    {
        DateTime loopTime = DateTime.Now.AddSeconds(GetSeconds());
        Random random = new Random();
        Console.Clear();
        Console.WriteLine("Get ready...");
        ShowSpinner(5);

        while (DateTime.Now < loopTime)
        {
            Console.WriteLine("");
            Console.WriteLine("");
            Console.Write("Breathe in...");
            ShowCountDown(random.Next(3, 6));
            Console.WriteLine("");
            Console.Write($"Now breathe out...");
            ShowCountDown(random.Next(3, 6));
        }
        DisplayEndingMessage();


    }


    public BreathingActivity(string name, string description) : base(name, description)
    {

    }
}

