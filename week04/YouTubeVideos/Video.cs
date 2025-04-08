using System;
using System.Collections.Generic;

class Video
{
    public string _title;
    public string _author;
    public int _length;
    public List<Comment> Comments { get; } = new();

    public Video(string title, string author, int length)
    {
        _title = title;
        _author = author;
        _length = length;
    }

    public void AddComment(Comment comment)
    {
        Comments.Add(comment);
    }

    public void DisplayInfo()
    {
        Console.WriteLine($"Title: {_title}");
        Console.WriteLine($"Author: {_author}");
        Console.WriteLine($"Length: {(_length/60f):F2} minutes");
        Console.WriteLine($"Comments: ");
        foreach (var comment in Comments)
        {
            Console.WriteLine($". {comment._name}: {comment._text}");
        }
        Console.WriteLine();
    }
}