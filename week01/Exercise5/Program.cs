using System;

class Program
{
    static void Main(string[] args)
    {
        //Console.WriteLine("Hello World! This is the Exercise5 Project.");
        DisplayWelcomeMessage();
        string user_name = PromptUserName();
        int user_number = PromptUserNumber();
        int square_number = SquareNumber(user_number);
        DisplayResult(user_name,square_number);

        static void DisplayWelcomeMessage()
        {
            Console.WriteLine("Welcome to the program!");
        }

        static string PromptUserName()
        {
            Console.Write("Please enter your name: ");
            string user_name = Console.ReadLine();
            return user_name;
        }

        static int PromptUserNumber()
        {
            Console.Write("Please enter your favorite number: ");
            int favorite_number = int.Parse(Console.ReadLine());
            return favorite_number;
        }

        static int SquareNumber(int number)
        {
            int square = number * number;
            return square;
        }

        static void DisplayResult(string name, int square)
        {
            Console.WriteLine($"{name}, the square of your number is {square}");
        }

    }
}