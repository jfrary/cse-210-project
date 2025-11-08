using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Prep3 World!");

        //Console.WriteLine("Choose a magic number");
        

       // Console.WriteLine("What is your guess?");
        Console.WriteLine("What is your guess?");
        int guess = int.Parse(Console.ReadLine());

        Random number = new Random();
        int magic = number.Next(1, 100);

        while (guess != magic)
        {
           
            if (guess < magic)
            {
                Console.WriteLine("Higher");
            }
            else if (guess > magic)
            {
                Console.WriteLine("Lower");
            }
            else
            {
                Console.Write("You Guessed it");
            }
         
            guess = int.Parse(Console.ReadLine());
        }
       // Console.Write("You Guessed it");
    }
}