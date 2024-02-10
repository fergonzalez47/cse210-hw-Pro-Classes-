public class ChecklistGoal : Goal
{
    private int _amountCompleted;
    private int _target;
    private int _bonus;

    public ChecklistGoal(string name, string description, string points, int target, int bonus) : base(name, description, points)
    {
        _target = target;
        _bonus = bonus;
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

    }
    public override bool IsCompleted()
    {
        return false;
    }
    public override string GetStringRepresentation()
    {

        return $"ChecklistGoal:{GetShortName()},{GetDescription()},{GetPoints()},{GetBonus()},{GetTarget()},{GetAmountCompleted()}";
    }

    public string GetAmountCompleted()
    {
        return $"{_amountCompleted}";
    }
    public string GetTarget()
    {
        return $"{_target}";
    }
    public string GetBonus()
    {
        return $"{_bonus}";
    }


}