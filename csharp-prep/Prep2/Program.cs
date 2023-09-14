using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Prep2 World!");
        Console.WriteLine("Enter your grade %");
        string gradeInput = Console.ReadLine();
        int valueUser = int.Parse(gradeInput);
        int a = 90;
        int b = 80;
        int c = 70;
        int d = 60;
        

        if(valueUser >= a && valueUser < 100)
        {
            Console.WriteLine("Your grade is A,you passed the course!");
        }
        else if(valueUser >= b && valueUser < a )
        {
            Console.WriteLine("Your grade is B,you passed the course!");
        }
        else if(valueUser >= c && valueUser < b)
        {
            Console.WriteLine("Your grade is C,you passed the course!");
        }
        else if(valueUser >= d && valueUser < c)
        {
            Console.WriteLine("Your grade is D,you failed the course,try again.");
        }
        else if(valueUser >= 101)
        {
            Console.WriteLine("Error,enter a valid grade.");
        }
        else{
            Console.WriteLine("Your grade is F,you failed the course,try again.");
        }
    }
}