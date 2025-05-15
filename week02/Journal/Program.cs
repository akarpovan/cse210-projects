using System;

class Program
{
    static void Main(string[] args)
    {
        //Console.WriteLine("Hello World! This is the Journal Project.");
        Journal journal = new Journal();

        Console.WriteLine("Welcome to the daily Journal Program!");

        string option = "0";
        string option_quit = "5";
        string prompt = "";
        string response = "";
        string date = "";
        while (option != option_quit)
        {
            Console.WriteLine("Please select one of the following options from menu:");
            Console.WriteLine("Menu:");
            Console.WriteLine("1. Write");
            Console.WriteLine("2. Display");
            Console.WriteLine("3. Load");
            Console.WriteLine("4. Save");
            Console.WriteLine("5. Quit");
            Console.Write("What would you like to do? Please enter the option: ");
            option = Console.ReadLine();
            Console.WriteLine();

            switch (option)
            {
                case "1":
                    Entry newEntry = new Entry();
                    PromptGenerator promptGenerator = new PromptGenerator();
                    prompt = promptGenerator.GenerateRandomPrompt();
                    Console.WriteLine($"{prompt}");
                    Console.Write("Your response: ");
                    response = Console.ReadLine();
                    date = DateTime.Now.ToString("dd/MM/yyyy HH:mm:ss");
                    newEntry._dateCreated = date;
                    newEntry._prompt = prompt;
                    newEntry._response = response;
                    journal.AddEntry(newEntry);
                    break;
                case "2":
                    journal.DisplayEntries();
                    break;
                case "3":
                    journal.LoadFromFile();
                    break;
                case "4":
                    journal.SaveToFile();
                    break;
                case "5":
                    Console.WriteLine("Thank you. Goodbye!");
                    break;
                default:
                    Console.WriteLine("Invalid option. Please enter a number between 1 and 5.\n");
                    break;
            }
        }
        
    }
}