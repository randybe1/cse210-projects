using System;
using System.Collections.Generic;
using System.Linq;

namespace Foundation1
{
public class Video
{
    private string _title;
    private string _author;
    private string _length;

    // Constructor
    public Video(string title, string author, string length)
    {
        _title = title;
        _author = author;
        _length = length;
    }

    // List to store comments
    private List<Comment> _comments = new List<Comment>();

    // Method to display comments
    public void DisplayComments()
    {
        foreach (Comment comment in _comments)
        {
            comment.Display();
        }
        Console.WriteLine($"{_comments.Count} comments\n");
    }

    // Method to add a new comment
    public void AddComment(string name, string text)
    {
        _comments.Add(new Comment(name, text));
    }

    // Method to display video information
    public void DisplayVideoInfo()
    {
        Console.WriteLine($"{_title}, {_author}, {_length}");
    }
}

} 