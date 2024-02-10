public class SimpleGoal : Goal {
    private bool _isComplete;


    public SimpleGoal(string name, string description, string points) : base( name,  description,  points)
    {
        _isComplete = false;
    }

    public override void RecordEvent() {
        SetIsCompleted(true);
        IsCompleted();
        if (IsCompleted() == true)
        {
            Console.WriteLine($"Congratulations! You have earned {GetPoints()} points!");
            Console.WriteLine("");
        }
    }
    public override bool IsCompleted() {
        if (_isComplete == true ) {
            return true;
        }
        else {
            return false;
        }
    }
    public override string GetStringRepresentation() {
        
        return $"SimpleGoal:{GetShortName()},{GetDescription()},{GetPoints()},{IsCompleted()}";
    }

public void SetIsCompleted(bool arg) {
        _isComplete = arg;
}


}