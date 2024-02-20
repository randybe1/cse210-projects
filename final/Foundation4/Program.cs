using System;
namespace Foundation4
{
class Program
{
    static void Main(string[] args)
    {
        List<Activity> activities = new List<Activity>();

        Running run = new Running("February 17th, 2024",  35, "Running", 3);
        activities.Add(run);

        Cycling cycling = new Cycling("February 18th, 2024", 60, "Cycling", 12);
        activities.Add(cycling);

        Swimming swimming = new Swimming("February 19th, 2024", 45, "Swimming", 20);
        activities.Add(swimming);
        
        Console.WriteLine("Welcome to the Exercise Tracking Program!");
        Console.WriteLine("Your activities for this week are:\n");

        foreach (Activity a in activities)
        {
            Console.WriteLine(a.GetSummary());
        }

    }
}
}
