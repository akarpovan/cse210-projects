using System;

public class Activity
{
    //attributes
    protected string _name;
    protected string _description;
    protected int  _duration;

    //Constructor
    public Activity()
    {
    }
    public Activity(string name, string description)
    {
        _name = name;
        _description = description;
    }

    //Method
    public void DisplayStartingMessage()
    {
        Console.Clear();
        Console.WriteLine($"Welcome to the {_name} Activity.");
        Console.WriteLine("\n");
        Console.WriteLine($"{_description}");
        Console.WriteLine("\n");
        Console.Write("How long, in seconds, would you like for your session? ");
        _duration = int.Parse(Console.ReadLine());

        int seconds = 3;
        Console.Clear();
        Console.WriteLine("Get ready...");
        ShowSpinner(seconds);
        Console.WriteLine("\n");
    }
    //Method
    public void DisplayEndingMessage()
    {
        int seconds = 3;
        Console.WriteLine("Well done!! Great work!!\n");
        ShowSpinner(seconds);
        Console.WriteLine("\n");
        Console.WriteLine($"You have completed another {_duration} seconds of the {_name} Activity.");
        ShowSpinner(seconds);
    }
    //Method
    public void ShowSpinner(int seconds)
    {
        List<string> animationStrings = new List<string>();
        /*animationStrings.Add("|");
        animationStrings.Add("/");
        animationStrings.Add("-");
        animationStrings.Add("\\");*/

        animationStrings.Add("=>     ");
        animationStrings.Add("==>    ");
        animationStrings.Add("===>   ");
        animationStrings.Add("====>  ");
        animationStrings.Add("=====> ");
        animationStrings.Add("======>");

        animationStrings.Add(".          ");
        animationStrings.Add("..         ");
        animationStrings.Add("..(        ");
        animationStrings.Add("..(=       ");
        animationStrings.Add("..(=•      ");
        animationStrings.Add("..(=•_     ");
        animationStrings.Add("..(=•_•    ");
        animationStrings.Add("..(=•_•=   ");
        animationStrings.Add("..(=•_•=)  ");
        animationStrings.Add("..(=•_•=). ");
        animationStrings.Add("..(=•_•=)..");

        /*foreach (string s in animationStrings)
        {
            Console.Write(s);
            Thread.Sleep(1000 * seconds);
            Console.Write("\b \b");

        }*/
        int delay = 200 * seconds; // milisegundos

        foreach (string s in animationStrings)
        {
            Console.Write(s);
            Thread.Sleep(delay);

            // Borrar la cadena anterior
            int length = s.Length;
            Console.Write(new string('\b', length)); // retrocede
            Console.Write(new string(' ', length));  // sobrescribe con espacios
            Console.Write(new string('\b', length)); // retrocede para escribir de nuevo
        }
    }
    //Method
    public void ShowCountDown(int seconds)
    {
        int delay = 500;
        for (int i = seconds; i > 0; i--)
        {
            Console.Write(i);
            Thread.Sleep(delay);
            Console.Write("\b \b");
        }

    }

}