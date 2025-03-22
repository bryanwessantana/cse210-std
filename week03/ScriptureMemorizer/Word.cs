using System;
using System.Collections.Generic;
using System.Linq;

public class Word
{
    private string _text { get; }
    public bool IsHidden { get; private set; }

    public Word(string text)
    {
        _text = text;
        IsHidden = false;
    }

    public void Hide() => IsHidden = true;
    public string GetDisplayText() => IsHidden ? new string('_', _text.Length) : _text;
}