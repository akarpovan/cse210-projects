using System;

public class Assignment
{
    //Attributes as private member variables.
    /*private string _studentName;
    private string _topic;*/
    
    protected string _studentName;
    protected string _topic;

    //constructor for this class that receives a student name 
    //and topic and sets the member variables.
    public Assignment(string studentName, string topic)
    {
        _studentName = studentName;
        _topic = topic;
    }

    //Return the student's name and the topic.
    public string GetSummary()
    { 
        return $"{_studentName} - {_topic}";
    }
}
