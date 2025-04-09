public abstract class Goal
{
    protected string _shortName;
    protected string _description;
    protected int _points;

    public Goal(string name, string description, int points)
    {
        _shortName = name;
        _description = description;
        _points = points;
    }

    // Creating the methods
    public abstract void RecordEvent();
    public abstract bool IsComplete();
    public abstract string GetDetailsString();
    public abstract string GetStringRepresentation();

    // Method that get the points
    public int GetPoints()
    {
        return _points;
    }

    // Metho that get the name
    public string GetName()
    {
        return _shortName;
    }
}
