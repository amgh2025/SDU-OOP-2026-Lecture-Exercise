
using System;
using System.Collections.Generic;

public class Program
{
    public static void Main()
    {
        // Interface-based polymorphism
        ISet<string> students = new HashSet<string>();

        // Add elements
        Console.WriteLine(students.Add("Peter"));
        Console.WriteLine(students.Add("Henrik"));
        Console.WriteLine(students.Add("Sara"));

        // Try to add a duplicate
        Console.WriteLine(students.Add("Peter"));

        // Number of unique students
        Console.WriteLine("Count: " + students.Count);

        // Check if an element exists
        Console.WriteLine(
            "Contains Sara: " + students.Contains("Sara"));

        // Remove an element
        students.Remove("Henrik");

        // Print all elements
        foreach (string student in students)
        {
            Console.WriteLine(student);
        }

        // Remove everything
        students.Clear();

        Console.WriteLine("Final count: " + students.Count);
    }
}
