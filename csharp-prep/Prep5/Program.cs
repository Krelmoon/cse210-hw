using System;

class Program
{
    static void DisplayWelcome()
    {
        Console.WriteLine("Welcome to the Program!");
    }

    static string PromptUserName()
    {
        Console.Write("Please enter your name: ");
        string userName = Console.ReadLine();
        return userName;
    }

    static int PromptUserNumber()
    {
        Console.Write("Please enter your favorite number: ");
        string userInput = Console.ReadLine();
        int number = int.Parse(userInput);
        return number;
    }

    static double SquareNumber(int number)
    {
        double square = Math.Pow(number, 2);
        return square;
    }

    static void DisplayResult(string userName,double square)
    {
        Console.WriteLine($"{userName}, the square of your number is {square}.");
    }

    static void Main(string[] args)
    {
        DisplayWelcome();
        string userName = PromptUserName();
        int number = PromptUserNumber();
        double square = SquareNumber(number);
        DisplayResult(userName,square);
    }


}