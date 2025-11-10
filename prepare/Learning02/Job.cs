namespace ConsoleApp1;

public class Job   
{
    
    public string _company;
    public string _jobType;
    public int _startYear;
    public int _endYear;
    public void DisplayJobDetails()
    {
        
        Console.WriteLine($"{_jobType} ({_company}) {_startYear}-{_endYear}");
    }
}
 