public class Swimming : Activity
{
    private int _laps; // each lap = 50 meters
    private const double lapLengthKm = 0.05; // km

    public Swimming(string date, int minutes, int laps) : base(date, minutes)
    {
        _laps = laps;
    }

    public override double GetDistance()
    {
        return _laps * lapLengthKm; // km
    }

    public override double GetSpeed()
    {
        return (GetDistance() / Minutes) * 60;
    }

    public override double GetPace()
    {
        return Minutes / GetDistance();
    }
}
