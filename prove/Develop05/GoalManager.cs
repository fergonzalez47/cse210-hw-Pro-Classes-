public class GoalManager
{
    private List<Goal> _goals = new List<Goal>();
    private int _score = 0;


    public GoalManager()
    {

    }
    public void Start()
    {

        int condition = 1;

        while (condition != 0)
        {
            Console.WriteLine("");
            DisplayPlayerInfo();
            Console.WriteLine("");
            Console.WriteLine("Menu Options: ");
            Console.WriteLine(" 1. Create New Goal");
            Console.WriteLine(" 2. List Goals");
            Console.WriteLine(" 3. Save Goals");
            Console.WriteLine(" 4. Load Goals");
            Console.WriteLine(" 5. Record Event");
            Console.WriteLine(" 6. Quit");
            Console.Write("Select a choice from the menu: ");
            string optionStr = Console.ReadLine();

            if (int.TryParse(optionStr, out int option))
            {
                if (option == 6)
                {
                    condition = 0;
                }
                else if (option == 1)
                {
                    CreateGoal();
                }
                else if (option == 2)
                {

                    ListGoalDetails();
                }
                else if (option == 3)
                {
                    Console.Write("What is the name for the goal file? ");
                    string filename = Console.ReadLine();
                    SaveGoals(filename);

                }
                else if (option == 4)
                {

                    Console.Write("What is the name of the goal file? ");
                    string filename = Console.ReadLine();
                    LoadGoals(filename);
                }
                else if (option == 5)
                {

                    RecordEvent();
                }
                else
                {
                    Console.WriteLine("Invalid input. Please enter a valid number.");
                }
            }
        }
    }

    //GET AND SET ATT
    public string GetScore()
    {
        return $"{_score}";
    }
    public void SetScore(int score)
    {
        _score += score;
    }
    public void DisplayPlayerInfo()

    {
        Console.WriteLine($"You have {GetScore()} points.");
    }
    public void ListGoalNames()
    {
        for (int i = 0; i < _goals.Count; i++)
        {
            Goal goal = _goals[i];
            Console.WriteLine($"{i + 1}. {goal.GetShortName()}");
        }
    }

    public void ListGoalDetails()
    {
        for (int i = 0; i < _goals.Count; i++)
        {
            Goal goal = _goals[i];
            Console.WriteLine($"{i + 1}. {goal.GetDetailsString()}");
        }
    }

    private void CreateGoal()
    {
        Console.WriteLine("");
        Console.WriteLine(" The types of Goals are:");
        Console.WriteLine(" 1. Simple Goal");
        Console.WriteLine(" 2. Eternal Goal");
        Console.WriteLine(" 3. Checklist Goal");
        Console.Write("Which type of goal would you like to create? ");
        string optionGoal = Console.ReadLine();

        //Capturing inputs from the user
        Console.Write("What is the name of your goal? ");
        string goalName = Console.ReadLine();
        Console.Write("What is a short description of it? ");
        string goalDescription = Console.ReadLine();
        Console.Write("What is the amount of points associated with this goal? ");
        string goalPoints = Console.ReadLine();


        if (int.TryParse(optionGoal, out int goalInt))
        {
            if (goalInt == 1)
            {
                SimpleGoal goal = new SimpleGoal(goalName, goalDescription, goalPoints);
                _goals.Add(goal);
            }
            else if (goalInt == 2)
            {
                EternalGoal goal = new EternalGoal(goalName, goalDescription, goalPoints);
                _goals.Add(goal);
            }
            else if (goalInt == 3)
            {
                Console.Write("How many times does this goal need to be accomplished for a bonus? ");
                string goalTarget = Console.ReadLine();
                if (int.TryParse(goalTarget, out int goalTargetInt))
                {

                    Console.Write("What is the bonus for accomplishing it that many times? ");
                    string goalBonus = Console.ReadLine();
                    if (int.TryParse(goalBonus, out int goalBonusInt))
                    {
                        ChecklistGoal goal = new ChecklistGoal(goalName, goalDescription, goalPoints, int.Parse(goalTarget), int.Parse(goalBonus));
                        _goals.Add(goal);
                    }
                    else
                    {
                        Console.Write("Bonus need to be a number. Please repeat ");
                    }
                }
                else
                {
                    Console.Write("Times need to be in number format. Please repeat ");
                }
            }
            else
            {
                Console.WriteLine(" X Invalid goal number X ");

            }
        }
    }

    public void RecordEvent()
    {
        ListGoalNames();
        Console.Write("Which goal did you accomplish? ");
        string strGoal = Console.ReadLine();
        int numGoal = int.Parse(strGoal);
        if ((numGoal - 1) > _goals.Count)
        {
            Console.Write("There is no goal with that number");
        }
        else {
            _goals[numGoal - 1].RecordEvent();
            SetScore(int.Parse(_goals[numGoal -1].GetPoints()));
            Console.Write($"You now have {GetScore()} points");
            Console.Write("");
        }
    }
    public void SaveGoals(string file)
    {
        Console.WriteLine("Saving to file...");
        if (!string.IsNullOrEmpty(file))
        {
            string fileName = file;

            using (StreamWriter myFile = new StreamWriter(fileName))
            {
                myFile.WriteLine($"{GetScore()}");
                foreach (Goal goal in _goals)
                {
                    myFile.WriteLine($"{goal.GetStringRepresentation()}");
                }
            }
        }
        else
        {
            Console.WriteLine("The file name can't be empty!");
        }
    }
    public void LoadGoals(string file)
    {
        if (!string.IsNullOrEmpty(file) && File.Exists(file))
        {
            _goals.Clear();

            string[] lines = System.IO.File.ReadAllLines(file);

            SetScore(int.Parse(lines[0]));
            foreach (string line in lines)
            {   
                string[] typeOfGoal = line.Split(":");
                if (typeOfGoal[0] == "SimpleGoal")
                {
                    string[] parts = typeOfGoal[1].Split(",");

                    if (parts.Length >= 4)
                    {
                        SimpleGoal goal = new SimpleGoal(parts[0], parts[1], parts[2]);
                        goal.SetIsCompleted(bool.Parse(parts[3]));
                        _goals.Add(goal);
                    }
                    else
                    {
                        Console.WriteLine($"Invalid entry format: {parts}");
                    }
                }
                else if (typeOfGoal[0] == "EternalGoal")
                {
                    string[] parts = typeOfGoal[1].Split(",");

                    if (parts.Length >= 3)
                    {
                        EternalGoal goal = new EternalGoal(parts[0], parts[1], parts[2]);
                        _goals.Add(goal);
                    }
                    else
                    {
                        Console.WriteLine($"Invalid entry format: {parts}");
                    }
                }
                else if (typeOfGoal[0] == "ChecklistGoal")
                {
                    string[] parts = typeOfGoal[1].Split(",");

                    if (parts.Length >= 6)
                    {
                        ChecklistGoal goal = new ChecklistGoal(parts[0], parts[1], parts[2], int.Parse(parts[4]), int.Parse(parts[3]));
                        goal.SetAmountCompleted(int.Parse(parts[5]));
                        _goals.Add(goal);
                    }
                    else
                    {
                        Console.WriteLine($"Invalid entry format: {parts}");
                    }
                }

            }

            Console.WriteLine("File loaded successfully.");
        }
        else
        {
            Console.WriteLine("Invalid file name or file does not exist.");
        }
    }

}
