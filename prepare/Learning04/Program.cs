using System;

class Program
{
    static void Main(string[] args)
    {
        Assignment assignment = new Assignment("Jethro", "CSE210");
        MathAssignment mathassignment = new MathAssignment("Jethro", "CSE210","6", "2-5");
        WritingAssignment writingassignment = new WritingAssignment("Jethro","Reading", "Frary dude");
        Console.WriteLine("Hello Learning04 World!");

        Console.WriteLine(assignment.GetSummary());
       
        Console.WriteLine(mathassignment.GetSummary());
        Console.WriteLine(mathassignment.GetHomeworkList());
        
        Console.WriteLine(writingassignment.GetSummary());
        Console.WriteLine(writingassignment.GetWritingInformation());
    }
}