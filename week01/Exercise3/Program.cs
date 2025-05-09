using System;
using System.Diagnostics;
using System.Xml.XPath;

class Program
{
    static void Main(string[] args)
    {
        //Console.WriteLine("Hello World! This is the Exercise3 Project.");
        //Console.Write("What is the magic number? ");
        //string user_magic_number = Console.ReadLine();
        //int magic_number = int.Parse(user_magic_number);
        string keep_playing = "yes";

        //As long as they say "yes" we will keep playing
        while (keep_playing == "yes")
        {
            Random randomGenerator = new Random();
            int magic_number = randomGenerator.Next(1, 101);

            int guess = -1;
            int guess_count = 0;
            string result = "";
            string user_guess = "";

            while (guess != magic_number)
            {
                Console.Write("What is your guess? ");
                user_guess = Console.ReadLine();
                guess = int.Parse(user_guess);
                guess_count += 1;

                if (magic_number > guess)
                {
                    result = "Higher";
                }
                else if (magic_number < guess)
                {
                    result = "Lower";
                }
                else
                {
                    result = "You guessed it!";
                }

                Console.WriteLine($"{result}");
            }

            Console.WriteLine($"It took you {guess_count} guesses.");
            Console.Write("Would you like to play again (yes/no)? ");
            keep_playing = Console.ReadLine();
        }

        Console.WriteLine("Thank you for playing. Goodbye.");

    }
}