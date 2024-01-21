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
        Console.WriteLine("\n");
        if (_entries.Count > 0)
        {
            foreach (Entry entry in _entries)
            {
                entry.Display();
            }
        }
        else
        {
            Console.WriteLine($"An error occurred...Sorry!");
            Console.WriteLine($"There are no lines to show");
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
                    // myFile.WriteLine($"Date: {entry._date} - Prompt: {entry._prompText} - \n {entry._entryText}");
                    myFile.WriteLine($"{entry._date}~{entry._prompText}~{entry._entryText}");
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

            string[] lines = System.IO.File.ReadAllLines(file);

            foreach (string line in lines)
            {
                string[] parts = line.Split("~");

                if (parts.Length >= 3)
                {
                    Entry entry = new Entry
                    {
                        _date = parts[0],
                        _prompText = parts[1],
                        _entryText = parts[2]
                    };

                    _entries.Add(entry);
                }
                else
                {
                    Console.WriteLine($"Invalid entry format: {line}");
                }

            }

            Console.WriteLine("File loaded successfully.");
        }
        else
        {
            Console.WriteLine("Invalid file name or file does not exist.");
        }
    }



}

