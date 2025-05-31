using System;

class Program
{
    static void Main(string[] args)
    {
        //Console.WriteLine("Hello World! This is the Homework Project.");
        Console.WriteLine("Welcome to the Homework Project.\n");

        //Create a simple assignment, call the method to get the summary, 
        //and then display it to the screen.
        Assignment assignment = new Assignment("Samuel Bennett","Multiplication");
        Console.WriteLine(assignment.GetSummary());
        Console.WriteLine();

        MathAssignment math = new MathAssignment("Roberto Rodriguez","Fractions", "7.3", "8-19");
        Console.WriteLine(math.GetSummary());
        Console.WriteLine(math.GetHomeworkList());
        Console.WriteLine();

        WritingAssignment write = new WritingAssignment("Mary Waters","European History","The Causes of World War II");
        Console.WriteLine(write.GetSummary());
        Console.WriteLine(write.GetWritingInformation());
        Console.WriteLine();
    }
}