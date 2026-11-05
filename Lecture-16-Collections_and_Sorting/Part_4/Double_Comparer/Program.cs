
using System;
using System.Collections.Generic;

public class DoubleComparer : IComparer<double>
{
    public int Compare(double x, double y)
    {
        return x.CompareTo(y);
    }
}

public class Program
{
    public static void Main()
    {
        List<double> numbers = new List<double>();

        numbers.Add(8.5);
        numbers.Add(2.3);
        numbers.Add(6.7);
        numbers.Add(1.2);

        Console.WriteLine("Before Sorting:");

        foreach (double number in numbers)
        {
            Console.WriteLine(number);
        }

        // Use our custom comparer
        numbers.Sort(new DoubleComparer());

        Console.WriteLine("\nAfter Sorting:");

        foreach (double number in numbers)
        {
            Console.WriteLine(number);
        }
    }
}
