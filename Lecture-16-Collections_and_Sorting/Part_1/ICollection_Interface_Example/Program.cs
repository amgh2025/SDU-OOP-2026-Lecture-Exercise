
using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        // Create a collection using the ICollection interface
        ICollection<string> students = new List<string>();

        // 1. ADD elements
        students.Add("Peter");
        students.Add("Henrik");
        students.Add("Emma");

        Console.WriteLine("Original collection:");

        foreach (string student in students)
        {
            Console.WriteLine(student);
        }

        // 2. REMOVE one element
        students.Remove("Henrik");

        Console.WriteLine("\nAfter removing Henrik:");

        foreach (string student in students)
        {
            Console.WriteLine(student);
        }

        // 3. CLEAR all elements
        students.Clear();

        Console.WriteLine("\nAfter clearing:");
        Console.WriteLine("Count: " + students.Count);
    }
}
