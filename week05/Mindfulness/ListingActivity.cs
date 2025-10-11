using System;
using System.Collections.Generic;

public class ListingActivity : Activity
{
    private List<string> _prompts;
    private Random _random;

    public ListingActivity()
    {
        _name = "Listing Activity";
        _description = "This activity will help you reflect on the good things in your life by having you list as many items as possible in a certain area.";
        _prompts = new List<string> {
            "Who are people that you appreciate?",
            "What are your personal strengths?",
            "Who have you helped this week?",
            "When have you felt the Holy Spirit this month?",
            "Who are some of your personal heroes?"
        };
        _random = new Random();
    }

    public override void Run()
    {
        string prompt = _prompts[_random.Next(_prompts.Count)];
        Console.WriteLine("\nPrompt: " + prompt);
        Console.WriteLine("Think for 5 seconds...");
        ShowCountDown(5);

        List<string> items = new List<string>();
        DateTime endTime = DateTime.Now.AddSeconds(_duration);

        Console.WriteLine("\nStart listing your answers!");
        while (DateTime.Now < endTime)
        {
            Console.Write("> ");
            string input = Console.ReadLine();
            if (!string.IsNullOrWhiteSpace(input))
            {
                items.Add(input);
            }
        }

        Console.WriteLine($"\nYou listed {items.Count} items.");
    }
}
