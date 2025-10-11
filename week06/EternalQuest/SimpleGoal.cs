public class SimpleGoal : Goal
{
    private bool _isComplete;

    public SimpleGoal(string name, string description, int points)
        : base(name, description, points)
    {
        _isComplete = false;
    }

    public override int RecordEvent()
    {
        if (!_isComplete)
        {
            _isComplete = true;
            return Points;
        }
        return 0;
    }

    public override string GetDetails()
    {
        return $"[{(_isComplete ? "X" : " ")}] {base.GetDetails()} - {Points} pts";
    }

    public override string Serialize()
    {
        return $"SimpleGoal:{Name},{Description},{Points},{_isComplete}";
    }

    public static SimpleGoal Deserialize(string data)
    {
        var parts = data.Split(',');
        var goal = new SimpleGoal(parts[0], parts[1], int.Parse(parts[2]));
        goal._isComplete = bool.Parse(parts[3]);
        return goal;
    }
}
