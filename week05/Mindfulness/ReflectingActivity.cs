using System;
using System.Collections.Generic;

public class ReflectingActivity : Activity
{
    private static readonly Random _random = new Random(); // Shared static Random instance

    private List<string> _prompts;
    private List<string> _questions;

    // List of prompts that the program is going to pick one to the user
    public ReflectingActivity() : base("reflecting", "This activity will help you reflect on times in your life when you have shown strength and resilience. \nThis will help you recognize the power you have and how you can use it in other aspects of your life.")
    {
        _prompts = new List<string>
        {
            "Think of a time when you stood up for someone else.",
            "Think of a time when you did something really difficult.",
            "Think of a time when you helped someone in need.",
            "Think of a time when you did something truly selfless."
        };

    // List of questions that the program is going to pick one to the user
        _questions = new List<string>
        {
            "Why was this experience meaningful?",
            "What did you learn about yourself?",
            "How can you apply this in your life?",
            "Why was this experience meaningful to you?",
            "Have you ever done anything like this before?",
            "How did you get started?",
            "How did you feel when it was complete?",
            "What made this time different than other times when you were not as successful?",
            "What is your favorite thing about this experience?",
            "What could you learn from this experience that applies to other situations?",
            "What did you learn about yourself through this experience?",
            "How can you keep this experience in mind in the future?"
        };
    }

    // Method that shows the prompt to the user and count the time
    public override void Run()
    {
        base.Run();
        DisplayStringMessage();

        Console.WriteLine("Prompt: " + GetRandomPrompt());
        ShowSpinner(2);

        DateTime endTime = DateTime.Now.AddSeconds(_duration);
        while (DateTime.Now < endTime)
        {
            Console.WriteLine(GetRandomQuestion());
            ShowSpinner(5);
        }

        DisplayEndingMessage();
    }

    // Method that pick the random prompt from the list of prompts to the user
    private string GetRandomPrompt()
    {
        return _prompts[_random.Next(_prompts.Count)];
    }

    // Method that pick the random question from the list of questions to the user
    private string GetRandomQuestion()
    {
        return _questions[_random.Next(_questions.Count)];
    }
}
