public class SimpleGoal : Goal
{
    private bool _isComplete;

    public SimpleGoal(string name, string description, int points)
        : base(name, description, points)
    {
        _isComplete = false;
    }

    // If the goal is completed
    public override void RecordEvent()
    {
        if (!_isComplete)
        {
            _isComplete = true;
        }
        else
        {
            Console.WriteLine("This goal is completed!");
        }
    }

    // If the goal is completed
    public override bool IsComplete()
    {
        return _isComplete;
    }

    // Getting the details and showing to the user
    public override string GetDetailsString()
    {
        return $"[{(_isComplete ? "X" : " ")}] {_shortName} ({_description})";
    }

    // Getting the kind of goal and showing the informations
    public override string GetStringRepresentation()
    {
        return $"SimpleGoal|{_shortName}|{_description}|{_points}|{_isComplete}";
    }
}
