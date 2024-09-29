using System;
using System.Collections.Generic;

public class Entry
{
    public DateTime theCurrentTime = DateTime.Now;
    public string _date = theCurrentTime.ToShortDateString();
    public string _promptText = PromptGenerator.GetRandomPrompts();
    public string _entryText;
    Console.WriteLine($"{_promptText}");
    _entryText = Console.ReadLine();
    _entries.Add(_date);
    _entries.Add(_promptText);
    _entries.Add(_entryText);
    
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