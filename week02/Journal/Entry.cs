using System;

public class Entry
{
    public string _dateCreated;
    public string _prompt;
    public string _response;
    public string _status;

    public Entry()
    {
    }

    public void DisplayEntry()
        {
            Console.WriteLine($"Date: {_dateCreated} - Prompt: {_prompt}");
            Console.WriteLine($"{_response} - Status: {_status}");
        }
}
