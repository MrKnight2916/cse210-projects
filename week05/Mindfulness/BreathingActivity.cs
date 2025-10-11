using System;

public class BreathingActivity : Activity
{
    public BreathingActivity()
    {
        _name = "Breathing Activity";
        _description = "This activity will help you relax by guiding you to breathe in and out slowly. Clear your mind and focus on your breathing.";
    }

    public override void Run()
    {
        DateTime endTime = DateTime.Now.AddSeconds(_duration);

        while (DateTime.Now < endTime)
        {
            Console.Write("\nBreathe in... ");
            ShowCountDown(4); // inhale
            Console.WriteLine();
            Console.Write("Breathe out... ");
            ShowCountDown(6); // exhale
            Console.WriteLine();
        }
    }
}
