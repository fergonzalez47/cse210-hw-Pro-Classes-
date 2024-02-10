public abstract class Goal
{
    private string _shortName;
    private string _description;
    private string _points;


    public Goal(string name, string description, string points)
    {
        _shortName = name;
        _description = description;
        _points = points;
    }


    public abstract void RecordEvent();
    public abstract bool IsCompleted();
    public abstract string GetStringRepresentation();

    public virtual string GetDetailsString() {

        string check = " ";

        if (IsCompleted())
        {
            check = "X";
            
        }


        return $"[{check}] {GetShortName()} ({GetDescription()})";
    }

    public string GetShortName() {
        return $"{_shortName}";
    }

    public string GetDescription()
    {
        return $"{_description}";
    }

    public string GetPoints()
    {
        return $"{_points}";
    }
    public void SetShortName(string shortName)
    {
        _shortName = shortName;
    }

    public void SetDescription(string description)
    {
        _description = description;
    }

    public void SetPoints(string points)
    {
        _points = points;
    }


}