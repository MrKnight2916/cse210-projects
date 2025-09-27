using System;
using System.Collections.Generic;

// Comment class
class Comment
{
    public string Author { get; private set; }
    public string Text { get; private set; }

    public Comment(string author, string text)
    {
        Author = author;
        Text = text;
    }

    public override string ToString()
    {
        return $"{Author}: {Text}";
    }
}

// Video class
class Video
{
    public string Title { get; private set; }
    public string Author { get; private set; }
    public int Duration { get; private set; } // in seconds
    private List<Comment> comments;

    public Video(string title, string author, int duration)
    {
        Title = title;
        Author = author;
        Duration = duration;
        comments = new List<Comment>();
    }

    public void AddComment(Comment comment)
    {
        comments.Add(comment);
    }

    public int GetNumberOfComments()
    {
        return comments.Count;
    }

    public List<Comment> GetComments()
    {
        return comments;
    }
}

// Main program
class Program
{
    static void Main(string[] args)
    {
        // Create videos
        Video video1 = new Video("Learning C#", "John Smith", 300);
        Video video2 = new Video("Classes and Objects", "Mary Johnson", 420);
        Video video3 = new Video("Advanced Programming", "Carlos Gomez", 540);

        // Add comments
        video1.AddComment(new Comment("Anna", "Very useful!"));
        video1.AddComment(new Comment("Luke", "Thanks for the explanation."));
        video1.AddComment(new Comment("Martha", "Excellent video."));

        video2.AddComment(new Comment("Peter", "Helped me a lot."));
        video2.AddComment(new Comment("Lucy", "Easy to understand."));
        video2.AddComment(new Comment("Diego", "Good example."));

        video3.AddComment(new Comment("Sarah", "Amazing content."));
        video3.AddComment(new Comment("George", "I will practice this."));
        video3.AddComment(new Comment("Elena", "Thanks for sharing."));

        // List of videos
        List<Video> videos = new List<Video> { video1, video2, video3 };

        // Display information
        foreach (Video video in videos)
        {
            Console.WriteLine($"Title: {video.Title}");
            Console.WriteLine($"Author: {video.Author}");
            Console.WriteLine($"Duration: {video.Duration} seconds");
            Console.WriteLine($"Number of comments: {video.GetNumberOfComments()}");
            Console.WriteLine("Comments:");
            foreach (Comment comment in video.GetComments())
            {
                Console.WriteLine($" - {comment}");
            }
            Console.WriteLine("-----------------------------");
        }
    }
}
