using System;

class Program
{
    static void Main(string[] args)
    {
        //Console.WriteLine("Hello World! This is the ExerciseTracking Project.");
        List<Activity> activities = new List<Activity>();
        DateTime date = new DateTime(2022, 11, 3);
        //Running Activity
        RunningActivity runningActivity = new RunningActivity(date,30,3.0);
        activities.Add(runningActivity);

        //Cycling activity  
        CyclingActivity cyclingActivity = new CyclingActivity(date.AddDays(1),45,15.0);
        activities.Add(cyclingActivity);

        //Swimming activity
        SwimmingActivity swimmingActivity = new SwimmingActivity(date.AddDays(2),25,40);
        activities.Add(swimmingActivity);

        //Running Activity
        RunningActivity nextRunningActivity = new RunningActivity(date.AddDays(3),20,2.5);
        activities.Add(nextRunningActivity);

        //Cycling activity  
        CyclingActivity nextCyclingActivity = new CyclingActivity(date.AddDays(4),60,12.5);
        activities.Add(nextCyclingActivity);

        //Swimming activity
        SwimmingActivity nextSwimmingActivity = new SwimmingActivity(date.AddDays(5),35,60);
        activities.Add(nextSwimmingActivity);

        //03 Nov 2022 Running (30 min)- Distance 3.0 miles, Speed 6.0 mph, Pace: 10.0 min per mile
        foreach (Activity activity in activities)
        {
            Console.WriteLine(activity.GetSummary());
        }

    }
}