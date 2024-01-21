public class Entry
{
    public String _date = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss");
    public String _prompText = "";
    public String _entryText = "";

    public void Display()
    {
        if (_date == "" || _prompText == "" || _entryText == "")
        {
            Console.WriteLine($"An error occurred..(entry).Sorry!");
        }
        else
        {
            Console.WriteLine($"Date: {_date} - Prompt: {_prompText} - \n{_entryText}\n");
            
        }
    }

}