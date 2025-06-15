using System;
using System.IO; 
using System.Text.Json; 
using System.Collections.Generic;

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
            //Console.Clear();
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
                    CreateGoal();
                    break;
                case "2": //List Goals
                    ListGoalDetails();
                    break;
                case "3": //Save Goals
                    SaveGoals();
                    break;
                case "4": //Load Goals
                    LoadGoals();
                    break;
                case "5": //Record Event
                    RecordEvent();
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
        if (_goals.Count == 0)
        {
            Console.WriteLine("There are no goals recorded.");
        }
        else
        {
            Console.WriteLine("The goals are:");
            for (int i = 0; i < _goals.Count; i++)
            {
                Console.WriteLine($"{i + 1}. {_goals[i].GetDetailsString()}");
            }
        }
    }
    //Method
    //Asks the user for the information about a new goal. 
    //Then, creates the goal and adds it to the list.
    public void CreateGoal()
    {
        ListGoalNames();
        Console.Write("Which type of goal would you like to create? ");
        
        int goalType = int.Parse(Console.ReadLine());

        Console.Write("What is the name of your goal? ");
        string name = Console.ReadLine();

        Console.Write("What is a short description of it? ");
        string description = Console.ReadLine();

        Console.Write("What is the amount of points associated with this goal? ");
        string pointsString = Console.ReadLine();
        int points = Convert.ToInt32(pointsString);

        //Cannot create an instance of the abstract type
        //Declaration without initialization
        Goal newGoal;

        switch (goalType)
        {
            case 1:
                newGoal = new SimpleGoal(name, description, points);
                break;
            case 2:
                newGoal = new EternalGoal(name, description, points);
                break;
            case 3:
                Console.Write("How many times does this goal need to be accomplished for a bonus? ");
                int target = int.Parse(Console.ReadLine());
                Console.Write("What is the bonus for accomplishing it that many times? ");
                int bonus = int.Parse(Console.ReadLine());
                newGoal = new ChecklistGoal(name, description, points, target, bonus);
                break;
            default:
                Console.WriteLine("Invalid goal type.");
                return;
        }

        _goals.Add(newGoal);
    }
    //Method
    //Asks the user which goal they have done and then 
    //records the event by calling the RecordEvent method on that goal.
    public void RecordEvent()
    {
        if (_goals.Count == 0)
        {
            Console.WriteLine("No goals available to record.");
            return;
        }

        ListGoalNames();
        Console.Write("Which goal did you accomplish? ");
        string goalSelected = Console.ReadLine();
        int goalIndex = int.Parse(goalSelected) - 1;

        if (goalIndex >= 0 && goalIndex < _goals.Count)
        {
            Goal selectedGoal = _goals[goalIndex];
            
            // Check if SimpleGoal is already completed
            if (goalSelected == "1" && selectedGoal.IsComplete())
            {
                Console.WriteLine("This goal is already completed!");
                return;
            }

            // Check if ChecklistGoal was completed before recording
            bool wasChecklistComplete = false;
            if (goalSelected == "3")
            {
                wasChecklistComplete = selectedGoal.IsComplete();
            }

            // Record the event
            selectedGoal.RecordEvent();
            
            // Calculate points earned
            int pointsEarned = 0;
            
            if (goalSelected == "1")
            {
                pointsEarned = selectedGoal.GetPoints();
            }
            else if (goalSelected == "2")
            {
                pointsEarned = selectedGoal.GetPoints();
            }
            else if (goalSelected == "3")
            {
                ChecklistGoal checklistGoal = (ChecklistGoal)selectedGoal;
                pointsEarned = checklistGoal.GetPoints();
                
                // Add bonus if just completed
                if (!wasChecklistComplete && checklistGoal.IsComplete())
                {
                    pointsEarned = pointsEarned + checklistGoal.GetBonus();
                    Console.WriteLine($"Congratulations! You completed the checklist goal and earned a bonus of {checklistGoal.GetBonus()} points!");
                }
            }
            
            _score = _score + pointsEarned;
            
            Console.WriteLine($"Congratulations! You have earned {pointsEarned} points!");
            Console.WriteLine($"You now have {_score} points.");
        }
        else
        {
            Console.WriteLine("Invalid goal selection.");
        }

    }

    //Method
    //Saves the list of goals to a file.
    public void SaveGoals()
    {
        string entryString = "";
        Console.Write("What is the filename for the goal file? ");
        string filename = Console.ReadLine();

        try
        {
            using (StreamWriter outputFile = new StreamWriter(filename))
            {
                outputFile.WriteLine(_score);
                foreach (Goal goal in _goals)
                {
                    entryString = goal.GetStringRepresentation();
                    outputFile.WriteLine(entryString);
                }
            }
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Error saving file: {ex.Message}\n");
        }
    }
    //Method
    //Loads the list of goals from a file.
    public void LoadGoals()
    {
        Console.Write("What is the filename for the goal file? ");
        string filename = Console.ReadLine();

        if (File.Exists(filename))
        {
            string[] lines = File.ReadAllLines(filename);
            
            _score = int.Parse(lines[0]);
            _goals.Clear();

            for (int i = 1; i < lines.Length; i++)
            {
                string[] parts = lines[i].Split(':');
                string goalType = parts[0];
                string[] goalParts = parts[1].Split(',');

                Goal goal = null;

                switch (goalType)
                {
                    case "SimpleGoal":
                        goal = new SimpleGoal(goalParts[0], goalParts[1], 
                                            int.Parse(goalParts[2]));
                        break;
                    case "EternalGoal":
                        goal = new EternalGoal(goalParts[0], goalParts[1], int.Parse(goalParts[2]));
                        break;
                    case "ChecklistGoal":
                        goal = new ChecklistGoal(goalParts[0], goalParts[1], int.Parse(goalParts[2]),
                                               int.Parse(goalParts[3]), int.Parse(goalParts[4]));
                        break;
                }

                if (goal != null)
                {
                    _goals.Add(goal);
                }
            }
        }
        else
        {
            Console.WriteLine("File not found.");
        }

    }


}
