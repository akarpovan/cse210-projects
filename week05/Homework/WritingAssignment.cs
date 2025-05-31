using System;

public class WritingAssignment : Assignment
{
    //Attributes as private member variables.
    private string _title;

    //Constructor
    public WritingAssignment(string studentName, string topic, string title) : base(studentName, topic)
    {
        _title = title;
    }

    //Method
    public string GetWritingInformation()
    {
        return $"{_title} by {_studentName}\n";
    }
    
}
