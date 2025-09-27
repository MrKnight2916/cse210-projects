using System;

public class Entry
{
    private string _date;
    private string _promptText;
    private string _entryText;

    // Constructor
    public Entry(string date, string promptText, string entryText)
    {
        _date = date;
        _promptText = promptText;
        _entryText = entryText;
    }

    // Method to display the entry
    public void Display()
    {
        Console.WriteLine($"{_date} - {_promptText}: {_entryText}");
    }

    // Convert entry to string for saving
    public override string ToString()
    {
        return $"{_date}|{_promptText}|{_entryText}";
    }
}
