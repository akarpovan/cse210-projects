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
        if (_isComplete == false)
        {
            _isComplete = true;
        }
    }
    //Method
    public override bool IsComplete()
    {
        return _isComplete;

    }
    //Method
    public override string GetStringRepresentation()
    {
        return $"SimpleGoal:{GetShortName()},{GetDescription()},{GetPoints()},{_isComplete}";

    }

}
