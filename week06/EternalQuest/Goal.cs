using System;

public abstract class Goal
{
    public string Name { get; private set; }
    public string Description { get; private set; }
    public int Points { get; private set; }

    public Goal(string name, string description, int points)
    {
        Name = name;
        Description = description;
        Points = points;
    }

    public abstract int RecordEvent(); // returns points earned

    public virtual string GetDetails()
    {
        return $"{Name} ({Description})";
    }

    public abstract string Serialize(); // for saving to file
}
