using System;
using System.Threading;

public class Activity
{
    protected string _name;
    protected string _description;
    protected int _duration; // in seconds

    public Activity() { }

    public void DisplayStartingMessage()
    {
        Console.Clear();
        Console.WriteLine($"--- {_name} ---");
        Console.WriteLine(_description);
        Console.Write("Enter the duration in seconds: ");
        while (!int.TryParse(Console.ReadLine(), out _duration) || _duration <= 0)
        {
            Console.Write("Please enter a valid number: ");
        }
        Console.WriteLine("Get ready to begin...");
        PauseWithSpinner(3);
    }

    public void DisplayEndingMessage()
    {
        Console.WriteLine("\nWell done!");
        PauseWithSpinner(2);
        Console.WriteLine($"You have completed the {_name} for {_duration} seconds.");
        PauseWithSpinner(3);
    }

    protected void PauseWithSpinner(int seconds)
    {
        string[] spinner = { "/", "-", "\\", "|" };
        for (int i = 0; i < seconds * 4; i++)
        {
            Console.Write(spinner[i % spinner.Length]);
            Thread.Sleep(250);
            Console.Write("\b");
        }
    }

    protected void ShowCountDown(int seconds)
    {
        for (int i = seconds; i > 0; i--)
        {
            Console.Write(i);
            Thread.Sleep(1000);
            Console.Write("\b \b");
        }
    }

    // Método virtual que será sobrescrito por cada actividad
    public virtual void Run()
    {
        Console.WriteLine("Running the base activity...");
    }
}
