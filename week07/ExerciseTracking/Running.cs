using System;
using System.Collections.Generic;

public class Running : Activity
{
    public Running(double minutes, double distance) : base(minutes, distance, "Running") { }

    public override double GetDistance()
    {
        return distance; // Already in km
    }

    public override double GetSpeed()
    {
        return (GetDistance() / minutes) * 60; // Speed in km/h
    }

    public override double GetPace()
    {
        return minutes / GetDistance(); // Pace in min/km
    }
}