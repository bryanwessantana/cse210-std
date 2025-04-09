public class ChecklistGoal : Goal
{
    private int _amountCompleted;
    private int _target;
    private int _bonus;

    public ChecklistGoal(string name, string description, int points, int target, int bonus)
        : base(name, description, points)
    {
        _amountCompleted = 0;
        _target = target;
        _bonus = bonus;
    }

    // If the goal is completed it will give a bonus only once
    private bool _bonusGiven = false;

    public override void RecordEvent()
    {
        if (_amountCompleted < _target)
        {
            _amountCompleted++;
        }
    }

    public bool BonusGiven => _bonusGiven;

    public void MarkBonusGiven()
    {
        _bonusGiven = true;
    }

    // If the goal is completed compared to the target
    public override bool IsComplete()
    {
        return _amountCompleted >= _target;
    }

    // Getting the details and returning to the user
    public override string GetDetailsString()
    {
        return $"[{(_amountCompleted >= _target ? "X" : " ")}] {_shortName} ({_description}) -- Completed: {_amountCompleted}/{_target}";
    }

    // Getting the kind of goal and showing the informations
    public override string GetStringRepresentation()
    {
        return $"ChecklistGoal|{_shortName}|{_description}|{_points}|{_bonus}|{_target}|{_amountCompleted}|{_bonusGiven}";
    }

    // Method to get a bonus to the user
    public int GetBonus()
    {
        return _bonus;
    }

    // Getting the completed amount
    public int GetAmountCompleted()
    {
        return _amountCompleted;
    }

    // Getting the target
    public int GetTarget()
    {
        return _target;
    }
}
