using System;

class Program
{
    static void Main(string[] args)
    {
        //Console.WriteLine("Hello World! This is the Exercise4 Project.");
        Console.WriteLine("Enter a list of numbers, type 0 when finished.");
        List<int> numbers = new List<int>();
        int number = -1;
        double sum = 0;
        int count = 0;

        while (number != 0)
        {
            Console.Write("Enter number: ");
            string user_number = Console.ReadLine();
            number = int.Parse(user_number);

            if (number != 0)
            {
                numbers.Add(number);
            }
        }

        //1. Compute the sum, or total, of the numbers in the list.
        foreach (int num in numbers)
        {
            sum += num;
        }
        Console.WriteLine($"The sum is: {sum}.");

        //2. Compute the average of the numbers in the list.
        if (numbers != null && numbers.Count > 0)
        {
            count = numbers.Count;
        }
        double average = sum / count;
        Console.WriteLine($"The average is: {average}.");

        //3. Find the maximum, or largest, number in the list.
        int largest = -1;
        foreach (int num in numbers)
            if (num > largest)
            {
                largest = num;
            }
        Console.WriteLine($"The largest number is: {largest}.");

        //1. Have the user enter both positive and negative numbers, 
        //then find the smallest positive number (the positive number that is closest to zero).
        int smallest = 999999999;
        foreach (int num in numbers)
        {
            if (num > 0 && num < smallest)
            {
                smallest = num;
            }
        }
        Console.WriteLine($"The smallest positive number is: {smallest}.");

        //2. Sort the numbers in the list and display the new, sorted list. 
        //Hint: There are C# libraries that can help you here, try searching the internet for them.
        List<int> sorted_list = new List<int>(numbers); // Create one copy of list "numbers"
        sorted_list.Sort(); //Sort list

        Console.WriteLine("The sorted list is:");
        foreach (int num in sorted_list)
        {
            Console.WriteLine($"{num}");
        }

    }
}