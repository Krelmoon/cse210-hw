using System;
using System.Linq;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        List<int> numbers = new List<int>();
        Console.WriteLine("Enter a list of numbers, type 0 when finished.");
        int number = (1);
        do
        {
            Console.Write("Enter Number: ");
            string numberInput = Console.ReadLine();
            number = int.Parse(numberInput);
            numbers.Add(number);
        } while (number != 0);
        {
            int sum = numbers.AsQueryable().Sum();
            Console.WriteLine($"The sum is: {sum}");
            double average = Queryable.Average(numbers.AsQueryable()); 
            Console.WriteLine($"The average is: {average}");
            Console.WriteLine($"The largest number is: {numbers.Max(z => z)}");
        }
        
    }
}