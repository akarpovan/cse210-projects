using System;

public class MathAssignment : Assignment
{
    //Attributes as private member variables.
    private string _textBookSection;
    private string _problems;

    //Constructor for your class that accepts all four parameters, 
    //have it call the base class constructor to set the base class attributes that way.
    public MathAssignment(string studentName, string topic, string textBookSection, string problems) : base(studentName, topic)
    {
        _textBookSection = textBookSection;
        _problems = problems;
    }

    //Method
    public string GetHomeworkList()
    {
        return $"Section {_textBookSection} Problems {_problems}";
    }

}