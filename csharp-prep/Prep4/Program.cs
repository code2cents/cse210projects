using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Prep4 World!");
        Console.WriteLine("Enter a list of numbers, type 0 when finished.");
        List<int> inNumbers = new List<int>();

        int userInput = 0;

        while(userInput != 0)
        {
            Console.WriteLine("Enter a number");
            string userAnsw = Console.ReadLine();
            userInput = int.Parse(userAnsw);

            if(userInput != 0)
            {
                inNumbers.Add(userInput);
            }
        }

        int total = 0;

        foreach (int numbers in inNumbers)
        {
            total += numbers;
        }

        Console.WriteLine($"The total is: {total}");

        float average = ((float)total) / inNumbers.Count;
        Console.WriteLine($"The average is: {average}");

        int max = inNumbers.Max();

       
        Console.WriteLine($"The max is: {max}");    
        }
        
    }
