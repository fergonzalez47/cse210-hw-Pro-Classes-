public class Event
{
    private string _title;
    private string _description;
    private DateTime _date;
    private int _time;
    private Address _address;
   


    public Event( string title, string description, DateTime date, int time, Address address)
    {
        
        _title = title;
        _description = description;
        _date = date;
        _time = time;
        _address = address;
    }
    public string GetStandardDetails()
    {
        return $"Title: {GetTitle()}\n Description: {GetDescription()}\n Date: {GetDate()}\n Time: {GetTime()}\n Address: {_address.GetFullAddress()}";
    }


    public string GetShortDescription()
    {
        return $"- Title: {GetTitle()}\n - Date: {GetDate()}\n ";
    }


    public string GetFullDetails()
    {
        return $" -Title: {GetTitle()}\n - Description: {GetDescription()}\n - Date: {GetDate()}\n - Time: {GetTime()}\n - Address: {_address.GetFullAddress()}";
    }



    public string GetTitle()
    {
        return $"{_title}";
    }
    public string GetDescription()
    {
        return $"{_description}";
    }
    public string GetDate()
    {
        return _date.ToString("yyyy-MM-dd");
    }


    public string GetTime()
    {
        int min = _time / 60;
        int seconds = _time % 60;
        return $"{min}:{seconds:D2} min";
    }



}