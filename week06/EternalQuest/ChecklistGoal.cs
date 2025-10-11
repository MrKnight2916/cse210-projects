public class ChecklistGoal : Goal
{
    private int _completedCount;
    private int _targetCount;
    private int _bonus;
    private bool _isComplete;

    public ChecklistGoal(string name, string description, int points, int targetCount, int bonus)
        : base(name, description, points)
    {
        _targetCount = targetCount;
        _bonus = bonus;
        _completedCount = 0;
        _isComplete = false;
    }

    public override int RecordEvent()
    {
        if (_isComplete) return 0;

        _completedCount++;
        int earned = Points;

        if (_completedCount >= _targetCount)
        {
            _isComplete = true;
            earned += _bonus;
        }

        return earned;
    }

    public override string GetDetails()
    {
        return $"[{(_isComplete ? "X" : " ")}] {base.GetDetails()} - {Points} pts ({_completedCount}/{_targetCount})";
    }

    public override string Serialize()
    {
        return $"ChecklistGoal:{Name},{Description},{Points},{_completedCount},{_targetCount},{_bonus},{_isComplete}";
    }

    public static ChecklistGoal Deserialize(string data)
    {
        var parts = data.Split(',');
        var goal = new ChecklistGoal(parts[0], parts[1], int.Parse(parts[2]), int.Parse(parts[4]), int.Parse(parts[5]));
        goal._completedCount = int.Parse(parts[3]);
        goal._isComplete = bool.Parse(parts[6]);
        return goal;
    }
}
