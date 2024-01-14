using System;

class Program
{
    static void Main(string[] args)
    {
        Random randomGenerator = new Random();
        int number = randomGenerator.Next(1, 100);
        Console.WriteLine("The computer has selected a magic number between 1 and 100.");
        Console.WriteLine("What is your guess?");
        string win = "No";
        int attempts = 0;
        int guess = int.Parse(Console.ReadLine());
        attempts = attempts + 1;
        while (win == "No")
        {
            if (number==guess)
            {
                Console.WriteLine("You guessed it!");
                Console.WriteLine($"You did it in {attempts} attempts.");
                win = "Yes";
            }
            else if (number>guess)
            {
                Console.WriteLine("Higher");
                Console.WriteLine("What is your guess?");
                guess = int.Parse(Console.ReadLine());
                attempts = attempts + 1;
            }
            else if (number<guess)
            {
                Console.WriteLine("Lower");
                Console.WriteLine("What is your guess?");
                guess = int.Parse(Console.ReadLine());
                attempts = attempts + 1;
            }
        }
    }
}