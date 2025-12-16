using System;
using System.IO;
using System.Collections.Generic;

public class CharacterManager
{
    public string _saveFolder = "SavedCharacters";

    public CharacterManager()
        {
            if (!Directory.Exists(_saveFolder))
                Directory.CreateDirectory(_saveFolder);
        }  

    public void SaveCharacters(List<Character> characters, string filename)
    {
        string filePath = Path.Combine(_saveFolder, filename + ".txt");

        using (StreamWriter writer = new StreamWriter(filePath))
        {
            foreach (Character c in characters)
            {
                string type = c.GetType().Name;
                string line = "";

                if (type == "Fighter")
                {
                    Fighter f = (Fighter)c;
                    line = $"{type},{f.Name()},{f.HP()},{f.Inventory()},{f.ArmorClass()}";

                }
                else if (type == "Wizard")
                {
                    Wizard w = (Wizard)c;
                    line = $"{type},{w.Name()},{w.HP()},{w.Inventory()},{w.SpellSlots()},{w.knownSpells()}";
                
                }
                else if (type == "Rouge")
                {
                    Rouge r = (Rouge)c;
                    line = $"{type},{r.Name()},{r.HP()},{r.Inventory()},{r.IsStealthed()}";
                }
                writer.WriteLine(line);

            }
        }
    Console.WriteLine($"This Character has been saved {characters.Count}. Saved to {filePath}");
    }

        public List<Character> LoadCharacters(string filename)
    {
        string filePath = Path.Combine(_saveFolder, filename);

        if (!File.Exists(filePath))
        {
            Console.WriteLine("File does not exist");
            return new List<Character>();
        }
        List<Character> characters = new List<Character>();
        string[] lines = File.ReadAllLines(filePath);

        foreach(string line in lines)
        {
            string[] parts = line.Split(",");
            string type = parts[0];
            if (type == "Fighter")
            {
                string name = parts[1];
                int hp = int.Parse(parts[2]);
                int inventory = int.Parse(parts[3]);
                int armorClass = int.Parse(parts[4]);

                Fighter f = new Fighter(name, hp, armorClass, inventory);
                characters.Add(f);
            }
            else if (type == "Wizard")
            {
                string name = parts[1];
                int hp = int.Parse(parts[2]);
                int inventory = int.Parse(parts[3]);
                int spellSlots = int.Parse(parts[4]);
                string knownSpells = parts[5]; 
                
                Wizard w = new Wizard(name, hp, spellSlots, knownSpells, inventory);
                characters.Add(w);            
               }
               else if (type == "Rouge")
            {
                string name = parts[1];
                int hp = int.Parse(parts[2]);
                int inventory = int.Parse(parts[3]);
                bool isStealthed = bool.Parse(parts[4]);

                Rouge r = new Rouge(name, hp, inventory, isStealthed);
                characters.Add(r);
            }
        }
        Console.WriteLine($"Your Characters {characters.Count}: {filePath}");
        return characters;
        }

public List<string> GetSavedFiles()
    {
        if (!Directory.Exists(_saveFolder))
        return new List<string>();
    
    string[] files = Directory.GetFiles(_saveFolder, "*.txt");
    List<string> filenames = new List<string>();
    foreach (string file in files) 
    {
        filenames.Add(Path.GetFileName(file));
    }
    return filenames;
    }
}