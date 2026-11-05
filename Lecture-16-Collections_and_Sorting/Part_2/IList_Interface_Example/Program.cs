
using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        // Create a List using the IList interface
        IList<string> students = new List<string>();

        // 1. Add elements
        students.Add("Peter");
        students.Add("Henrik");
        students.Add("Emma");

        // 2. Count property
        Console.WriteLine("Count: " + students.Count);

        // 3. Access elements by index
        Console.WriteLine("First: " + students[0]);
        Console.WriteLine("Second: " + students[1]);

        // 4. Insert an element at index 1
        students.Insert(1, "Thomas");

        Console.WriteLine("\nAfter Insert:");
        foreach (string student in students)
        {
            Console.WriteLine(student);
        }

        // 5. Find the index of an element
        int index = students.IndexOf("Henrik");
        Console.WriteLine("\nHenrik's index: " + index);

        // 6. Update an element by index
        students[0] = "Sara";

        Console.WriteLine("\nAfter Update:");
        foreach (string student in students)
        {
            Console.WriteLine(student);
        }

        // 7. Remove an element by index
        students.RemoveAt(2);

        Console.WriteLine("\nAfter RemoveAt:");
        foreach (string student in students)
        {
            Console.WriteLine(student);
        }
    }
}
