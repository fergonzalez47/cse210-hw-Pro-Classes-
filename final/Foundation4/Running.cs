public class Running : Activity
{
    private float _distance;

    public Running(string name, float distance, DateTime date, int minutes) : base(name, date, minutes)
    {
        _distance = distance;
    }

    public override string GetDistanceCal() {
        return $"{GetDistance()}";
    }


    public override float GetSpeedCal()
    {
        float speed = GetMinutes() / GetDistance();
        return speed;
    }
    public override float GetPaceCal()
    {
        float pace = GetSpeedCal() / GetDistance();
        return pace;
    }


    public float GetDistance()
    {
        return _distance;
    }
}