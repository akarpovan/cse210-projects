using System;

public class BreathingActivity : Activity
{
    //Constructor
    public BreathingActivity() : base ()
    {
        _name = "Breathing";
        _description = "This activity will help you relax by walking your through breathing in and out slowly. Clear your mind and focus on your breathing.";
    }

    //Method
    public void Run()
    {
        DisplayStartingMessage();
        DateTime startTime = DateTime.Now;
        DateTime endTime = startTime.AddSeconds(_duration);
        bool breatheIn = true;
        int secondsIn = 8;
        int secondsOut = 10;
        
        while (DateTime.Now < endTime)
        {
            if (breatheIn)
            {
                Console.Write("Breathe in...");
                ShowCountDown(secondsIn);
                Console.WriteLine();
                breatheIn = false;
            }
            else
            {
                Console.Write("Now breathe out...");
                ShowCountDown(secondsOut);
                Console.WriteLine();
                breatheIn = true;
                Console.WriteLine("\n");
            }
        }
        
        DisplayEndingMessage();

    }

    
}

