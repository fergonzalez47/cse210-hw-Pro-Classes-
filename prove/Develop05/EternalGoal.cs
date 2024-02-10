public class EternalGoal : Goal
{


    public EternalGoal(string name, string description, string points) : base(name, description, points)
    {

    }

    public override void RecordEvent()
    {
        Console.WriteLine($"Congratulations! You have earned {GetPoints()} points!");
        Console.WriteLine("");
    }
    public override bool IsCompleted()
    {
        return false;
    }
    public override string GetStringRepresentation()
    {

        return $"EternalGoal:{GetShortName()},{GetDescription()},{GetPoints()}";
    }

}