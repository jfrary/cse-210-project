using System;
using System.Threading;
public class Activity
{
    private string _name;
    private string _description;
    private int _duration;

    public Activity(string name, string description) 
    {
        _name = name;
        _description = description;
    }

    public void SetDuration(int seconds)
    {
        _duration = seconds;
    }
    public int GetDuration()
    {
       return _duration;
    }
    public void DisplayStartingMessage()
    {
        Console.Clear();
        Console.WriteLine("Welcome to This Activity");
        Console.WriteLine(_description);
        Console.WriteLine("Get Ready...");
        PauseWithAnimation(3);
    }

    public void DisplayEndMessage()
    {
        Console.WriteLine("Congratulations and Good Jobs on Completing this!!!");
        PauseWithAnimation(2);
    }
    public void Spinner(int seconds)
    {
        string[] spinners = {"|", "/", "-", "\\"};
        int index = 0;
        DateTime startTime = DateTime.Now;
        DateTime futureTime = startTime.AddSeconds(5);
        
        while (DateTime.Now < futureTime)
        {
        Console.Write(spinners[index]);
        Thread.Sleep(1000);
        Console.Write("\b");
        DateTime currentTime = DateTime.Now;
        
        index = (index + 1) % spinners.Length;
    }
     }

    public void Countdown(string message, int seconds)
    {
        for (int i = seconds; i > 0; i--)
        {
            Console.Write($"\r{message} {i}  ");
            Thread.Sleep(1000);
        }
        
    }

    public void PauseWithAnimation(int seconds)
    {

        // for (int i =0; i < seconds; i++)
        // {
        //     Console.Write(".....");
        //     Thread.Sleep(1000);
        // }
        // Console.WriteLine();
        Spinner(seconds);
    }
    public string GetName()
    {
        return _name;
    }
}
