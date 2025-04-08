using System;
using System.Threading;

public class Activity
{
    protected string _name;
    protected string _description;
    protected int _duration;

    public Activity(string name, string description)
    {
        _name = name;
        _description = description;
    }

    // Method that gets the input of time the user wants to spend during the activity
    protected int GetDurationFromUser()
    {
        int duration;
        Console.Write("\nEnter the duration in seconds: ");
        while (!int.TryParse(Console.ReadLine(), out duration) || duration <= 0)
        {
            Console.Write("Please enter a valid positive number: ");
        }
        return duration;
    }

    public virtual void Run()
    {
        _duration = GetDurationFromUser();
    }

    // Standard that starts the activity the user choosed
    protected void DisplayStringMessage()
    {
        Console.WriteLine($"\nStarting {_name} Activity...\n{_description}\n");
        Thread.Sleep(2000);
    }

    // Standard that finish the activity the user choosed
    protected void DisplayEndingMessage()
    {
        Console.WriteLine($"\nWell done! You've completed the {_name} activity for {_duration} seconds.");
        ShowSpinner(2);
    }

    // Spinner Method to show a loading symbol while the program is running
    protected void ShowSpinner(int seconds)
    {
        string[] spinner = { "/", "-", "\\", "|" };
        DateTime endTime = DateTime.Now.AddSeconds(seconds);
        int i = 0;
        while (DateTime.Now < endTime)
        {
            Console.Write(spinner[i++ % spinner.Length]);
            Thread.Sleep(200);
            Console.Write("\b");
        }
    }

    // Method that shows the countdown
    protected void ShowCountdown(int seconds)
    {
        for (int i = seconds; i > 0; i--)
        {
            Console.Write(i + ", ");
            Thread.Sleep(1000);
        }
        Console.WriteLine(); // Move to the next line after the countdown
    }
}