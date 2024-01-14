using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        List<int> numbers = new List<int>();
        int response;
        int sum =0;
        int qty=0;
        float average;
        int largest;
        int smallest;
        Console.WriteLine("Enter a list of numbers, type 0 when finished.");
        do
        {
            Console.Write("Enter number: ");
            response = int.Parse(Console.ReadLine());
            if (response!=0)
            {
                numbers.Add(response);

            }
        } while (response != 0);

        largest = numbers[0];
        smallest = 1000000;
        foreach (int number in numbers)
        {
            sum = sum + number;
            if (number>largest)
            {
                largest = number;
            }
            if (number<smallest && number>0)
            {
                smallest = number;
            }
        }
        qty = numbers.Count;
        average = (float)sum/qty;
        numbers.Sort();
        Console.WriteLine($"The sum is: {sum}");
        Console.WriteLine($"The average is: {average.ToString("F3")}");
        Console.WriteLine($"The largest number is: {largest}");
        Console.WriteLine($"The smallest positive number is: {smallest}");
        Console.WriteLine($"The sort list is: ");
        foreach (int x in numbers)
        {
            Console.WriteLine(x);
        }
    }
}