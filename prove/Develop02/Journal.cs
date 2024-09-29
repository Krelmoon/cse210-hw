using System;
using System.IO;
using System.Collections.Generic;

public class Journal
{
    public List<Entry> _entries = new List<Entry>();
    public string userInput;
    public int number;
    do
    {
        Console.WriteLine("Please select one of the following choices: ");
        Console.WriteLine("1. Write");
        Console.WriteLine("2. Display");
        Console.WriteLine("3. Load");
        Console.WriteLine("4. Save");
        Console.Writeline("5. Quit");
        Console.Writeline("What would you like to do? ");
        Console.Write("> ");
        userInput = Console.ReadLine();
        number = int.Parse(userInput);
        if (number == 1)
        {
            AddEntry();
        }
        else if (number == 2)
        {
            Entry.Display();
        }
        else if (number == 3)
        {
            LoadFromFile();
        }
        else if (number == 4)
        {
            SaveToFile();
        }
        else
        {
            Console.WriteLine("Invalid Responce!")
        }
    } while (number != 5);
        {
            Console.WriteLine("Thank you for using this program"); 
        }
    }

    public static void AddEntry()
    {
        Entry();
    }
    public static void DisplayAll()
    {
        Entry.Display();
    }
    public static void SaveToFile()
    {
        string fileName;
        Console.WriteLine("What is the filename?")
        fileName = Console.ReadLine();
        using (StreamWriter outputFile = new StreamWriter(fileName))
        {
            foreach (Entry e in _entries)
            {
            outputFile.WriteLine($""Date: {e._date}`~`- Prompt: {e._promptText}`~`{e._entryText}");
            }
        }
    }
    public static void LoadFromFile()
    {
        string fileName;
        Console.WriteLine("What is the filename?")
        filename = Console.ReadLine();
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
