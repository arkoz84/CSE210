using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("What is your grade percentage? ");
        int grade = int.Parse(Console.ReadLine());
        string letter;
        int unit = grade % 10; 
        if (grade >= 90)
        {
            letter = "A";
        }
        else if (grade >= 80)
        {
            letter = "B";
        }
        else if (grade >= 70)
        {
            letter = "C";
        }
        else if (grade >= 60)
        {
            letter = "D";
        }
        else
        {
            letter = "F";
        }
        //Adding + or -
        if (unit>=7)
        {
            if (letter!="A" && letter!="F")
            {
                letter = letter + "+";
            }
        }
        else if (unit<3 && letter!="F")
        {
            letter = letter + "-";
        }
        
        
        Console.WriteLine($"Your grade is {letter}.");
        if (letter=="A"||letter=="B"||letter=="C")
        {
            Console.WriteLine("You passed the course.");
        }
        else
        {
            Console.WriteLine("You failed the course.");    
        }

    }
}