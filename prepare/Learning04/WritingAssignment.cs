using System;

public class WritingAssignment : Assignment
{
    private string _title;
    

    public WritingAssignment(string StudentName, string topic, string title) 
    : base(StudentName, topic)
    {
        _title = title;
     
    }

    public string GetWritingInformation()
    {
        return $"{GetStudentName()} Read the following : Mein Kampf and thousand other jokes to tell to Germans";
    }
}

  
