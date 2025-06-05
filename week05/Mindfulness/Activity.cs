using System;

public class Activity
{
    //attributes
    protected string _name;
    protected string _description;
    protected int  _duration;

    //Constructor
    public Activity()
    {
    }
    public Activity(string name, string description)
    {
        _name = name;
        _description = description;
    }

    //Method
    public void DisplayStartingMessage()
    {
        Console.Clear();
        Console.WriteLine($"Welcome to the {_name} Activity.");
    }

    public void DisplayEndingMessage()
    {
        Console.WriteLine("Well done!! Great work!!\n");
    }

    public void ShowSpinner(int seconds)
    {
    }

    public void ShowCountDown(int seconds)
    {

    }


}
