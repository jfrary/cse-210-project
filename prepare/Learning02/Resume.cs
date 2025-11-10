using System.Collections.Generic;
namespace ConsoleApp1;

public class Resume
{
    public string _name;
    public List<Job> _jobs = new List<Job>();
    public void DisplayResume(){
        Console.WriteLine($"Name: {_name}");
        Console.WriteLine("Jobs:");
    }
}
