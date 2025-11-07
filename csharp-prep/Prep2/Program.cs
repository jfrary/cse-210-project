using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Prep2 World!");

        Console.WriteLine("What is your grade percentage?");
        int percent = int.Parse(Console.ReadLine());

        string letter = "";

        if (percent >= 90)
        {
            letter = "A";
        }
        else if (percent >= 80)
        {
            letter = "B";
        }
        else if (percent >= 70)
        {
            letter = "C";
        }
        else if (percent >= 60)
        {
            letter = "D";
        }
        else
        {
            letter = "F";
        }

        Console.WriteLine($"Grade is: {letter}");
        
        if (percent >= 70)
        {
            Console.WriteLine("You Passed, Great Job!");
        }
        else
        {
            Console.WriteLine("Try again Bub");
        }
         
        
    }
}