public class Reception : Event
{
    private string _RSVP;
    


    public Reception(string RSVP, string title, string description, DateTime date, int time, Address address) : base( title, description, date, time, address)
    {
        _RSVP = RSVP;
    
    }


    public string GetRSVP()
    {
        return $"{_RSVP}";
    }
   

    public void GetFullInformation()
    {
        Console.WriteLine($"- Reception Event \n {GetFullDetails()} \n RSVP: {GetRSVP()} ");
    }
}


