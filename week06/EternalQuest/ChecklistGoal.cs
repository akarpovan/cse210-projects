using System;

public class ChecklistGoal : Goal
{
    //attributes
    private int _amountCompleted;
    private int _target;
    private int _bonus;

    //Constructor
    //In addition to the standard attributes, a checklist goal also needs the target 
    //and the bonus amounts. Then, it should set the amount completed to begin at 0.
    public ChecklistGoal(string name, string description, int points, int target, int bonus) : base (name, description, points)
    {
        _amountCompleted = 0;
        _target = target;
        _bonus = bonus;
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
    public string GetDetailsString()
    {
        return "";

    }
    
    //Method
    public override string GetStringRepresentation()
    {
        return "";

    }


}
