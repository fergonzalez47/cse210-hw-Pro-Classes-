public abstract class Activity {
    private string _name;
    private DateTime _date;
    private int _minutes;

    public Activity(string name, DateTime date, int minutes) {
        _date = date;
        _minutes = minutes;
        _name = name;
    }

    public string  GetSummary() {
        return $"{GetDate()} {GetName()} ({GetMinutes()} min) Distance {GetDistanceCal()} Km, Speed {GetSpeedCal()}, Psce: {GetPaceCal()} min per Km";
    }

    public virtual string GetDistanceCal() 
    {
        return $"";
    }
    public virtual float GetSpeedCal()
    {
        return 0;
    }
    public virtual float GetPaceCal()
    {
        return 0;
    }

    public string GetDate() {
        return _date.ToString("yyyy-MM-dd");
    }

    public int GetMinutes()
    {
        return _minutes;
    }
    public string GetName()
    {
        return $"{_name}";
    }
}