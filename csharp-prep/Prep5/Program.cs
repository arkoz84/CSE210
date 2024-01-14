using System;
using System.Reflection;

class Program
{
    static void Main(string[] args)
    {
        DisplayWelcome();
        string name = PromptUserName();
        int number = PromptUserNumber();
        int newnumber = SquareNumber(number);
        DisplayResult( name, newnumber);

    }
    static void DisplayWelcome()
    {
        Console.WriteLine("Welcome to the program!");
    }
    static string PromptUserName()
    {
        string response;
        Console.WriteLine("Please enter your name: ");
        response = Console.ReadLine();
            
        return response;
    }
    static int PromptUserNumber()
    {
        int response;
        Console.WriteLine("Please enter your favorite number: ");
        response = int.Parse(Console.ReadLine());
        return response;
    }
    static int SquareNumber(int number)
    {
        int sqrtnumber;
        sqrtnumber = number*number;
        return sqrtnumber;
    }
    static void DisplayResult(string name, int number)
    {
        Console.WriteLine($"{name}, the square of your number is {number}");
    }

}