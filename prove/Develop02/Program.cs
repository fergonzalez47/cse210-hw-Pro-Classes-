using System;


//I used validation if the user enter a letter as a option;
//
class Program
{
    static void Main(string[] args)
    {
        int condition = 0;
        // Prompts

        PrompGenerator prompt = new PrompGenerator();
        prompt._prompts.Add("Who was the most interesting person I interacted with today?");
        prompt._prompts.Add("What was the best part of my day?");
        prompt._prompts.Add("How did I see the hand of the Lord in my life today?");
        prompt._prompts.Add("What was the strongest emotion I felt today?");
        prompt._prompts.Add("If I had one thing I could do over today, what would it be?");

        Console.WriteLine("Welcome to the Journal Program...");
        Journal journal = new Journal();
        while (condition != -1)
        {
            Console.WriteLine("Please select one of the following options");
            Console.WriteLine("(1) - Write");
            Console.WriteLine("(2) - Display");
            Console.WriteLine("(3) - Load");
            Console.WriteLine("(4) - Save");
            Console.WriteLine("(0) - Quit");
            Console.Write("What would you like to do?:  ");
            string optionStr = Console.ReadLine();

            if (int.TryParse(optionStr, out int option))
            {

                if (option == 0)
                {
                    condition = -1;
                }
                else if (option == 1)
                {

                    Entry entry = new Entry();
                    entry._prompText = prompt.GetRandomPrompt();
                    Console.WriteLine($"{entry._prompText}");

                    //Assigning the values to the Object
                    string textEntry = Console.ReadLine();
                    entry._entryText = textEntry;

                    journal.AddEntry(entry);

                }
                else if (option == 2)
                {

                    journal.DisplayAll();

                }

                else if (option == 3)
                {
                    Console.Write("Name if the File: ");
                    string filename = Console.ReadLine();
                    journal.LoadFromFile(filename);
                }

                else if (option == 4)
                {
                    Console.Write("Name if the File: ");
                    string filename = Console.ReadLine();

                    journal.SaveToFile(filename);
                }
            }
            else
            {
                
                Console.WriteLine("Invalid input. Please enter a valid number.");
            }





        }
    }
}