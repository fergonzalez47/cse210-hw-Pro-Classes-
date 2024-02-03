using System.IO;
using System.Linq.Expressions;
using System.Runtime.CompilerServices;
public class ReflectingActivity : Activity
{
    private List<string> _questions = new List<string>();
    private List<string> _prompts = new List<string>();



    public ReflectingActivity(string name, string description) : base(name, description)
    {

    }

    public void Run()
    {
        Random random = new Random();
        
        DateTime loopTime = DateTime.Now.AddSeconds(GetSeconds());


        Console.WriteLine("");
        Console.WriteLine("Consider the following prompt:");
        Console.WriteLine("");
        DisplayPrompt("prompts.txt");
        Console.WriteLine("");
        Console.WriteLine("When you have something in mind, press enter to continue");
        string enter = Console.ReadLine();
        Console.WriteLine("");

        if (string.IsNullOrEmpty(enter.Trim()))
        {
            Console.WriteLine("Now ponder on each of the following questions as they are related to this experience.");
            Console.Write("You may begin in: ");
            ShowCountDown(5);

            Console.Clear();
            while (DateTime.Now < loopTime)
            {
                DisplayQuestion("questions.txt");
                ShowSpinner(random.Next(10, 13));
            }
        }
        DisplayEndingMessage();
    }

    private void DisplayPrompt(string filePath)
    {
        try
        {
            _prompts.Clear();
            _prompts = File.ReadAllLines(filePath).ToList();
            Random random = new Random();
            int prompt = random.Next(0, _prompts.Count());
            Console.WriteLine($" --- {_prompts[prompt]} ---");

        }
        catch (Exception ex)
        {
            Console.WriteLine($"Error reading file: {ex.Message}");
        }
    }


    private void DisplayQuestion(string file)
    {
        try
        {
            _questions.Clear();
            _questions = File.ReadAllLines(file).ToList();
            Random random = new Random();
            int question = random.Next(0, _questions.Count());
            Console.WriteLine($" > {_questions[question]} ");

        }
        catch (Exception ex)
        {
            Console.WriteLine($"Error reading file: {ex.Message}");
        }
    }

}

