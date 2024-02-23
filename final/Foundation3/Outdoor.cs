public class Outdoor : Event
{
    private string _weather;



    public Outdoor(string weather, string title, string description, DateTime date, int time, Address address) : base(title, description, date, time, address)
    {
        _weather = weather;

    }


    public string GetWeather()
    {
        return $"{_weather}";
    }


    public void GetFullInformation()
    {
        Console.WriteLine($"- Outdoor Event \n {GetFullDetails()} \n Weather: {GetWeather()} ");
    }
}


