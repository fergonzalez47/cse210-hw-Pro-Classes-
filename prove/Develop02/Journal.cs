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

    public void SaveToFile(String file)
    {
        Console.WriteLine("SaveToFile() Working");
        if (!string.IsNullOrEmpty(file))
        {
            string fileName = file;

            using (StreamWriter myFile = new StreamWriter(fileName))
            {
                foreach (Entry entry in _entries)
                {
                    myFile.WriteLine(entry);
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
                string[] parts = line.Split(',');
                
                    Entry entry = new Entry
                    {
                        _date = parts[0],
                        _prompText = parts[1],
                        _entryText = parts[2]
                    };

                    _entries.Add(entry);
            }
        }
        else
        {
            Console.WriteLine("Invalid file name or file does not exist.");
        }
    }

}

