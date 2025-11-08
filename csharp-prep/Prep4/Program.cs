using System;
using System.Collections.Generic;
using System.Linq;
class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Prep4 World!");

        Console.WriteLine("Enter a list of numbers, tpye 0 when finished");

        List<int> number = new List<int>();

        int input;
        do
        {
            Console.WriteLine("Enter a number");
            input = int.Parse(Console.ReadLine());
            

            if (input != 0)
            {
                number.Add(input);
            }
        }
        while (input != 0);
        //        foreach (int num in number)
        //        {
        //            Console.Write(num);
        //        }
        int total = number.Sum();
        Console.WriteLine($"Your total is: {total}");

        double average = number.Average();
        Console.WriteLine($"Your Average is: {average}");

        int max = number.Max();
        Console.WriteLine($"Highest number is: {max}");
    }
        
}