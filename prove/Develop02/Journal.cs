using System;
using System.IO;
using System.Collections.Generic;

public class Journal
{
    public List<Entry> _entries = new List<Entry>();
    string userInput;
    int select;

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
        select = int.private Parse(userInput);
        
        if (select == 1) 
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


    static void AddEntry()
    {
        Entry();
    }
    static void DisplayAll()
    {
        Entry.Display();
    }
    static void SaveToFile()
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
    static void LoadFromFile()
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