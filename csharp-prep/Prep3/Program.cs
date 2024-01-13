using System;
using System.Runtime.InteropServices;

class Program
{
    static void Main(string[] args)
    {
        Random randomGenerator = new Random();
        int number = randomGenerator.Next(1, 11);

        Console.WriteLine("Hi! Try to guess the number between 1 and 11");

        int guess = 0;
        int times = 0;

        while (guess != number)
        {
            Console.WriteLine("What is your guess? ");

            string guessString = Console.ReadLine();
            int guessNumber = int.Parse(guessString);
            if (guessNumber == number)
            {
                guess = number;
                Console.WriteLine($"You guessed it! in {times} times");
            }
            else if (guessNumber > number)
            {
                Console.WriteLine("Higher");
                times++;

            }
            else
            {
                Console.WriteLine("Lower");
                times++;
            }
        }
        
    }
}