using System;

public abstract class Activity
{
    // Private fields for encapsulation
    private string _date;
    private int _minutes;

    // Constructor
    public Activity(string date, int minutes)
    {
        _date = date;
        _minutes = minutes;
    }

    // Public properties
    public string Date { get { return _date; } }
    public int Minutes { get { return _minutes; } }

    // Abstract methods for polymorphism
    public abstract double GetDistance(); // km or miles
    public abstract double GetSpeed();    // km/h or mph
    public abstract double GetPace();     // min/km or min/mile

    // Summary method
    public virtual string GetSummary()
    {
        return $"{Date} {this.GetType().Name} ({Minutes} min) - Distance {GetDistance():F2}, Speed {GetSpeed():F2}, Pace {GetPace():F2}";
    }
}
