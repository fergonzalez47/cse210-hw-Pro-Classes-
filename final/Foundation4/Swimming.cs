public class Swimming : Activity
{
    private float _laps;

    public Swimming(string name, float laps, DateTime date, int minutes) : base(name, date, minutes)
    {
        _laps = laps;
    }

    // public void GetSummary()
    // {
    //     Console.WriteLine("");
    // }
}