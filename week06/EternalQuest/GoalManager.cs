using System;
using System.Collections.Generic;
using System.IO;

public class GoalManager
{
    private List<Goal> _goals = new List<Goal>();
    private int _score = 0;
    private string _filename = "goals.txt";

    // Propiedad para acceder al score
    public int Score
    {
        get { return _score; }
    }

    // Propiedad para saber cuántos goals hay
    public int GoalsCount
    {
        get { return _goals.Count; }
    }

    public void AddGoal(Goal goal)
    {
        _goals.Add(goal);
    }

    public void ListGoals()
    {
        for (int i = 0; i < _goals.Count; i++)
        {
            Console.WriteLine($"{i + 1}. {_goals[i].GetDetails()}");
        }
    }

    public void RecordEvent(int index)
    {
        if (index < 0 || index >= _goals.Count) return;
        int earned = _goals[index].RecordEvent();
        _score += earned;
        Console.WriteLine($"Event recorded! You earned {earned} points.");
    }

    public void ShowScore()
    {
        Console.WriteLine($"Total score: {_score}");
    }

    public void SaveToFile()
    {
        using (StreamWriter writer = new StreamWriter(_filename))
        {
            writer.WriteLine(_score);
            foreach (var goal in _goals)
            {
                writer.WriteLine(goal.Serialize());
            }
        }
    }

    public void LoadFromFile()
    {
        if (!File.Exists(_filename)) return;

        var lines = File.ReadAllLines(_filename);
        _goals.Clear();
        _score = int.Parse(lines[0]);

        for (int i = 1; i < lines.Length; i++)
        {
            string line = lines[i];
            string type = line.Split(':')[0];
            string data = line.Substring(line.IndexOf(':') + 1);

            switch (type)
            {
                case "SimpleGoal":
                    _goals.Add(SimpleGoal.Deserialize(data));
                    break;
                case "EternalGoal":
                    _goals.Add(EternalGoal.Deserialize(data));
                    break;
                case "ChecklistGoal":
                    _goals.Add(ChecklistGoal.Deserialize(data));
                    break;
            }
        }
    }
}
