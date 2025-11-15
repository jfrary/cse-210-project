using System;
using System.IO;
namespace Develop02
{
    

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Develop02 World!");

        Journal yourJournal = new Journal();
        PromptGenerator promptGenerator = new PromptGenerator();

        bool open = true;
        while (open)
        {
            Console.WriteLine("Choose what you want to do.");
            Console.WriteLine("1: Write a new entry");
            Console.WriteLine("2: Display Journal");
            Console.WriteLine("3: Save Journal.");
            Console.WriteLine("4: Load Journal.");
            Console.WriteLine("5: Exit");
            string choose = Console.ReadLine();

             
            switch (choose)
            {
                case "1":
                    string prompt = promptGenerator.getRandPrompt();
                    Console.WriteLine(prompt);
                    Console.WriteLine("Write your response: ");
                    string response = Console.ReadLine();
                    if (response != null)
                    {
                        string dateTime = DateTime.Now.ToString();
                        Entry nEntry = new Entry(dateTime, prompt, response);
                        yourJournal.AddEntry(nEntry);
                        Console.WriteLine("This has been saved");
                    }
                        
                    break;

                case "2":

                    yourJournal.Display();
                    break;

                case "3":
                    Console.WriteLine("Enter name to save.");
                    string save = Console.ReadLine();
                    yourJournal.WriteToFile(save);
                    Console.WriteLine("Saved");
                    break;

                case "4":
                    Console.WriteLine("Entries loaded from file");           
                    string load = Console.ReadLine();
                    yourJournal.LoadFromFile(load);
                    Console.WriteLine("Loaded!");

                  
                    break;
                
                case "5":
                    open = false;
                    Console.WriteLine("Goodbye!");
                    break;
                
                default:
                    Console.WriteLine("Thats not an option, try again");
                    break;
            }
        }
        
    }
 }
}
