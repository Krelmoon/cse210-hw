using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("What is your grade percentage ? ");
        string userInput = Console.ReadLine();
        int number = int.Parse(userInput);
        string letter = ("F");
        if (number >= 90)
        {
            letter = ("A");
        }
        else if (number >= 80)
        {
            letter = ("B");
        }
        else if (number >= 70)
        {
            letter = ("C");
        }
        else if (number >= 60)
        {
            letter = ("D");
        }
        else
        {
            letter = ("F");
        }
            if (number >= 70)
            {
                Console.WriteLine("Congratulations on passing this course");
                Console.WriteLine($"your letter grade is {letter}");
            }
            else
            {
            Console.WriteLine("I`m sorry you didn`t pass. I hope you do better next time");
            Console.WriteLine($"your letter grade is {letter}");
            }
    }
}