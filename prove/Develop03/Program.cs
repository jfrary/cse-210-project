using System;

class Program
{
    static void Main(string[] args)
    {
       // Reference reference = new Reference("John", 1, 12, 13);
         Reference reference = new Reference("John", 1, 12, 13);
        string scripturesText = "But as many as received him, to them gave he power to become the sons of God, even to them that believe on his name:" +
        " Which were born, not of blood, nor of the will of the flesh, nor of the will of man, but of God.";
    
        List<Word> words = new List<Word>();

        foreach (string j in scripturesText.Split(' '))
        {
            words.Add(new Word(j));       }

        Scripture scripture = new Scripture(reference, words);

        while(!scripture.IsCompleteHidden())
        {
            Console.Clear();
        
        Console.WriteLine(scripture.RefCheck());
        Console.WriteLine(scripture.RenderDisplay());
        Console.WriteLine("Press ENTER to hide words or type 'quit' to exit");
        string input = Console.ReadLine()?.Trim().ToLower();

        if (input == "quit")
        return;

        scripture.HideRandWords(3); }

    Console.Clear();
    Console.WriteLine(scripture.RefCheck());
    Console.WriteLine(scripture.RenderDisplay());
    Console.WriteLine("All Done!!!");
    }
}