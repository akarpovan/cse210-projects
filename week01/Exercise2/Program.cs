using System;

class Program
{
    static void Main(string[] args)
    {
        //Console.WriteLine("Hello World! This is the Exercise2 Project.");
        Console.Write("What is your grade percentage? ");
        string user_persent = Console.ReadLine();
        int persent = int.Parse(user_persent);
        string letter = "";

        if (persent >= 90)
        {
            letter = "A";
        }
        else if (persent >= 80)
        {
            letter = "B";
        }
        else if (persent >= 70)
        {
            letter = "C";
        }
        else if (persent >= 60)
        {
            letter = "D";
        }
        else
        {
            letter = "F";
        }

        //Stretch Challenge 1
        string sign = "";
        int last_digit = persent % 10;

        if (last_digit >= 7)
        {
            sign = "+";
        }
        else if (last_digit < 3)
        {
            sign = "-";
        }
        else
        {
            sign = "";   
        }

        Console.WriteLine($"Your grade is {letter}{sign}.");

        if (persent >= 70)
        {
            Console.WriteLine("Congratulations! You passed the course.");
        } 
        else
        {
            Console.WriteLine("Don't get discouraged! You can do it!");
        }
    }
}