public class ListingActivity: Activity {
    int _count = 0;
    private List<string> _prompts = new List<string>();

    public ListingActivity(string name, string description) : base(name, description)
    {

    }

    public void Run() {


        Console.WriteLine("");
        Console.WriteLine("List as many responses you can to the following prompt: ");
        GetRandomPrompt("prompts_list.txt");
        Console.WriteLine("You may begin in: ");
        ShowCountDown(5);
        _count = 0;
        GetListFromUser();
        
        DisplayEndingMessage();

    }
    private void GetRandomPrompt(string file) {
        try
        {
            _prompts.Clear();
            _prompts = File.ReadAllLines(file).ToList();
            Random random = new Random();
            int prompt = random.Next(0, _prompts.Count());
            Console.WriteLine($" --- {_prompts[prompt]} ---");
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Error reading file: {ex.Message}");
        }
    }

    private List<string> GetListFromUser() {
        DateTime loopTime = DateTime.Now.AddSeconds(GetSeconds());
        List<string> userList = new List<string>();

        
        while (DateTime.Now < loopTime)
        {
            Console.Write("> ");
            string list = Console.ReadLine();
            userList.Add(list);
            _count++;
        }
        Console.WriteLine($"You listed {_count} items!");
        return userList;


    }




}
