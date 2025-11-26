using System;
using System.Threading.Tasks;
public class BreathingActivity : Activity
{
    public BreathingActivity() : base("Breathing Activity", "This activity will help you relax by walking your through breathing in and out slowly. Clear your mind and focus on your breathing.")
    {
        
    }
    public void Start()
    {
     DisplayStartingMessage(); 
     Console.Clear();
     int secondsElapsed = 0;

     while (secondsElapsed < GetDuration())
        {
        
            
            
            Countdown("Breath in...", 3);
            secondsElapsed += 3;
            if (secondsElapsed >= GetDuration()) break;
            
            Countdown("Breath out...", 3);
            secondsElapsed += 3;
        }  
        DisplayEndMessage();
    }
    // private void HandleBreathing();





    // public static async Task Main()
    // {
    //     Console.WriteLine("Start");

    //     await Task.Delay(TimeSpan.FromSeconds(5));

    //     Console.WriteLine("Waited for 5 seconds");

    //     // Continue with your code here
    // }

}