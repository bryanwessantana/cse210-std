using System;
using System.Collections.Generic;

public abstract class Activity
{
    // Private fields
    private double _minutes;
    private double _distance;
    private string _facilityName;

    // Constructor
    public Activity(double minutes, double distance, string facilityName)
    {
        _minutes = minutes;
        _distance = distance;
        _facilityName = facilityName;
    }

    // Encapsulated properties
    public double minutes => _minutes;
    public double distance => _distance;
    public string facilityName => _facilityName;

    // Abstract methods for specific calculations
    public abstract double GetDistance();
    public abstract double GetSpeed();
    public abstract double GetPace();

    // Summary method that can be used by all derived classes
    public virtual string GetSummary()
    {
        return $"{facilityName}\n" +
               $"Distance: {GetDistance():F2} km\n" +
               $"Speed: {GetSpeed():F2} km/h\n" +
               $"Pace: {GetPace():F2} min/km";
    }
}