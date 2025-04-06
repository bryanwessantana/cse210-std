using System;
using System.Collections.Generic;

public class ListingActivity : Activity
{
    private List<string> _prompts;

    // List of prompts that the program is going to pick one to the user
    public ListingActivity() : base("listing", "This activity will help you reflect on the good things in your life by \nhaving you list as many things as you can in a certain area.")
    {
        _prompts = new List<string>
        {
            "List things that make you happy.",
            "List people you are grateful for.",
            "List things you are proud of.",
            "Who are people that you appreciate?",
            "What are personal strengths of yours?",
            "Who are people that you have helped this week?",
            "When have you felt the Holy Ghost this month?",
            "Who are some of your personal heroes?"
        };
    }

    // Method that gives the prompt to the user and when the time is done, shows how many items he added to the list
    public override void Run()
    {
        base.Run();
        DisplayStringMessage();

        Console.WriteLine("\nPrompt: " + GetRandomPrompt());
        Console.WriteLine("Start listing...\n");

        List<string> responses = GetListFromUser();
        Console.WriteLine($"You listed {responses.Count} items!");

        DisplayEndingMessage();
    }

    // Method that gives the random prompt to the user
    private string GetRandomPrompt()
    {
        Random rand = new Random();
        return _prompts[rand.Next(_prompts.Count)];
    }

    // Method that counts the time while the user is adding items to the list
    private List<string> GetListFromUser()
    {
        List<string> responses = new List<string>();
        DateTime end = DateTime.Now.AddSeconds(_duration);
        while (DateTime.Now < end)
        {
            Console.Write("> ");
            string input = Console.ReadLine();
            if (!string.IsNullOrWhiteSpace(input))
                responses.Add(input);
        }
        return responses;
    }
}
