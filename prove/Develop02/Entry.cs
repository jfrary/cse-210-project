using System;
using System.IO;
using System.Net;
namespace Develop02;

public class Entry
{
    public string DateTime { get; set; }
    public string Prompt { get; set; }
    public string Response { get; set; }


    public Entry(string date, string promptgen, string userResponse)
    {
        DateTime = date;
        Prompt = promptgen;
        Response = userResponse;
    }
    
    public void Display()
    {
        Console.WriteLine(DateTime);
        Console.WriteLine(Prompt);
        Console.WriteLine(Response);

    }

}


