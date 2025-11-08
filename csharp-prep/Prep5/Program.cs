using System;
using System.Globalization;

class Program
{
    static void Main(string[] args)
    {
    

        DisplayWelcome();
        string UserName = PromptUserName();
        int UserNumber = PromptUserNumber();
        int year; 
        PromptUserBirthYear(out year);
        int SquaredNumber = SquareNumber(UserNumber);
        
        DisplayResult(UserName, SquaredNumber, year);

        


    }
    static void DisplayWelcome()
    {
        Console.WriteLine("Welcome to the Program!");
    }
        
    static string PromptUserName()
    {
        Console.WriteLine("Enter your username");
        string UserName = Console.ReadLine();
        return UserName;
    }
    static int PromptUserNumber()
    {
        Console.WriteLine("Enter your favorite number");
        int UserNumber = int.Parse(Console.ReadLine());
        return UserNumber;
    }
    static void PromptUserBirthYear(out int year)
    {
        Console.Write("Enter your birth year");
        year = int.Parse(Console.ReadLine());
        
    }
    static int SquareNumber(int square)
    {
      //  Console.WriteLine("Enter a number to square");
      //  square = int.Parse(Console.ReadLine());
        int SquaredNumber = square * square;
       
        return SquaredNumber;

    }
    
    static void DisplayResult(string UserName, int SquaredNumber, int year)
    {
        
        int today = DateTime.Today.Year;
        int age = today - year;

        Console.WriteLine($"Username is: {UserName}");
        Console.WriteLine($"Squared number is: {SquaredNumber}");
        Console.WriteLine($"Your age is: {age}");
    }
}