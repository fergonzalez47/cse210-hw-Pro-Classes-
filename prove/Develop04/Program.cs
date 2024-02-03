using System;

//I am using input validation during the entry of seconds per activity; 
// I am reading the prompts from a file
// I am reading the questions from a file

class Program
{
    static void Main(string[] args)
    {

        string breathingDescription = "This activity will help you relax by walking your through breathing in and out slowly. Clear your mind and focus on your breathing.";
        string reflectingDescription = "This activity will help you reflect on times in your life when you have shown strength and resilience. This will help you recognize the power you have and how you can use it in other aspects of your life.";
        string listingDescription = "This activity will help you reflect on the good thingsin your life by having you list as many things as you can in a certain area.";
        int condition = 1;

        while (condition != 0)
        {
            Console.Clear();
            Console.WriteLine("Menu Options: ");
            Console.WriteLine(" 1. Start breathing Activity");
            Console.WriteLine(" 2. Start reflecting Activity");
            Console.WriteLine(" 3. Start listing Activity");
            Console.WriteLine(" 4. Quit");
            Console.Write("Select a choice from the menu: ");
            string optionStr = Console.ReadLine();

            if (int.TryParse(optionStr, out int option)) {
                if (option == 4)
                {
                    condition = 0;
                }
                else if(option == 1) {

                    BreathingActivity activity = new BreathingActivity("Breathing", breathingDescription);
                    activity.DisplayStartingMessage();
                    activity.Run();
                }
                else if (option == 2)
                {
                    ReflectingActivity activity = new ReflectingActivity("Reflecting", reflectingDescription);
                    activity.DisplayStartingMessage();
                    activity.Run();

                }
                else if (option == 3)
                {
                    ListingActivity activity = new ListingActivity("Listing", listingDescription);
                    activity.DisplayStartingMessage();
                    activity.Run();
                }
                else {
                    Console.WriteLine("Invalid input. Please enter a valid number.");
                }
            }
        }


        
    }
}