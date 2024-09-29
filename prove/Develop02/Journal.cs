using System;
using System.IO;
using System.Collections.Generic;

public class Journal
{
    public List<Entry> _entries = new List<Entry>();
    
    public void AddEntry()
    {
        
        public DateTime theCurrentTime = DateTime.Now;
        public string _date = theCurrentTime.ToShortDateString();
        public string _promptText = PromptGenerator.GetRandomPrompts();
        public string _entryText;
        Console.WriteLine($"{_promptText}");
    _   entryText = Console.ReadLine();
    _   entries.Add(_date);
    _   entries.Add(_promptText);
    _   entries.Add(_entryText);
    }
    public void SaveToFile()
    {
        string fileName;
        Console.WriteLine("What is the filename?");
        fileName = Console.ReadLine();
        using (StreamWriter outputFile = new StreamWriter(fileName))
        {
            foreach (Entry e in _entries)
            {
            outputFile.WriteLine($"Date: {e._date}`~`- Prompt: {e._promptText}`~`{e._entryText}");
            }
        }
    }
    public void LoadFromFile()
    {
        string fileName;
        Console.WriteLine("What is the filename?");
        fileName = Console.ReadLine();
        string[] _entries = System.IO.File.ReadAllLines(fileName);

        foreach (string line in _entries)
        {
            string[] parts = line.Split("`~`");
            
            string _date = parts[0];
            string _promptText = parts[1];
            string _entryText = parts[2];
        }
    }
}