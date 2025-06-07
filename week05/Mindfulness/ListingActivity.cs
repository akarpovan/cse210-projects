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
    public ListingActivity() : base ()
    {
        _name = "Listing";
        _description = "This activity will help you reflect on the good things in your life by having you list as many things as you can in a certain area.";
        _count = 0;
    }

    public void Run()
    {
        DisplayStartingMessage();

        string prompt = GetRandomPrompt();
        int seconds = 5;
        
        Console.WriteLine("List as many responses you can to the following prompt:");
        Console.WriteLine("\n");
        Console.WriteLine($"--- {prompt} ---");
        Console.Write("You may begin in: ");
        ShowCountDown(seconds);
        Console.WriteLine("\n");

        List<string> listFromUser = new();
        DateTime startTime = DateTime.Now;
        DateTime endTime = startTime.AddSeconds(_duration);
        _count = 0;
        
        while (DateTime.Now < endTime)
        {
            Console.Write("> ");
            string response = Console.ReadLine();
            if (!string.IsNullOrWhiteSpace(response))
            {
                _listFromUser.Add(response);
                _count++;
            }
        }
        
        Console.WriteLine("\n");
        Console.WriteLine($"You listed {_count} items!");
        List<string> userList = GetListFromUser();
        foreach (string item in userList)
        {
            Console.WriteLine(item);
        }
        DisplayEndingMessage();

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