using System;
class Program
{
    static void Main(string[] args)
    {
        string scriptureText = "And it came to pass that I, Nephi, said unto my father: " +
            "I will go and do the things which the Lord hath commanded, for I know that " +
            "the Lord giveth no commandments unto the children of men, save he shall " +
            "prepare a way for them that they may accomplish the thing which he commandeth them";

        Reference scriptureRef = new Reference("1 Nefi", 3, 7);
        Scripture scripture = new Scripture(scriptureText, scriptureRef);
        int condition = 1;
        while (condition == 1)
        {
            Console.Clear();
            Console.WriteLine(scripture.GetDisplayText());
            Console.WriteLine(" ");
            Console.WriteLine("Press enter to continue or type 'quit' to finish: ");
            string option = Console.ReadLine();
   

            if (string.IsNullOrEmpty(option.Trim()))
            {
                scripture.HideRandomWords();
            }
            else if (option.ToLower() == "quit")
            {
                Console.WriteLine("Exiting the program...");
                
            }
            else
            {
                Console.WriteLine($"You entered: {option}");
            }


            if (scripture.IsCompletelyHidden() == true)
            {
                Console.WriteLine("All words are hidden. Exiting the program...");
                condition = 0;
            }
       
        }
    }
}
