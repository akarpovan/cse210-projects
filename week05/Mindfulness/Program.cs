using System;

class Program
{
    static void Main(string[] args)
    {
        //Console.WriteLine("Hello World! This is the Mindfulness Project.");
        Console.WriteLine("Welcome to the Mindfulness Program!");

        string option = "0";
        string option_quit = "4";

        while (option != option_quit)
        {
            Console.WriteLine("Menu options:");
            Console.WriteLine("  1. Start breathing activity");
            Console.WriteLine("  2. Start reflecting activity");
            Console.WriteLine("  3. Start listing activity");
            Console.WriteLine("  4. Quit");
            Console.Write("Please select a choice from the menu: ");
            option = Console.ReadLine();
            Console.WriteLine();

            switch (option)
            {
                case "1": //breathing activity
                    BreathingActivity breathingActivity = new BreathingActivity();
                    breathingActivity.Run();
                    break;
                case "2": //reflecting activity
                    ReflectingActivity reflectingActivity = new ReflectingActivity();
                    reflectingActivity.Run();
                    break;
                case "3": //listing activity
                    ListingActivity listingActivity = new ListingActivity();
                    listingActivity.Run();
                    break;
                case "4":
                    Console.WriteLine("Thank you. Goodbye!");
                    break;
                default:
                    Console.WriteLine("Invalid option. Please enter a number between 1 and 4.");
                    Console.WriteLine("\n");
                    break;
            }
        }
        
    }

}
