using System;

public class Video
{
    //Attributes
    public string _title;
    public string _author;
    public int _lengthVideo;
    //List to store comments
    private List<Comment> _comments;

    //Constructor
    public Video(string title, string author, int length)
    {
        _title = title;
        _author = author;
        _lengthVideo = length;
        //Initialize list
        _comments = new List<Comment>();
    }
    // Method
    public void AddComment(Comment comment)
    {
        _comments.Add(comment);
    }

    // Method
    public int GetNumberOfComments()
    {
        return _comments.Count;
    }
    // Method 
    public List<Comment> GetComments()
    {
        return _comments;
    }
    // Method
    public void DisplayVideoInformation(Video video)
    {
        Console.WriteLine($"Title: {video._title}");
        Console.WriteLine($"Author: {video._author}");
        Console.WriteLine($"Length: {video._lengthVideo} seconds");
        Console.WriteLine($"Number of Comments: {video.GetNumberOfComments()}");
        Console.WriteLine("Comments:");
        foreach (Comment comment in video.GetComments())
        {
            comment.DisplayComment();
        }
        Console.WriteLine(); // Empty line 
    }
}
