using System;
using Microsoft.VisualBasic;

class Program
{
    static void Main(string[] args)
    {
        bool open = true;
        while (open)
        {
            Console.Clear();
            Console.WriteLine("Welcome!");
            Console.WriteLine("Choose an option!");
            Console.WriteLine("1: Create Character");
            Console.WriteLine("2: Display Current Character");
            Console.WriteLine("3: Save Character");
            Console.WriteLine("4: Load Character");
            Console.WriteLine("5: Play Character");
            Console.WriteLine("6: Quit");
            string choose = Console.ReadLine();

            switch (choose)
            {

                case "1":
                    CreateCharacter.CreateCharacter(characters);
                    break;
                
                case "2":
                    DisplayCharacter(characters);
                    break;
         
    }
}
    }
}