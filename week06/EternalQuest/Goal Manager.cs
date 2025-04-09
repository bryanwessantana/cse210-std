using System;
using System.Collections.Generic;
using System.IO;
using System.Linq; // Required for LINQ

public class GoalManager
{
    private List<Goal> _goals = new List<Goal>();
    private int _score = 0;

    private List<Achievement> _achievements;

    // Constructor initializes achievements
    public GoalManager()
    {
        _achievements = new List<Achievement>
        {
            new Achievement("First Steps", "Complete your first goal!"),
            new Achievement("Point Collector", "Reach 1000 total points."),
            new Achievement("Checklist Master", "Complete a checklist goal."),
            new Achievement("GOAT!", "Complete 10 goals.")
        };
    }

    public void Start()
    {
        string choice;

        do
        {
            Console.WriteLine("Welcome to the Eternal Quest Program!");
            Console.WriteLine($"- You have {_score} points.");
            Console.WriteLine("\n1. Create Goal");
            Console.WriteLine("2. List Goals");
            Console.WriteLine("3. Record Event");
            Console.WriteLine("4. Save Goals");
            Console.WriteLine("5. Load Goals");
            Console.WriteLine("6. View Achievements");
            Console.WriteLine("7. Quit\n");
            Console.Write("Choose an option: ");
            choice = Console.ReadLine();

            switch (choice)
            {
                case "1": CreateGoal(); break;
                case "2": ListGoals(); break;
                case "3": RecordEvent(); break;
                case "4": SaveGoals(); break;
                case "5": LoadGoals(); break;
                case "6": ShowAchievements(); break;
            }

        } while (choice != "7");
    }

    private void CreateGoal()
    {
        Console.WriteLine("\nGoal Types:");
        Console.WriteLine("1. Simple");
        Console.WriteLine("2. Eternal");
        Console.WriteLine("3. Checklist");
        Console.Write("Select type: ");
        string type = Console.ReadLine();

        Console.Write("\nName: ");
        string name = Console.ReadLine();
        Console.Write("Description: ");
        string desc = Console.ReadLine();
        Console.Write("Points: ");
        if (!int.TryParse(Console.ReadLine(), out int points))
        {
            Console.WriteLine("Invalid input. Goal not created.");
            return;
        }

        switch (type)
        {
            case "1":
                _goals.Add(new SimpleGoal(name, desc, points));
                break;
            case "2":
                _goals.Add(new EternalGoal(name, desc, points));
                break;
            case "3":
                Console.Write("Target count: ");
                int target = int.Parse(Console.ReadLine());
                Console.Write("Bonus: ");
                int bonus = int.Parse(Console.ReadLine());
                _goals.Add(new ChecklistGoal(name, desc, points, target, bonus));
                break;
        }

        Console.WriteLine("Goal created.");
    }

    private void ListGoals()
    {
        if (_goals.Count == 0)
        {
            Console.WriteLine("No goals added.");
            return;
        }

        Console.WriteLine("\nYour Goals:");
        for (int i = 0; i < _goals.Count; i++)
        {
            Console.WriteLine($"{i + 1}. {_goals[i].GetDetailsString()}");
        }
    }

    private void RecordEvent()
    {
        if (_goals.Count == 0)
        {
            Console.WriteLine("No goals to record.");
            return;
        }

        Console.WriteLine("\nWhich goal did you complete?");
        for (int i = 0; i < _goals.Count; i++)
        {
            Console.WriteLine($"{i + 1}. {_goals[i].GetName()}");
        }

        Console.Write("Enter number: ");
        if (!int.TryParse(Console.ReadLine(), out int index) || index < 1 || index > _goals.Count)
        {
            Console.WriteLine("Invalid selection.");
            return;
        }

        index--;

        Goal goal = _goals[index];

        if (goal.IsComplete())
        {
            Console.WriteLine("This goal is already complete. No points awarded.");
            return;
        }

        goal.RecordEvent();

        int pointsEarned = goal.GetPoints();
        _score += pointsEarned;

        if (goal is EternalGoal)
        {
            Console.WriteLine($"You earned {pointsEarned} points.");
        }

        if (goal is ChecklistGoal checklist)
        {
            if (checklist.IsComplete() && !checklist.BonusGiven)
            {
                int bonus = checklist.GetBonus();
                _score += bonus;
                checklist.MarkBonusGiven();
                Console.WriteLine($"Bonus! You earned {bonus} extra points.");
            }
        }

        CheckAchievements();
    }

