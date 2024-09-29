using System;

class Program
{
    private static void Main(string[] args)
    {
        bool showMenu = true;
        while (showMenu)
        {   
            showMenu = MainMenu();
        }
    }
    private static bool MainMenu()
        {
            Console.WriteLine("Please select one of the following choices: ");
            Console.WriteLine("1. Write");
            Console.WriteLine("2. Display");
            Console.WriteLine("3. Load");
            Console.WriteLine("4. Save");
            Console.WriteLine("5. Quit");
            Console.WriteLine("What would you like to do? ");
            Console.Write("> ");
 
            switch (Console.ReadLine())
            {
                case "1":
                    Journal.AddEntry();
                    return true;
                case "2":
                    Entry.Display();
                    return true;
                case "3":
                    Journal.LoadFromFile();
                    return true;
                case "4":
                    Journal.SaveToFile();
                    return true;
                case "5":
                    return false;
                default:
                    return true;
            }
        }
}