using System;

public class CyclingActivity : Activity
{
    //attributes
    private double _speed;
    //Constructor
    public CyclingActivity(DateTime date, int minutes, double speed) : base(date, minutes)
    {
        _speed = speed;
    }
    //Method
    public override string GetActivityName()
    {
        return "Cycling";
    }
    //Method
    public override double GetDistance()
    {
        return (_speed * GetMinutes()) / 60;
    }
    //Method
    public override double GetSpeed()
    {
        return _speed;
    }
    //Method
    public override double GetPace()
    {
        return 60 / _speed;
    }
}
