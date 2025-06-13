using System;

public class SimpleGoal : Goal
{
    //attributes
    private bool _isComplete;

    //Constructor
    public SimpleGoal(string name, string description, int points) : base (name, description, points)
    {
        _isComplete = false;
    }

    //Method
    public override void RecordEvent()
    {


    }
    //Method
    public override bool IsComplete()
    {
        return true;

    }
    //Method
    public override string GetStringRepresentation()
    {
        return "";

    }

}
