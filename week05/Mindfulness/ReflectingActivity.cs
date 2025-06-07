using System;

public class ReflectingActivity : Activity
{
    //attributes - lists
    private List<string> _prompts = new List<string>
    {
        "Think of a time when you stood up for someone else.",
        "Think of a time when you did something really difficult.",
        "Think of a time when you helped someone in need.",
        "Think of a time when you did something truly selfless."
    };

    private List<string> _questions = new List<string>
    {
        "Why was this experience meaningful to you?",
        "Have you ever done anything like this before?",
        "How did you get started?",
        "How did you feel when it was complete?",
        "What made this time different than other times when you were not as successful?",
        "What is your favorite thing about this experience?",
        "What could you learn from this experience that applies to other situations?",
        "What did you learn about yourself through this experience?",
        "How can you keep this experience in mind in the future?"
    };

    //Constructor
    public ReflectingActivity() : base ()
    {
        _name = "Reflecting";
        _description = "This activity will help you reflect on times in your life when you have shown strength and resilience. This will help you recognize the power you have and how you can use it in other aspects of your life.";
    }

    private Random random = new Random();
    //Method
    public string GenerateRandomPrompt()
    {
        int index = random.Next(_prompts.Count);
        return _prompts[index];
    }

    //Method
    public string GenerateRandomQuestion()
    {
        int index = random.Next(_questions.Count);
        return _questions[index];
    }

    public void Run()
    {
        DisplayStartingMessage();
        int seconds = 5;

        DisplayPrompt();
        Console.WriteLine("When you have something in mind, press enter to continue.");
        Console.ReadLine();
        
        Console.WriteLine("Now ponder on each of the following questions as they relate to this experience.");
        Console.Write("You may begin in: ");
        ShowCountDown(seconds);

        DateTime startTime = DateTime.Now;
        DateTime endTime = startTime.AddSeconds(_duration);
        
        while (DateTime.Now < endTime)
        {
            DisplayQuestions();
        }
        
        DisplayEndingMessage();

    }

    public void DisplayPrompt()
    {
        string prompt = GenerateRandomPrompt();
        Console.WriteLine("\n");
        Console.WriteLine("Consider the following prompt:");
        Console.WriteLine("\n");
        Console.WriteLine($"--- {prompt} ---");
        Console.WriteLine("\n");
    }

    public void DisplayQuestions()
    {
        string question = GenerateRandomQuestion();
        Console.Clear();
        Console.WriteLine($"> {question}");
        ShowSpinner(15);
        Console.WriteLine();
    }

}