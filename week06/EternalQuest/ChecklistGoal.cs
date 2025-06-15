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
    public ChecklistGoal(string name, string description, int points, int target, int bonus) : base(name, description, points)
    {
        _amountCompleted = 0;
        _target = target;
        _bonus = bonus;
    }

    //Method
    public override void RecordEvent()
    {
        if (IsComplete() == false)
        {
            _amountCompleted = _amountCompleted + 1;
        }
    }
    //Method
    public override bool IsComplete()
    {
        bool isComplete = false;
        if (_amountCompleted >= _target)
        {
            isComplete = true;
        }
        return isComplete;
    }

    //Method
    public override string GetDetailsString()
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
        return $"{checkbox} {GetShortName()} ({GetDescription()}) -- Currently completed: {_amountCompleted}/{_target}";
    }

    //Method
    public override string GetStringRepresentation()
    {
        return $"ChecklistGoal:{GetShortName()},{GetDescription()},{GetPoints()},{_bonus},{_target},{_amountCompleted}";
    }

    public int GetBonus()
    {
        return _bonus;
    }

    public int GetAmountCompleted()
    {
        return _amountCompleted;
    }

    public int GetTarget()
    {
        return _target;
    }

}
