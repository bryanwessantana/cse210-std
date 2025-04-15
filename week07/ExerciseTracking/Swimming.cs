using System;
using System.Collections.Generic;

public class Swimming : Activity
{
    private int _laps;

    public Swimming(double minutes, int laps) : base(minutes, 0, "Swimming")
    {
        _laps = laps;
    }

    public override double GetDistance()
    {
        // Distance in kilometers (1 lap = 50 meters, so laps * 50 / 1000)
        return (_laps * 50) / 1000; 
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