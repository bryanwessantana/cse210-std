public class EternalGoal : Goal
{
    public EternalGoal(string name, string description, int points)
        : base(name, description, points) { }

    // Returning the amount of points to the user
    public override void RecordEvent()
    {
        Console.WriteLine($"You earned {_points} points for this eternal goal!");
    }

    // If the goal is completed
    public override bool IsComplete()
    {
        return false;
    }

    // Getting the details and showing to the user
    public override string GetDetailsString()
    {
        return $"[ ] {_shortName} ({_description})";
    }

    // Getting the kind of goal and showing the informations
    public override string GetStringRepresentation()
    {
        return $"EternalGoal|{_shortName}|{_description}|{_points}";
    }
}
