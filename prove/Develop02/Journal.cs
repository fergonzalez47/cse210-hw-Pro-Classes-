using System.IO;
using System.Linq.Expressions;

public class Journal
{
    public List<Entry> _entries = new List<Entry>();



    public void AddEntry(Entry NewEntry)
    {
        _entries.Add(NewEntry);
    }

    public void DisplayAll()
    {
        foreach (Entry entry in _entries)
        {
            entry.Display();
        }
    }

    public void SaveToFile(string file)
    {
        Console.WriteLine("Saving to file...");
        if (!string.IsNullOrEmpty(file))
        {
            string fileName = file;

            using (StreamWriter myFile = new StreamWriter(fileName))
            {
                foreach (Entry entry in _entries)
                {
                    myFile.WriteLine($"Date: {entry._date} - Prompt: {entry._prompText} - \n {entry._entryText}");
                }
            }
        }
        else
        {
            Console.WriteLine("The file name can't be empty!");
        }
    }


    public void LoadFromFile(string file)
    {
        if (!string.IsNullOrEmpty(file) && File.Exists(file))
        {
             _entries.Clear();

            string[] lines = File.ReadAllLines(file);

            foreach (string line in lines)
            {
                string[] parts = line.Split(new[] { " - Prompt: ", " - \n" }, StringSplitOptions.RemoveEmptyEntries);

                if (parts.Length == 3)
                {
                    Entry entry = new Entry
                    {
                        _date = parts[0].Substring("Date: ".Length),
                        _prompText = parts[1],
                        _entryText = parts[2]
                    };

                    _entries.Add(entry);
                }
            }
        }
        else
        {
            Console.WriteLine("Invalid file name or file does not exist.");
        }
    }


}