    private void CheckAchievements()
    {
        int completedGoals = _goals.Count(g => g.IsComplete());

        foreach (var achievement in _achievements)
        {
            switch (achievement.GetName())
            {
                case "First Steps":
                    if (_goals.Any(g => g.IsComplete()))
                        achievement.Unlock();
                    break;

                case "Point Collector":
                    if (_score >= 100)
                        achievement.Unlock();
                    break;

                case "Checklist Champ":
                    if (_goals.OfType<ChecklistGoal>().Any(g => g.IsComplete()))
                        achievement.Unlock();
                    break;

                case "Goal Master":
                    if (completedGoals >= 5)
                        achievement.Unlock();
                    break;
            }
        }
    }

    private void ShowAchievements()
    {
        Console.WriteLine("\nYour achievements:");
        foreach (var ach in _achievements)
        {
            Console.WriteLine($"{(ach.IsUnlocked() ? "[X]" : "[ ]")} {ach.GetName()} - {ach.GetDescription()}");

        }
    }

    private void SaveGoals()
    {
        Console.Write("Filename to save: ");
        string filename = Console.ReadLine();

        using (StreamWriter writer = new StreamWriter(filename))
        {
            writer.WriteLine(_score);
            foreach (Goal goal in _goals)
                writer.WriteLine(goal.GetStringRepresentation());

            writer.WriteLine("= Achievements =");
            foreach (var ach in _achievements)
            {
                writer.WriteLine($"{ach.GetName()}|{ach.IsUnlocked()}");
            }

        }

        Console.WriteLine("Goals saved.");
    }

    private void LoadGoals()
    {
        Console.Write("Filename to load: ");
        string filename = Console.ReadLine();

        if (!File.Exists(filename))
        {
            Console.WriteLine("File not found.");
            return;
        }

        string[] lines = File.ReadAllLines(filename);
        _goals.Clear();

        int i = 0;
        _score = int.Parse(lines[i++]);

        while (i < lines.Length && lines[i] != "===Achievements===")
        {
            string[] parts = lines[i++].Split('|');
            string type = parts[0];
            string name = parts[1];
            string desc = parts[2];
            int points = int.Parse(parts[3]);

            switch (type)
            {
                case "SimpleGoal":
                    bool done = bool.Parse(parts[4]);
                    var simple = new SimpleGoal(name, desc, points);
                    if (done) simple.RecordEvent();
                    _goals.Add(simple);
                    break;

                case "EternalGoal":
                    _goals.Add(new EternalGoal(name, desc, points));
                    break;

                case "ChecklistGoal":
                    int bonus = int.Parse(parts[4]);
                    int target = int.Parse(parts[5]);
                    int completed = int.Parse(parts[6]);
                    bool bonusGiven = bool.Parse(parts[7]);
                    var checklist = new ChecklistGoal(name, desc, points, target, bonus);
                    for (int j = 0; j < completed; j++) checklist.RecordEvent();
                    if (bonusGiven) checklist.MarkBonusGiven();
                    _goals.Add(checklist);
                    break;
            }
        }

        // Load achievements
        i++; // skip ===Achievements===
        for (; i < lines.Length; i++)
        {
            string[] achParts = lines[i].Split('|');
            string achName = achParts[0];
            bool unlocked = bool.Parse(achParts[1]);

            var match = _achievements.FirstOrDefault(a => a.GetName() == achName);
            if (match != null && unlocked)
                match.Unlock();
        }
    }
}