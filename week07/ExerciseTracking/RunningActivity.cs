using System;

public class RunningActivity : Activity
{
    //attributes
    private double _distance;

    //Constructor
    public RunningActivity(DateTime date, int minutes, double distance) : base(date, minutes)
    {
        _distance = distance;
    }

    //Method
    public override string GetActivityName()
    {
        return "Running";
    }
    //Method
    public override double GetDistance()
    {
        return _distance;
    }
    //Method
    public override double GetSpeed()
    {
        return (_distance / GetMinutes()) * 60;
    }
    //Method
    public override double GetPace()
    {
        return GetMinutes() / _distance;
    }
}
