using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Guess the magic number");
        Random randomGenerator = new Random();
        int number = randomGenerator.Next(1, 100);
        int guess = (0);
        do
        {
        Console.Write("What is your guess ? ");
        string guessInput = Console.ReadLine();
        guess = int.Parse(guessInput);
        if (guess == number)
        {
            Console.WriteLine("you guessed correctly!");
        }
        else if (guess > number)
        {
            Console.WriteLine("Lower");
        }
        else
        {
            Console.WriteLine("Higher");       
        }
        } while (guess != number);
        {
            Console.WriteLine("Thank you for playing the game!");
        }
    }
}