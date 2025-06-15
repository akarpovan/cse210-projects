using System;

public class EternalGoal : Goal
{
    //Constructor
    public EternalGoal(string name, string description, int points) : base (name, description, points)
    {

    }

    //Method
    public override void RecordEvent()
    {

    }
    //Method
    public override bool IsComplete()
    {
        return false;
    }
    //Method
    public override string GetStringRepresentation()
    {
        return $"EternalGoal:{GetShortName()},{GetDescription()},{GetPoints()}";
    }

}
