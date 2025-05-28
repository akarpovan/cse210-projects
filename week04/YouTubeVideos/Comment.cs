using System;

public class Comment
{
    public string _personName;
    public string _textComment;

    // Constructor
    public Comment(string name, string text)
    {
        _personName = name;
        _textComment = text;
    }

    public void DisplayComment()
    {
        Console.WriteLine($"  - Person name: {_personName} - Comment: {_textComment}");
    }
}
