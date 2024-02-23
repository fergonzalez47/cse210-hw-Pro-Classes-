public class Lecture : Event
{
    private string _speaker;
    private int _capacity;
    private string _type;


    public Lecture(string speaker, int capacity, string title, string description, DateTime date, int time, Address address) : base( title, description, date, time, address)
    {
        _speaker = speaker;
        _capacity = capacity;
        _type = "Lecture Event";
    }

    
    public string GetSpeaker() {
        return $"{_speaker}";
    }
    public string GetCapacity()
    {
        return $"{_capacity}";
    }

    public void GetFullInformation()
    {
        Console.WriteLine($"- {_type} \n {GetFullDetails()} \n - Speaker: {GetSpeaker()} \n - Capacitiy: {GetCapacity()}");
    }
    
}


