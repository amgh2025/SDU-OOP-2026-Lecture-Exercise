
using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        // Create a generic List of strings
        List<string> students = new List<string>();

        // 1. Add elements
        students.Add("Peter");
        students.Add("Henrik");
        students.Add("Emma");

        Console.WriteLine("Original List:");
        foreach (string student in students)
        {
            Console.WriteLine(student);
        }

        // 2. Contains - Check if an element exists
        bool exists = students.Contains("Peter");
        Console.WriteLine("\nContains Peter: " + exists);

        // 3. Insert - Add at a specific index
        students.Insert(1, "Thomas");

        Console.WriteLine("\nAfter Insert:");
        foreach (string student in students)
        {
            Console.WriteLine(student);
        }

        // 4. RemoveAt - Remove by index
        students.RemoveAt(2);

        Console.WriteLine("\nAfter RemoveAt(2):");
        foreach (string student in students)
        {
            Console.WriteLine(student);
        }

        // 5. Remove - Remove by value
        bool removed = students.Remove("Emma");
        Console.WriteLine("\nEmma removed: " + removed);

        // 6. IndexOf - Find the index
        int index = students.IndexOf("Thomas");
        Console.WriteLine("Thomas index: " + index);

        // 7. Update an existing element
        students[index] = "Sara";

        Console.WriteLine("\nFinal List:");
        foreach (string student in students)
        {
            Console.WriteLine(student);
        }
    }
}
