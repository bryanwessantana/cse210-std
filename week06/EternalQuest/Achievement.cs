using System;

public class Achievement
{
    private string _name;
    private string _description;
    private bool _isUnlocked;

    public Achievement(string name, string description)
    {
        _name = name;
        _description = description;
        _isUnlocked = false;
    }

    // The method that returns the name
    public string GetName()
    {
        return _name;
    }

    // The method that returns the description of the achievements
    public string GetDescription()
    {
        return _description;
    }

    // The method that says if the achievements are unlocked
    public bool IsUnlocked()
    {
        return _isUnlocked;
    }

    // If it is unlocked it will show the message:
    public void Unlock()
    {
        if (!_isUnlocked)
        {
            _isUnlocked = true;
            Console.WriteLine($"\n New achievement unlocked: {_name} - {_description}");
        }
    }
}
