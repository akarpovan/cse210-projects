using System;
using System.Globalization;

public abstract class Activity
{
    //attributes
    private DateTime _date;
    private int _minutes;

    //Constructor
    public Activity(DateTime date, int minutes)
    {
        _date = date;
        _minutes = minutes;
    }    

    public DateTime GetDate()
    {
        return _date;
    }

    public int GetMinutes()
    {
        return _minutes;
    }

    public abstract double GetDistance();
    public abstract double GetSpeed();
    public abstract double GetPace();
    public abstract string GetActivityName();

    //Method
    public virtual string GetSummary()
    {
        //03 Nov 2022 Running (30 min)- Distance 3.0 miles, Speed 6.0 mph, Pace: 10.0 min per mile
        string dateString = _date.ToString("dd MMM yyyy", CultureInfo.InvariantCulture);
        return $"{dateString} {GetActivityName()} ({_minutes} min)- Distance {GetDistance():F1} miles, Speed {GetSpeed():F1} mph, Pace: {GetPace():F1} min per mile";
    }
}
