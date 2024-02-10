public class ChecklistGoal : Goal
{
    private int _amountCompleted;
    private int _target;
    private int _bonus;

    public ChecklistGoal(string name, string description, string points, int target, int bonus) : base(name, description, points)
    {
        _target = target;
        _bonus = bonus;
        _amountCompleted = 0;
    }
    public override string GetDetailsString() {
        bool condition = IsCompleted();
        string check = " ";

        if (condition == true)
        {
            check = "X";
        }


        return $"[{check}] {GetShortName()} ({GetDescription()}) -- Currently completed {GetAmountCompleted()}/{GetTarget()}";
    }

    public override void RecordEvent()
    {
        SetAmountCompleted(1);
        if (IsCompleted())
        {
            int totalPoints = GetBonus() + int.Parse(GetPoints());
            Console.WriteLine($"Congratulations! You have earned {totalPoints} points!");
        }
        else {
            Console.WriteLine($"Congratulations! You have earned {GetPoints()} points!");
        }
        Console.WriteLine("");
    }
    public override bool IsCompleted()
    {
        if (GetTarget()  == GetAmountCompleted())
        {
            return true;
        }
        else
        {
            return false;
        }
    }
    public override string GetStringRepresentation()
    {

        return $"ChecklistGoal:{GetShortName()},{GetDescription()},{GetPoints()},{GetBonus()},{GetTarget()},{GetAmountCompleted()}";
    }

    public int GetAmountCompleted()
    {
        return _amountCompleted;
    }
    public void SetAmountCompleted(int amount)
    {
        _amountCompleted += amount;
    }
    public int GetTarget()
    {
        return _target;
    }
    public int GetBonus()
    {
        return _bonus;
    }


}