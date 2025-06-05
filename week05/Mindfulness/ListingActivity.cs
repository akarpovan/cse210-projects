using System;

public class ListingActivity : Activity
{
    //attributes    
    private int _count;
    private List<string> _prompts = new List<string>
    {
        "What are personal strengths of yours?",
        "Who are people that you have helped this week?",
        "When have you felt the Holy Ghost this month?",
        "Who are some of your personal heroes?"
    };
    private List<string> _listFromUser = new List<string>();


    //Constructor
    public ListingActivity()
    {
        _name = "Listing";
        _description = "This activity will help you reflect on the good things in your life by having you list as many things as you can in a certain area.";
        _count = 0;
    }

    public void Run()
    {

    }

    private Random random = new Random();

    public string GetRandomPrompt()
    {
        int index = random.Next(_prompts.Count);
        return _prompts[index];
    }

    public List<string> GetListFromUser()
    {
        return _listFromUser;
    }
}
