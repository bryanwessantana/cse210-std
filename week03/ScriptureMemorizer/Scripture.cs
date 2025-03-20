using System;
using System.Collections.Generic;
using System.Linq;

class Scripture
{
    public Reference Reference { get; } //
    private List<Word> _words; //
    private Random _random = new Random();

    public Scripture(Reference reference, string text) //
    {
        Reference = reference;
        _words = text.Split(' ').Select(w => new Word(w)).ToList();
    }

    public void HideRandomWords()
    {
        int index;
        do
        {
            index = _random.Next(_words.Count);
        } while (_words[index].IsHidden); // Ensure we don't hide the same word twice
        _words[index].Hide();
    }

    public string GetDisplayText() => string.Join(" ", _words.Select(w => w.GetDisplayText()));

    public bool IsCompletelyHidden() => _words.All(w => w.IsHidden);
}