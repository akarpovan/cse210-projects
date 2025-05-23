using System;

class Program
{
    static void Main(string[] args)
    {
        //Console.WriteLine("Hello World! This is the ScriptureMemorizer Project.");
        Console.WriteLine("Welcome to the Scripture Memorizer Program!");
        //string option = "0";
        string scriptureOption = "0";

        Scripture scripture = new Scripture();
        ScriptureElement userElement = new ScriptureElement();
        List<ScriptureElement> elements = new List<ScriptureElement>();
        elements = scripture.LoadFromFile();

        Console.WriteLine("List of the Scriptures to Memorize:");
        scripture.DisplayElements();
        
        Console.Write("Choose the scripture you want to memorize from the list. Digit the number (example: 1): ");
        scriptureOption = Console.ReadLine();

        foreach (var element in elements)
        {
            if (element.GetNumberOfScripture() == Convert.ToInt32(scriptureOption))
            {
                userElement = element;
                break;
            }
        }

        Reference reference = new Reference();
        Reference userReference = reference.GetReference(userElement.GetTextReference());
        //Scripture userScripture = new Scripture(userElement.GetNumberOfScripture(), userReference, userElement.GetTextScripture());
        Scripture userScripture = new Scripture(userReference, userElement.GetTextScripture());

        while (true)
        {
            Console.Clear();

            Console.WriteLine(userReference.GetDisplayText());
            Console.WriteLine();

            Console.WriteLine(userScripture.GetDisplayText());
            Console.WriteLine();

            if (userScripture.IsCompletelyHidden())
            {
                // All words hidden, end program
                Console.WriteLine("Thank you. Goodbye!");
                break;
            }

            Console.WriteLine("Press Enter to hide some words or type 'quit' to exit.");
            string input = Console.ReadLine().Trim().ToLower();

            if (input == "quit")
            {
                Console.WriteLine("Thank you. Goodbye!");
                break;
            }
            else
            {
                // Hide more words (core requirement: can hide any words, including already hidden)
                int randomWords = 5;
                //userScripture.HideRandomWords(randomWords);
                userScripture.HideRandomUnhiddenWords(randomWords);
            }

        }

        /*Console.Write("Press enter to continue or type 'quit' to finish: ");
        if (Console.ReadKey().Key == ConsoleKey.Enter)
        {
            option = "enter";
        }
        else
        {
            option = Console.ReadLine();
        }
        Console.WriteLine();

         switch (option)
            {
                case "enter":
                    Console.WriteLine("OK!");
                    break;
                case "quit":
                    Console.WriteLine("Thank you. Goodbye!");
                    break;
                default:
                    Console.WriteLine("Invalid option. Goodbye!\n");
                    break;
            }
        */
    }
}