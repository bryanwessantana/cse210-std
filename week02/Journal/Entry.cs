using System;

public class Entry
{
    // Pulling the date and hour of the user
    public string _date;
    public string _promptText;
    public string _entryText;

    // Pulling the prompt text randomly choosed by the program
    public Entry(string date, string promptText, string entryText)
    {
        _date = date;
        _promptText = promptText;
        _entryText = entryText;
    }

    // Displaying the entry details 
    public void Display()
    {
        Console.WriteLine($"Date and hour: {_date}");
        Console.WriteLine($"Program prompt: {_promptText}");
        Console.WriteLine($"User entry: {_entryText}");
        Console.WriteLine("");
    }
}