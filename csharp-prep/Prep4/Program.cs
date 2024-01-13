using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {


        Console.WriteLine("Enter a list of numbers, type 0 when finished.");

        List<int> numbers = new List<int>();
        int condition = 1;

        while (condition != 0)
        {
            Console.WriteLine("Enter a number: ");
            string numberStr = Console.ReadLine();
            int number = int.Parse(numberStr);

            if (number == 0)
            {
                condition = number;
            }
            else
            {
                numbers.Add(number);
            }
        }
        int sum = 0;


        for (int i = 0; i < numbers.Count; i++)
        {
            sum += numbers[i];
        }
        double avg = (double)sum / numbers.Count;

        Console.WriteLine($"The sum is: {sum}");
        Console.WriteLine($"The average  is: {avg}");
        Console.WriteLine($"The largest number is: {numbers.Max()}");
    }
}