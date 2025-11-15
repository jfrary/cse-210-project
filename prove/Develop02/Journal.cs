using System;
using System.Collections.Generic;
using System.IO;
namespace Develop02;

public class Journal
{

     public List<Entry> _entries = new List<Entry>();

     public void Display()
{
    Console.WriteLine("Journal Entries");

    foreach (Entry response in _entries)
    
        {
            response.Display();
        }
    
}
    public void AddEntry(Entry entry)
    {
        _entries.Add(entry);
    }
    public void WriteToFile(string filePath)
    {

    //    // string inputForPrompt = Console.ReadLine();
    //    //string date = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss");

      
       using (StreamWriter outputFile = new StreamWriter(filePath, true))
        {
            foreach (Entry e in _entries)
            {

            outputFile.WriteLine($"{e.DateTime},{e.Prompt},{e.Response}");
            }
        }
    }

    public void LoadFromFile(string filePath)
    {
        if( !File.Exists(filePath))
        {
            Console.WriteLine($"Error: File '{filePath}' not found.");
            return;
        }
      //  string[] files = Directory.GetFiles(_folderPath);
        
      //  if (files.Lenghth == 0)
      //  {
     //       Console.WriteLine("No Files found.");
     //       return;
    // }

     //   Console.Writeline("Available Files: ");
     //   foreach (string file in files) 
     //   {
     //       Console.WriteLine(Path.GetFileName(file));
     //   }
        string[] lines = File.ReadAllLines(filePath);
        
        foreach (string line in lines)
        {
            string[] parts = line.Split(",", 3);
            string date = parts[0];
            string prompt = parts[1];
            string response = parts[2];
            
            _entries.Add(new Entry(date, prompt, response));
        }
    }
    
}