using System;
using System.Collections.Generic;
using System.IO; 
class Program
{
    static void Main(string[] args)
    {
        // Welcoming the user - Working
        Console.WriteLine("Welcome to the Journal Program!");

        Journal journal = new Journal();
        PromptGenerator promptGenerator = new PromptGenerator();

        int numberInput = 0;
        while (numberInput != 5)
        {
            // Show the options to the user - Working
            Console.WriteLine("Please select one of the following choices: ");
            Console.WriteLine("1. Write");
            Console.WriteLine("2. Display");
            Console.WriteLine("3. Load");
            Console.WriteLine("4. Save");
            Console.WriteLine("5. Quit");

            if (int.TryParse(Console.ReadLine(), out numberInput))
            {
                if (numberInput == 1)
                {
                    // Showing the random prompt and asking for users answer
                    string randomPrompt = promptGenerator.GetRandomPrompt();
                    Console.WriteLine($"Prompt: {randomPrompt}");
                    Console.Write("Answer: ");
                    string userAnswer = Console.ReadLine();

                    // Pulling the date and hour of the user
                    string userDate = DateTime.Now.ToString("dd/MM/yyyy");
                    Entry newEntry = new Entry(userDate, randomPrompt, userAnswer);
                    
                    // Saving and creating a new journal
                    journal.AddEntry(newEntry);
                }
                else if (numberInput == 2)
                {
                    journal.DisplayAll();
                }
                else if (numberInput == 3)
                {
                    Console.WriteLine("Which file are you looking for?  ");
                    string fileName = Console.ReadLine();
                    journal.LoadFromFile(fileName);
                }
                else if (numberInput == 4)
                {
                    Console.WriteLine("How do you want to save it? ");
                    string fileName = Console.ReadLine();
                    journal.SaveToFile(fileName);
                }
                else if (numberInput == 5)
                {
                    // Finish the program if user answer 5 - Working
                    Console.WriteLine("You did a good job. Goodbye!");
                }

                else
                {
                    // Send a message to the user if it answers a number higher than 5 - Working
                    Console.WriteLine("Please, choose a valid number! (1-5)");
                }
            }
            else
            {
                Console.WriteLine("Invalid number. Please enter another one.");
            }
            
        }
    }
}