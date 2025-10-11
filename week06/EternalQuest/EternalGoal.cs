public class EternalGoal : Goal
{
    public EternalGoal(string name, string description, int points)
        : base(name, description, points) { }

    public override int RecordEvent()
    {
        return Points;
    }

    public override string GetDetails()
    {
        return $"[∞] {base.GetDetails()} - {Points} pts per event";
    }

    public override string Serialize()
    {
        return $"EternalGoal:{Name},{Description},{Points}";
    }

    public static EternalGoal Deserialize(string data)
    {
        var parts = data.Split(',');
        return new EternalGoal(parts[0], parts[1], int.Parse(parts[2]));
    }
}
