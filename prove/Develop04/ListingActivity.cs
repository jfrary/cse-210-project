using System;
using System.Threading.Tasks;
using System.Collections.Generic;
public class ListingActivity : Activity
{   
    private List<string> _prompts;
    
    private Random _random = new Random();

    public ListingActivity() : base("Listing Activity", "This activity will help you reflect on times in your life when you have shown strength and resilience. This will help you recognize the power you have and how you can use it in other aspects of your life.")
    {
        _prompts = new List<string>()
        {
"Who are people that you appreciate?",
"What are personal strengths of yours?",
"Who are people that you have helped this week?",
"When have you felt the Holy Ghost this month?",
"Who are some of your personal heroes?"        
};

}
    
    public void Start()
    {

     DisplayStartingMessage(); 
     string prompt = _prompts[_random.Next(_prompts.Count)];
     Console.WriteLine(prompt);
     
     //onsole.WriteLine("Press Enter when ready.");
     
     Countdown("Write as man responses as you can", 5);
     
     Console.WriteLine("WRITE NOW!");

     List<string> userResponses = new List<string>();


     int secondsElapsed = 0;
     DateTime startTime = DateTime.Now;

     while (secondsElapsed < GetDuration())
        {
           
           
           string input = Console.ReadLine();

           if (!string.IsNullOrWhiteSpace(input))
            {
                userResponses.Add(input);
            }
            
           secondsElapsed = (int)(DateTime.Now - startTime).TotalSeconds;
        }  
        Console.WriteLine($"You entered {userResponses.Count} responses!");

        DisplayEndMessage();

        
    }
    
}