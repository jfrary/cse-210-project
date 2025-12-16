using System;
using System.Collections.Generic;


class Program
{
    static void Main(string[] args)
    {
        List<Character> characters = new List<Character>();
        CharacterManager manager = new CharacterManager();
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
                    CreateCharacter.CreateNewCharacter(characters);
                    break;
                
                case "2":
                    if (characters.Count == 0)
                    {
                        Console.WriteLine("No Heros here!");
                    }
                    else {
                    foreach (Character character in characters) 
                    {
                        character.DisplayCharacter();
                    }
                    
                    }
                    Console.WriteLine("Press any key to continue");
                    Console.ReadLine();

                    break;
                case "3":
                    Console.WriteLine("Filename?");
                    string saveName = Console.ReadLine();
                    manager.SaveCharacters(characters, saveName);
                    Console.WriteLine("Press any key to continue");
                    Console.ReadLine();
                    break;
                
                case "4":
                    Console.WriteLine("Your Characters");
                    List<string> savedFiles = manager.GetSavedFiles();

                    if (savedFiles.Count == 0)
                    {
                        Console.WriteLine("None Found");
                        Console.ReadLine();
                        break;
                    }
                    
                    for (int i = 0; i < savedFiles.Count; i++)
                    {
                        Console.WriteLine($"{i + 1}: {savedFiles[i]}");
                    }

                    if(!int.TryParse(Console.ReadLine(), out int fileChoice) || fileChoice < 1 || fileChoice > savedFiles.Count)
                    {
                        Console.WriteLine("Not a choice");
                        Console.ReadLine();
                        break;
                    }

                    Console.WriteLine("Choose which file: ");
                    string loadFile = Path.GetFileName(savedFiles[fileChoice - 1]);
                    characters = manager.LoadCharacters(loadFile);

                    Console.WriteLine("Press key to continue");
                    Console.ReadLine();
                    break;
                
                case "5":
                    if (characters.Count == 0)
                    {
                        Console.WriteLine("No character selected");
                        Console.ReadLine();
                        break;
                    }

                    Console.Clear();
                    Console.WriteLine("Choose which character to play as. ");

                    for (int i = 0; i < characters.Count; i++)
                    {
                        Console.WriteLine($"{i + 1}: {characters[i].Name()} ({characters[i].GetType().Name})");
                    }

                    if (!int.TryParse(Console.ReadLine(), out int charChoice) || charChoice < 1 || charChoice > characters.Count)
                    {
                        Console.WriteLine("Wrong , try again");
                        Console.ReadLine();
                        break;
                    }
                    Character selectCharacter = characters[charChoice - 1];

                    PlayCharacter playCharacter = new PlayCharacter(selectCharacter);
                    
                    playCharacter.StartPlay();
                    break;

                case "6":
                    open = false;

                    break;
         
    }
}
    }
}