using System;
using System.Globalization;

Console.WriteLine("Hello Prep5 World!");

DisplayWelcome();

string userName = PromptUserName();
int userNumber = PromptUserNumber();
int sqrNumber = SqrNumber(userNumber);
result(userName, sqrNumber);
void DisplayWelcome()
{
    Console.WriteLine("Welcome to the program!");
}
string PromptUserName()
{
    Console.WriteLine("Please enter your name: ");
    string name = Console.ReadLine();
    return name;
}
int PromptUserNumber()
{
    Console.WriteLine("Please enter your favorite number: ");
    int number = int.Parse(Console.ReadLine());
    return number;
}
int SqrNumber(int number)
{
    int square = number * number;
    return square;
}
void result(string name, int square)
{
    Console.WriteLine($"{name},the square of your number is {square}");
}
