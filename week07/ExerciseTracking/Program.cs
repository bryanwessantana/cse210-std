using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Welcome to the Exercise Tracking Program!");
        
        // Creating instances of different activities
        var activities = new List<Activity>
        {
            new Running(30, 5),
            new Cycling(60, 20),
            new Swimming(45, 30)
        };

        // Iterating through the activities and displaying their summaries
        foreach (var activity in activities)
        {
            Console.WriteLine(activity.GetSummary());
            Console.WriteLine();
        }
    }
}