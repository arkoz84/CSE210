using System;

class Program
{
    static void Main(string[] args)
    {
        // Ask user for their names
        Console.WriteLine("What is your first name? ");
        string name = Console.ReadLine();
        Console.WriteLine("What is your last name? ");
        string lastname = Console.ReadLine();
        Console.WriteLine("");
        Console.WriteLine("Your name is " + lastname + ", " + name + " " + lastname + ".");
        
    }
}