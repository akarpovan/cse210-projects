using System;

public class GoalManager
{
    //attributes
    private List<Goal> _goals;
    private int _score;

    //Constructor
    //Initializes and empty list of goals and sets the player's score to be 0.
    public GoalManager()
    {
        _score = 0;
        //Initialize list
        _goals = new List<Goal>();
    }

    //Method
    //This is the "main" function for this class. 
    //It is called by Program.cs, and then runs the menu loop.
    public void Start()
    {
        string option = "0";
        string typeGoal = "0";
        string option_quit = "6";
        GoalManager golManager = new GoalManager();

        while (option != option_quit)
        {
            //Displays the players current score.
            DisplayPlayerInfo();
            Console.WriteLine("\n");

            Console.WriteLine("Menu options:");
            Console.WriteLine("  1. Create new Goal");
            Console.WriteLine("  2. List Goals");
            Console.WriteLine("  3. Save Goals");
            Console.WriteLine("  4. Load Goals");
            Console.WriteLine("  5. Record Event");
            Console.WriteLine("  6. Quit");
            Console.Write("Select a choice from the menu: ");
            option = Console.ReadLine();
            Console.WriteLine();

            switch (option)
            {
                case "1": //Create new Goal
                    ListGoalNames();
                    Console.Write("Which type of goal would you like to create? ");
                    typeGoal = Console.ReadLine();
                    Console.WriteLine();
                    switch (typeGoal)
                    {
                        case "1": //Simple Goal
                        CreateGoal();
                        Console.WriteLine("\n");
                        break;
                        case "2": //Eternal Goal
                        break;
                        case "3": //Checklist Goal
                        break;
                    }
                    break;
                case "2": //List Goals

                    break;
                case "3": //Save Goals

                    break;
                case "4": //Load Goals

                    break;
                case "5": //Record Event

                    break;
                case "6":
                    Console.WriteLine("Thank you. Goodbye!");
                    break;
                default:
                    Console.WriteLine("Invalid option. Please enter a number between 1 and 6.");
                    Console.WriteLine("\n");
                    break;
            }
        }

    } 
    //Method
    //Displays the players current score.
    public void DisplayPlayerInfo()
    {
        Console.WriteLine($"You have {_score} points.");
    }
    //Method
    //Lists the names of each of the goals.
    public void ListGoalNames()
    {
        Console.WriteLine("The types of Goals are:");
        Console.WriteLine("  1. Simple Goal");
        Console.WriteLine("  2. Eternal Goal");
        Console.WriteLine("  3. Checklist Goal");
    }
    //Method
    //Lists the details of each goal (including the checkbox of whether it is complete).
    public void ListGoalDetails()
    {


    }
    //Method
    //Asks the user for the information about a new goal. 
    //Then, creates the goal and adds it to the list.
    public void CreateGoal()
    {
        Console.Write("What is the name of your goal? ");
        string shortName = Console.ReadLine();

        Console.Write("What is a short description of it? ");
        string description = Console.ReadLine();

        Console.Write("What is the amount of points associated with this goal? ");
        string pointsString = Console.ReadLine();
        int points = Convert.ToInt32(pointsString);

        SimpleGoal simpleGoal = new SimpleGoal(shortName,description,points);
        _goals.Add(simpleGoal);

    }
    //Method
    //Asks the user which goal they have done and then 
    //records the event by calling the RecordEvent method on that goal.
    public void RecordEvent()
    {


    }
    //Method
    //Saves the list of goals to a file.
    public void SaveGoals()
    {


    }
    //Method
    //Loads the list of goals from a file.
    public void LoadGoals()
    {


    }


}
