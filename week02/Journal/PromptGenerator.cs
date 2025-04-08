using System;
using System.Collections.Generic;
public class PromptGenerator
{
    // List of questions - Working
    public List<string> questions;

    // List of random questions to the user - Working
    public PromptGenerator()
    {
        questions = new List<string>
        {
            "What was the best moment in your day today?",
            "Who was the most interesting person I interacted with today?",
            "How did you start the day?",
            "What was the strongest emotion I felt today?",
            "If I had one thing I could do over today, what would it be?"
        };
    }    

    // Randomizing the questions from the list - Working
    public string GetRandomPrompt()
    {    
        Random random = new Random();
        int index = random.Next(questions.Count);
        return questions[index];
    }
}