using System;

public abstract class Goal
{
    //Any class that has at least one abstract method is an Abstract class. 
    //This means that the base abstract class cannot be directly instantiated, 
    //you can only create objects from the derived types.
    //attributes
    private string _shortName;
    private string _description;
    private int _points;

    //Constructor
    public Goal(string name, string description, int points)
    {
        _shortName = name;
        _description = description;
        _points = points;
    }

    //Method
    public abstract void RecordEvent();
    //Method
    public abstract bool IsComplete();
    //Method
    public abstract string GetStringRepresentation();
    //Method
    public virtual string GetDetailsString()
    {
        string checkbox = "";
        if (IsComplete() == true)
        {
            checkbox = "[X]";
        }
        else
        {
            checkbox = "[ ]";
        }
        return $"{checkbox} {_shortName} ({_description})";
    }
    
    public string GetShortName()
    {
        return _shortName;
    }

    public string GetDescription()
    {
        return _description;
    }

    public int GetPoints()
    {
        return _points;
    }
}
