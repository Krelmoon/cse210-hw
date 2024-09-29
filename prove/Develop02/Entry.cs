using System;
using System.Collections.Generic;

public class Entry
{
    
    
    public void Display()
    {
        Console.Write($"Date: {_date}");
        Console.Write($"- Prompt: {_promptText}");
        Console.WriteLine($"{_entryText}");
        foreach (Entry entry in _entries)
        {
            entry.Display();
        }
    }
}