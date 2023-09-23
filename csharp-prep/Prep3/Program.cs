using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Prep3 World!");

        Console.WriteLine("Guess the magic number (from 1 to 30)");

        Random randomGenerator = new Random();
        int numberUser = randomGenerator.Next(1, 30);

        
        
        int guessUser = 0;

        while(guessUser != numberUser)
        {
            Console.WriteLine("What is your guess?");
            string guessInput = Console.ReadLine();
            guessUser = int.Parse(guessInput);

            if(guessUser > numberUser)
            {
                Console.WriteLine("Lower");
                Console.WriteLine("Try again!");
                
                
            }
            else if (guessUser < numberUser)
            {
                Console.WriteLine("Higher");
                Console.WriteLine("Try again!");
                
                
            }
            else if (guessUser == numberUser)
            {
                Console.WriteLine("You guessed it!");
            }
        }
    }
}