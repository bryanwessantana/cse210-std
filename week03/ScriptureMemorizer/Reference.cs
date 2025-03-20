using System;
using System.Collections.Generic;
using System.Linq;

public class Reference
{
    public string _book { get; }
    public int _chapter { get; }
    public int _verse { get; }
    public int? _endVerse { get; }

    public Reference(string book, int chapter, int verse, int? endVerse = null)
    {
        if (string.IsNullOrWhiteSpace(book)) throw new ArgumentException("Book name cannot be empty.");
        if (chapter < 1 || verse < 1) throw new ArgumentOutOfRangeException("Chapter and verse must be 1 or greater.");
        if (endVerse is not null && endVerse < verse) throw new ArgumentException("End verse must be greater than or equal to the start verse.");

        _book = book;
        _chapter = chapter;
        _verse = verse;
        _endVerse = endVerse;
    }

    public string GetDisplayText() => _endVerse is null || _endVerse == _verse
        ? $"{_book} {_chapter}:{_verse}"
        : $"{_book} {_chapter}:{_verse}-{_endVerse}";
}