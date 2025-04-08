using System;
using System.Collections.Generic;
using System.Linq;

class Program
{
    static void Main()
    {
        List<Scripture> scriptures = LoadScripturesFromFile();
        
        if (scriptures.Count == 0)
        {
            scriptures = new List<Scripture>
            {
                new Scripture(new Reference("John", 3, 16), "For God so loved the world that he gave his only begotten Son."),                        new Scripture(new Reference("2 Nephi", 2, 25), "Adam fell that men might be; and men are, that they might have joy."),
                new Scripture(new Reference("Genesis", 2, 24), "Therefore shall a man leave his father and his mother, and shall cleave unto his wife: and they shall be one flesh."),
                new Scripture(new Reference("D&C", 6, 36), "Look unto me in every thought; doubt not, fear not."),
                new Scripture(new Reference("Proverbs", 3, 5, 6), "Trust in the Lord with all thine heart; and lean not unto thine own understanding. In all thy ways acknowledge him, and he shall direct thy paths.")
            };

                Console.WriteLine("No file found or invalid format. Using default scriptures.");
                System.Threading.Thread.Sleep(2000); // Pause before proceeding
        }


        var random = new Random();
        scriptures = scriptures.OrderBy(_ => random.Next()).ToList(); // Shuffle the list for random starting scripture

        foreach (var scripture in scriptures)
        {
            Console.Clear();
            Console.WriteLine($"Reference: {scripture.Reference.GetDisplayText()}");
            Console.WriteLine($"Scripture: {scripture.GetDisplayText()}");

            int wordsToHide = 1;

            while (!scripture.IsCompletelyHidden())
            {
                Console.WriteLine("\nPress Enter to hide some words...");
                Console.ReadLine();

                scripture.HideRandomWords();
                wordsToHide++; // Increase difficulty progressively

                Console.Clear();
                Console.WriteLine($"Reference: {scripture.Reference.GetDisplayText()}");
                Console.WriteLine($"Scripture: {scripture.GetDisplayText()}");
            }

            break;
        }
            
        
    }

    static List<Scripture> LoadScripturesFromFile()
    {
        string filePath = "scriptures.txt";
        var scriptures = new List<Scripture>();

        if (!File.Exists(filePath))
        {
            Console.WriteLine("Scripture file not found. Skipping file load.");
            return scriptures;
        }

        try
        {
            foreach (var line in File.ReadAllLines(filePath))
            {
                if (string.IsNullOrWhiteSpace(line)) continue;

                var parts = line.Split('|');
                if (parts.Length != 2) continue;

                var referencePart = parts[0].Trim();
                var textPart = parts[1].Trim();

                var referenceMatch = System.Text.RegularExpressions.Regex.Match(referencePart, @"(.+) (\d+):(\d+)(?:-(\d+))?");
                if (!referenceMatch.Success) continue;

                string book = referenceMatch.Groups[1].Value;
                int chapter = int.Parse(referenceMatch.Groups[2].Value);
                int verse = int.Parse(referenceMatch.Groups[3].Value);
                int? endVerse = referenceMatch.Groups[4].Success ? int.Parse(referenceMatch.Groups[4].Value) : (int?)null;

                scriptures.Add(new Scripture(new Reference(book, chapter, verse, endVerse), textPart));
            }
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Error reading file: {ex.Message}");
        }

        return scriptures;
    }
}