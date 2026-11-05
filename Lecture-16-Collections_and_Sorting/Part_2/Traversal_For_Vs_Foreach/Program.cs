
using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        List<int> numbers = new List<int>
        {
            10, 20, 30, 40, 50
        };

        // Example 1: for loop
        Console.WriteLine("Using for loop:");

        for (int i = 0; i < numbers.Count; i++)
        {
            Console.WriteLine("Index " + i + ": " + numbers[i]);
        }

        // Example 2: foreach loop
        Console.WriteLine("\nUsing foreach loop:");

        foreach (int number in numbers)
        {
            Console.WriteLine(number);
        }

        // Example 3: Update elements using for
        for (int i = 0; i < numbers.Count; i++)
        {
            numbers[i] = numbers[i] + 5;
        }

        Console.WriteLine("\nAfter updating:");

        foreach (int number in numbers)
        {
            Console.WriteLine(number);
        }
    }
}
