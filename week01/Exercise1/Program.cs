using System;

class Program
{
    static void Main(string[] args)
    {
        //Console.WriteLine("Hello World! This is the Exercise1 Project.");

        //Ask the user for their first name.
        Console.Write("What is your first name? ");
        string first_name = Console.ReadLine();

        //Ask the user for their last name.
        Console.Write("What is your last name? ");
        string last_name = Console.ReadLine();

        //Display the text back all on one line.
        Console.WriteLine("");
        Console.WriteLine($"Your name is {last_name}, {first_name} {last_name}.");
    }
}