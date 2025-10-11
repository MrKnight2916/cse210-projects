using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        // Create list of activities
        List<Activity> activities = new List<Activity>();

        activities.Add(new Running("03 Nov 2022", 30, 3.0));   // 3 km
        activities.Add(new Cycling("03 Nov 2022", 45, 20.0));  // 20 km/h
        activities.Add(new Swimming("03 Nov 2022", 60, 40));   // 40 laps

        // Display summaries using polymorphism
        foreach (Activity activity in activities)
        {
            Console.WriteLine(activity.GetSummary());
        }
    }
}
