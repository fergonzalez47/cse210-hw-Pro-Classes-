public class Cycling : Activity
{
    private float _speed;

    public Cycling(string name, float speed, DateTime date, int minutes) : base(name, date, minutes)
    {
        _speed = speed;
    }

    // public void GetSummary()
    // {
    //     Console.WriteLine("");
    // }
}