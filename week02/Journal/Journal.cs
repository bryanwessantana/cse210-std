using System;
using System.Collections.Generic;
using System.IO;

public class Journal
{
    public List<Entry> _entries;

    // Inicializing the entry list
    public Journal()
    {
        _entries = new List<Entry>();
    }

    // Adding a new entry
    public void AddEntry(Entry newEntry)
    {
        _entries.Add(newEntry);
        Console.WriteLine("Entry added with success in the Journal.");
        Console.WriteLine("");
    }

    // Displaying all the entries
    public void DisplayAll()
    {
        if (_entries.Count == 0)
        {
            Console.WriteLine("No entries found!");
            Console.WriteLine("");
        }
        else
        {
            Console.WriteLine("");
            Console.WriteLine("Entry:");
            foreach (var entry in _entries)
            {
                entry.Display();
                Console.WriteLine();
            }
        }
    }

    public void SaveToFile(string file)
    {
        using(StreamWriter writer = new StreamWriter(file))
        {
            foreach (var entry in _entries)
            {
                writer.WriteLine($"{entry._date} - {entry._promptText} - {entry._entryText}");
            }
        }
        Console.WriteLine("Entries saved in the file!");
        Console.WriteLine("");
    }

    public void LoadFromFile(string file)
    {
        if (File.Exists(file))
        {
            _entries.Clear();
            string[] lines = File.ReadAllLines(file);

            foreach (var line in lines)
            {
                string[] parts = line.Split(" - ");
                if (parts.Length == 4)
                {
                    Entry loadedEntry = new Entry(parts[0], parts[1], parts[2]);
                    _entries.Add(loadedEntry);
                }
            }
        Console.WriteLine("Entries loaded from the file!");
        Console.WriteLine("");
        }
        else
        {
            Console.WriteLine("File not found");
            Console.WriteLine("");
        }
    }

}