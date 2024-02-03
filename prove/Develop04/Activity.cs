

public class Activity
{
    private string _name;
    private string _description;
    private int _seconds;



    public Activity(string name, string description)
    {
        _name = name;
        _description = description;
        _seconds = 30;
    }

    public Activity(string name, string description, int seconds)
    {
        _name = name;
        _description = description;
        _seconds = seconds;
    }


    public void SetSeconds(int seconds) {
        _seconds = seconds;
}
    public string GetName()
    {
        return _name;
    }
    public string GetDescription()
    {
        return _description;
    }
    public int GetSeconds()
    {
        return _seconds;
    }

    public void DisplayStartingMessage()
    {
        Console.Clear();
        Console.WriteLine($"Welcome to the {_name} Activity.");
        Console.WriteLine("");
        Console.WriteLine($"{_description}");
        Console.WriteLine("");
        bool condition = true;
        while (condition)
        {
            Console.Write("How long, in seconds, would you like for your session? ");
            string input = Console.ReadLine();
            if (int.TryParse(input, out int seconds))
            {
                SetSeconds(seconds);
                condition = false;
            }
            else
            {
                Console.WriteLine("Invalid input. Please enter seconds in valid number. Example: 45");
            }
        }
        Console.Clear();
        Console.WriteLine("Get ready...");
        ShowSpinner(5);
    }

        public void DisplayEndingMessage()
    {
        Console.WriteLine("");
        Console.WriteLine("");
        Console.WriteLine($"Well Done!!");
        ShowSpinner(5);
        Console.WriteLine($"");
        Console.WriteLine($"You have completed another {_seconds} seconds of the {_name} Activity.");
        ShowSpinner(5);
    }

    public void ShowSpinner(int seconds) {

        List<string> spinner = new List<string>{
            "|",
            "/",
            "-",
            "\\",
        };
        int i = 0;

        DateTime time = DateTime.Now.AddSeconds(seconds);

        while (DateTime.Now < time)
        {
            string s = spinner[i];
                Console.Write(s);
                Thread.Sleep(500);
                Console.Write("\b \b");
            i++;

            if (i >= spinner.Count())
            {
                i = 0;
            }
        
        }

    }

    public void ShowCountDown(int seconds)

    {
        for (int i = seconds; i > 0; i--)
        {
            Console.Write(i);
            Thread.Sleep(1000);
            Console.Write("\b \b");
        }
    }
}