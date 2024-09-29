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

    }
    static void LoadFromFile()
    {

    }
}
